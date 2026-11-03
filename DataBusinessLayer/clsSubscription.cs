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
        public int MemberID { private set; get; }
        public int PlanID { private set; get; }
        public enSubscriptionStatus Status { private set; get;}
        public string StatusString { get => _GetStatus(); }
        public DateTime StartDate { private set; get; }
        public DateTime ExpirationDate {  private set; get; }
        public DateTime RegistrationDate { private set; get; }
        public double Price {private set; get; }
        public int createdByUserID { private set; get; }

        private clsMembers _MemberInfo;
        private clsSubscriptionPlans _PlanInfo;

        public clsMembers MemberInfo { get { return _MemberInfo; } }
        public clsSubscriptionPlans PlanInfo { get { return _PlanInfo; } }


        public enum enSubscriptionStatus { Active = 1, Expired = 2, Canceled = 3, Frozen = 4, Changed = 5,Scheduled=6 }


        public enum enModeSubscription { AddNew = 1, Update = 2 }

        public enModeSubscription Mode = enModeSubscription.AddNew;

        private clsSubscription(int SubscriptionID, int MemberID, int PlanID, enSubscriptionStatus Status, DateTime StartDate, DateTime ExpirationDate,DateTime RegistrationDate, double Price, int createdByUserID)
        {
            this._SubscriptionID = SubscriptionID;
            this.MemberID = MemberID;
            this.PlanID = PlanID;
            this.Status = Status;
            this.StartDate = StartDate;
            this.ExpirationDate = ExpirationDate;
            this.Price = Price;
            this.createdByUserID = createdByUserID;
            this.RegistrationDate = RegistrationDate;
            // if you call this compistion it will get exception stackOverFlow that mean will git in infinite loop because you have compistion for memberinfo in clsSubscription and you have compistion for subscription in clsMember
          //  this._MemberInfo=clsMembers.FindMemberUsingMemberID(MemberID);
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
            this.Status = (StartDate.Date == DateTime.Today.Date) ? enSubscriptionStatus.Active : enSubscriptionStatus.Scheduled;

            _SubscriptionID = clsSubscriptionsData.AddNewSubscription(this.MemberID, this.PlanID, this.StartDate, this.ExpirationDate, DateTime.Today,this.Price, (byte)this.Status, this.createdByUserID);
            return _SubscriptionID != -1;
        }

        private bool _UpdateSubscription()
        {

            return clsSubscriptionsData.UpdateSubscription(this.SubscriptionID, this.MemberID, this.PlanID, this.StartDate, this.ExpirationDate, this.Price, (byte)this.Status, this.createdByUserID);
        }



        private bool Save()
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



        public bool AddSubscription(DateTime StartDate,int MemberID,int PlanID,int createdByUserID)
        {

            clsSubscriptionPlans _Plan = clsSubscriptionPlans.Find(PlanID);

            if (_Plan == null)
                return false;


            this.PlanID = PlanID;
            this.Status = (StartDate.Date == DateTime.Today) ? enSubscriptionStatus.Active : enSubscriptionStatus.Scheduled;
            this.StartDate = StartDate;
            this.MemberID = MemberID;
            this.Price = _Plan.PlanPrice;
            this.createdByUserID = createdByUserID;
            this.ExpirationDate = this.StartDate.AddDays(_Plan.Duration);

            return this.Save();

        }
      
        public bool UpdateSubscription(DateTime StartDate,int CreatedByUserID)
        {

            this.Status = (StartDate.Date == DateTime.Today) ? enSubscriptionStatus.Active : enSubscriptionStatus.Scheduled;
            this.StartDate = StartDate;
            this.createdByUserID = createdByUserID;

            return this.Save();
        }

        public int Freeze(DateTime StartDate,DateTime EndDate ,double FreezeFee,int FrozenByUserID,string FreezeReason)
        {

            clsFrozenSubscription Freeze = new clsFrozenSubscription();

            Freeze.FreezeStartDate = StartDate;
            Freeze.FreezeEndDate = EndDate;
            Freeze.FreezeFee = FreezeFee;
            Freeze.FrozenByUserID = FrozenByUserID;
            Freeze.FreezeReason = FreezeReason;
            Freeze.SubscriptionID = _SubscriptionID;
            Freeze.IsFrozen = (StartDate.Date == DateTime.Today.Date);
            Freeze.FreezingDuration = (byte)(EndDate.Date - StartDate.Date).Days;
           
            Freeze.IsFeesPaid=(FreezeFee > 0);


            if (Freeze.Save())
            {
                if (!UpdateSubscriptionStatus(enSubscriptionStatus.Frozen))
                    return -1;
            }


            return Freeze.FreezeID;
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
            DateTime RegistrationDate = DateTime.Now;

            bool IsFound = clsSubscriptionsData.FindSubscriptionBySubscriptionID(SubscriptionID, ref MemberID, ref PlanID, ref StartDate, ref ExpirationDate,ref RegistrationDate, ref Price, ref Status, ref createdByUserID);
            if (IsFound)
                return new clsSubscription(SubscriptionID, MemberID, PlanID, (enSubscriptionStatus)Status, StartDate, ExpirationDate, RegistrationDate, Price, createdByUserID);
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
            DateTime RegistrationDate = DateTime.Now;
            int createdByUserID = -1;


            bool IsFound = clsSubscriptionsData.FindSubscriptionByMemberID(MemberID, ref
                SubscriptionID, ref PlanID, ref StartDate, ref ExpirationDate, ref RegistrationDate, ref Price, ref Status, ref createdByUserID);

            if (IsFound)
                return new clsSubscription(SubscriptionID, MemberID, PlanID, (enSubscriptionStatus)Status, StartDate, ExpirationDate, RegistrationDate, Price, createdByUserID);
            else
                return null;
        }

        private string _GetStatus()
        {


            switch (Status)
            {

                case clsSubscription.enSubscriptionStatus.Active:
                    return "Active";

                case clsSubscription.enSubscriptionStatus.Scheduled:
                    return "Scheduled";

                case clsSubscription.enSubscriptionStatus.Frozen:
                    return "Frozen";

                case clsSubscription.enSubscriptionStatus.Canceled:
                    return "Canceled";

                case clsSubscription.enSubscriptionStatus.Changed:
                    return "Changed";

                case clsSubscription.enSubscriptionStatus.Expired:
                    return "Expired";

                default:
                    return "UnKnown";
            }


        }

        public static bool DeleteSubscription(int SubscriptionID)
        {
            return clsSubscriptionsData.DeleteSubscription(SubscriptionID);
        }

        public bool UpdateSubscriptionStatus(enSubscriptionStatus Status)
        {
            return clsSubscriptionsData.UpdateSubscriptionStatus(this.SubscriptionID, (byte)Status);
        }

        public static DataTable GetAllSubscriptions()
        {
            return clsSubscriptionsData.GetAllSubscriptions();
        }

        public static bool HasExistingSubscription(int MemberID)
        {
            return clsSubscriptionsData.HasExistingSubscription(MemberID);
        }
        public static bool TerminateSubscription(int SubscriptionID)
        {
            return clsSubscriptionsData.UpdateSubscriptionStatus(SubscriptionID, (byte)enSubscriptionStatus.Expired);

        }


        }
}
