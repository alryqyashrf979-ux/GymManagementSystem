using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsSubscription
    {

        private int _SubscriptionID;
        public int SubscriptionID { get { return _SubscriptionID; } }
        public int MemberID { set; get; }
        public int PlanID { set; get; }
        public enSubscriptionStatus Status { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public double Price { set; get; }
        public int createdByUserID { set; get; }

        private clsMembers _MemberInfo;
        private clsSubscriptionPlans _PlanInfo;

        public clsMembers MemberInfo { get { return _MemberInfo; } }
        public clsSubscriptionPlans PlanInfo { get { return _PlanInfo; } }


        public enum enSubscriptionStatus { Active = 1, Expired = 2, Canceled = 3, Frozen = 4, Changed = 5 }


        public enum enModeSubscription { AddNew = 1, Update = 2 }

        public enModeSubscription Mode = enModeSubscription.AddNew;

        private clsSubscription(int SubscriptionID, int MemberID, int PlanID, enSubscriptionStatus Status, DateTime StartDate, DateTime ExpirationDate, double Price, int createdByUserID)
        {
            this._SubscriptionID = SubscriptionID;
            this.MemberID = MemberID;
            this.PlanID = PlanID;
            this.Status = Status;
            this.StartDate = StartDate;
            this.ExpirationDate = ExpirationDate;
            this.Price = Price;
            this.createdByUserID = createdByUserID;

            this._MemberInfo=clsMembers.FindMemberUsingMemberID(MemberID);
            this._PlanInfo=clsSubscriptionPlans.Find(PlanID);

            Mode = enModeSubscription.Update;
        }

        public clsSubscription()
        {
            this._SubscriptionID = -1;
            this.MemberID = -1;
            this.PlanID = -1;
            this.Status = enSubscriptionStatus.Active;
            this.StartDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddMonths(1);
            this.Price = 0.0;
            this.createdByUserID = -1;

            Mode = enModeSubscription.AddNew;
        }


        private bool _AddSubscription()
        {
            _SubscriptionID = clsSubscriptionsData.AddNewSubscription(this.MemberID, this.PlanID, this.StartDate, this.ExpirationDate, this.Price, (byte)this.Status, this.createdByUserID);
            return _SubscriptionID != -1;
        }

        private bool _UpdateSubscription()
        {
            return clsSubscriptionsData.UpdateSubscription(this.SubscriptionID, this.MemberID, this.PlanID, this.StartDate, this.ExpirationDate, this.Price, (byte)this.Status, this.createdByUserID);
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enModeSubscription.AddNew:

                    if (_AddSubscription())
                    {
                        Mode = enModeSubscription.Update;
                        return true;

                    }
                    else
                        return false;

                case enModeSubscription.Update:
                    return _UpdateSubscription();
            }
            return false;
        }



        public static clsSubscription FindBySubscriptionID(int SubscriptionID)
        {
            int MemberID = -1;
            int PlanID = -1;
            byte Status = 1;
            DateTime StartDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now.AddMonths(1);
            double Price = 0.0;
            int createdByUserID = -1;

            bool IsFound = clsSubscriptionsData.FindSubscriptionBySubscriptionID(SubscriptionID, ref MemberID, ref PlanID, ref StartDate, ref ExpirationDate, ref Price, ref Status, ref createdByUserID);
            if (IsFound)
                return new clsSubscription(SubscriptionID, MemberID, PlanID, (enSubscriptionStatus)Status, StartDate, ExpirationDate, Price, createdByUserID);
            else
                return null;
        }

        public static clsSubscription FindByMemberID(int MemberID)
        {
            int SubscriptionID = -1;
            int PlanID = -1;
            byte Status = 1;
            DateTime StartDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now.AddMonths(1);
            double Price = 0.0;
            int createdByUserID = -1;


            bool IsFound = clsSubscriptionsData.FindSubscriptionByMemberID(MemberID, ref
                SubscriptionID, ref PlanID, ref StartDate, ref ExpirationDate, ref Price, ref Status, ref createdByUserID);

            if (IsFound)
                return new clsSubscription(SubscriptionID, MemberID, PlanID, (enSubscriptionStatus)Status, StartDate, ExpirationDate, Price, createdByUserID);
            else
                return null;
        }



        public static bool DeleteSubscription(int SubscriptionID)
        {
            return clsSubscriptionsData.DeleteSubscription(SubscriptionID);
        }



        public static DataTable GetAllSubscriptions()
        {
            return clsSubscriptionsData.GetAllSubscriptions();
        }


        public static bool TerminateSubscription(int SubscriptionID)
        {
            return clsSubscriptionsData.UpdateSubscriptionStatus(SubscriptionID, (byte)enSubscriptionStatus.Expired);

        }


        }
}
