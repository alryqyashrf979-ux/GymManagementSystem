using System;
using System.Collections.Generic;
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


        public enum enSubscriptionStatus { Active = 1, Expired = 2, Canceled = 3,Freezed = 4 ,Changed = 5 }
        

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

            Mode= enModeSubscription.Update;
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



    }
}
