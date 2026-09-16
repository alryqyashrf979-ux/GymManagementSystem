using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsFrozenSubscription
    {



        private int _FreezeID;
        public int FreezeID { get { return _FreezeID; } }
        public int SubscriptionID { set; get; }
        public DateTime FreezeStartDate { set; get; }
        public DateTime FreezeEndDate { set; get; }
        public DateTime? UnFreezeDate { set; get; }//to allow null
        public byte FreezingDuration { set; get; }
        public double FreezeFee { set; get; }
        public string FreezeReason { set; get; }
        public bool IsFeesPaid { set; get; }
        public bool IsFrozen { set; get; }
        public int FrozenByUserID { set; get; }
        public int UnfrozenByUserID { set; get; }

        private clsSubscription _SubscriptionInfo;
        public clsSubscription SubscriptionInfo { get { return _SubscriptionInfo; } }

        private clsUsers _FrozenByUserInfo;
        private clsUsers _UnFrozenByUserInfo;

        public clsUsers FrozenByUserInfo { get { return _FrozenByUserInfo; } }
        public clsUsers UnFrozenByUserInfo { get { return _UnFrozenByUserInfo; } }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        private clsFrozenSubscription(int freezeID, int subscriptionID, DateTime freezeStartDate, DateTime freezeEndDate,
            DateTime? unFreezeDate, byte freezingDuration, double freezeFee, string freezeReason,
            bool isFeesPaid, bool isFrozen, int frozenByUserID, int unfrozenByUserID)
        {
            this._FreezeID = freezeID;
            this.SubscriptionID = subscriptionID;
            this.FreezeStartDate = freezeStartDate;
            this.FreezeEndDate = freezeEndDate;
            this.UnFreezeDate = unFreezeDate;
            this.FreezingDuration = freezingDuration;
            this.FreezeFee = freezeFee;
            this.FreezeReason = freezeReason;
            this.IsFeesPaid = isFeesPaid;
            this.IsFrozen = isFrozen;
            this.FrozenByUserID = frozenByUserID;
            this.UnfrozenByUserID = unfrozenByUserID;

            this._SubscriptionInfo = clsSubscription.FindBySubscriptionID(subscriptionID);

            if(unfrozenByUserID!=-1)
            this._UnFrozenByUserInfo=clsUsers.FindByUserID(unfrozenByUserID);


            this._FrozenByUserInfo = clsUsers.FindByUserID(frozenByUserID);
            Mode = enMode.Update;
        }

        public clsFrozenSubscription()
        {
            this._FreezeID = -1;
            this.SubscriptionID = -1;
            this.FreezeStartDate = DateTime.Now;
            this.FreezeEndDate = DateTime.Now.AddDays(7);
            this.UnFreezeDate = DateTime.MinValue;
            this.FreezingDuration = 0;
            this.FreezeFee = 0.0;
            this.FreezeReason = string.Empty;
            this.IsFeesPaid = false;
            this.IsFrozen = true;
            this.FrozenByUserID = -1;
            this.UnfrozenByUserID = -1;
            this._UnFrozenByUserInfo = new clsUsers();
            this._FrozenByUserInfo= new clsUsers();
            this._SubscriptionInfo = new clsSubscription();
            Mode = enMode.AddNew;
        }

        private bool _AddNewFreezeSubscription()
        {
            this._FreezeID = clsFrozenSubscriptionData.AddNewFreezeSubscription(
                this.SubscriptionID,
                this.FreezeEndDate,
                this.FreezeStartDate,
                this.FreezingDuration,
                this.FreezeFee,
                this.FreezeReason,
                this.IsFeesPaid,
                this.IsFrozen,
                this.FrozenByUserID
            );

            return this._FreezeID !=-1;
        }

        private bool _UpdateFrozenSubscription()
        {
            return clsFrozenSubscriptionData.UpdateFrozenSubscription(
                this.FreezeID,
                this.SubscriptionID,
                this.FreezeEndDate,
                this.FreezeStartDate,
                this.UnFreezeDate,
                this.FreezingDuration,
                this.FreezeFee,
                this.FreezeReason,
                this.IsFeesPaid,
                this.IsFrozen,
                this.FrozenByUserID,
                this.UnfrozenByUserID
            );
        }

        public bool Save()
        {
            TimeSpan duration = FreezeEndDate - FreezeStartDate;
                    this.FreezingDuration = (byte)Math.Max(0, duration.Days);

            switch (Mode)
            {
                case enMode.AddNew:

                    
                    if (_AddNewFreezeSubscription())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateFrozenSubscription();
            }
            return false;
        }

        public static clsFrozenSubscription FindByFreezeID(int FreezeID)
        {
            int SubscriptionID = -1;
            DateTime FreezeStartDate = DateTime.Now;
            DateTime FreezeEndDate = DateTime.Now;
            DateTime UnFreezeDate = DateTime.Now;
            byte FreezingDuration = 0;
            double FreezeFee = 0.0;
            string FreezeReason = string.Empty;
            bool IsFeesPaid = false;
            bool IsFrozen = false;
            int FrozenByUserID = -1;
            int UnfrozenByUserID = -1;

            bool IsFound = clsFrozenSubscriptionData.FindFrozenSubscriptionByFreezeID(
                FreezeID, ref SubscriptionID, ref FreezeStartDate, ref FreezeEndDate,
                ref UnFreezeDate, ref FreezingDuration, ref FreezeFee, ref FreezeReason,
                ref IsFeesPaid, ref IsFrozen, ref FrozenByUserID, ref UnfrozenByUserID
            );

            if (IsFound)
                return new clsFrozenSubscription(FreezeID, SubscriptionID, FreezeStartDate, FreezeEndDate,
                    UnFreezeDate, FreezingDuration, FreezeFee, FreezeReason, IsFeesPaid, IsFrozen, FrozenByUserID, UnfrozenByUserID);
            else
                return null;
        }

        public static clsFrozenSubscription FindBySubscriptionID(int SubscriptionID)
        {
            int FreezeID = -1;
            DateTime FreezeStartDate = DateTime.Now;
            DateTime FreezeEndDate = DateTime.Now;
            DateTime UnFreezeDate = DateTime.Now;
            byte FreezingDuration = 0;
            double FreezeFee = 0.0;
            string FreezeReason = string.Empty;
            bool IsFeesPaid = false;
            bool IsFrozen = false;
            int FrozenByUserID = -1;
            int UnfrozenByUserID = -1;

            bool IsFound = clsFrozenSubscriptionData.FindFrozenSubscriptionBySubscriptionID(
                SubscriptionID, ref FreezeID, ref FreezeStartDate, ref FreezeEndDate,
                ref UnFreezeDate, ref FreezingDuration, ref FreezeFee, ref FreezeReason,
                ref IsFeesPaid, ref IsFrozen, ref FrozenByUserID, ref UnfrozenByUserID
            );

            if (IsFound)
                return new clsFrozenSubscription(FreezeID, SubscriptionID, FreezeStartDate, FreezeEndDate,
                    UnFreezeDate, FreezingDuration, FreezeFee, FreezeReason, IsFeesPaid, IsFrozen, FrozenByUserID, UnfrozenByUserID);
            else
                return null;
        }

        public static bool DeleteFrozenSubscription(int FreezeID)
        {
            return clsFrozenSubscriptionData.DeleteFrozenSubscription(FreezeID);
        }

        public static DataTable GetAllFrozenSubscriptions()
        {
            return clsFrozenSubscriptionData.GetAllFrozenSubscriptions();
        }


      


        public bool UnfreezeSubscription()
        {


            TimeSpan duration = DateTime.Now - FreezeStartDate;
            this.FreezingDuration = (byte)duration.Days;
            this.IsFrozen = false;
            this.UnFreezeDate = DateTime.Now;

            return this._UpdateFrozenSubscription();


        }













    }
}
