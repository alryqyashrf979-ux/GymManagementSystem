using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace DataBusinessLayer
{
    public class clsSubscriptionCancellation
    {
        private int _CancellationID;
        public int CancellationID { get { return _CancellationID; } }
        public int SubscriptionID { get; set; }
        public int CancelledByUserID { get; set; }
        public short ElapsedDays { get; set; }
        public DateTime CancellationDate { get; private set; }
        public string CancellationReason { get; set; }
        public double Refund { get; set; }

        public clsUsers CancelledByUserInfo;
        public clsSubscription SubscriptionInfo;
        public enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _Mode = enMode.AddMode;

        public clsSubscriptionCancellation()
        {
            this._CancellationID = -1;
            this.SubscriptionID = -1;
            this.CancelledByUserID = -1;
            this.ElapsedDays = 0;
            this.CancellationDate = DateTime.Now;
            this.CancellationReason = string.Empty;
            this.Refund = 0;
            this.CancelledByUserInfo = new clsUsers();
            this.SubscriptionInfo = new clsSubscription();
            _Mode = enMode.AddMode;
        }


        private clsSubscriptionCancellation(int CancellationID, int SubscriptionID, int UserID, short ElapsedDays, DateTime CancellationDate,
            string CancellationReason, double Refund)
        {
            this._CancellationID = CancellationID;
            this.SubscriptionID = SubscriptionID;
            this.CancelledByUserID = UserID;
            this.ElapsedDays = ElapsedDays;
            this.CancellationDate = CancellationDate;
            this.CancellationReason = CancellationReason;
            this.Refund = Refund;

            this.CancelledByUserInfo = clsUsers.FindByUserID(UserID);
            this.SubscriptionInfo = clsSubscription.FindBySubscriptionID(SubscriptionID);
            _Mode = enMode.UpdateMode;

        }

        static public bool DeleteSubscriptionCancellation(int SubscriptionCancellationID)
        {


            return clsSubscriptionCancellationData.DeleteSubscriptionCancellation(SubscriptionCancellationID);
        }

        private bool _AddSubscriptionCancellationID()
        {
            this._CancellationID = clsSubscriptionCancellationData.AddSubscriptionCancellation(this.SubscriptionID, this.CancellationReason, this.Refund, this.ElapsedDays, DateTime.Today, this.CancelledByUserID);

            return this._CancellationID != -1;
        }

        private bool _UpdateSubscriptionCancellation()
        {
            return clsSubscriptionCancellationData.UpdateSubscriptionCancellation(this._CancellationID, this.SubscriptionID, this.CancellationReason, this.Refund, this.ElapsedDays, this.CancelledByUserID);
        }

        public static void HandleRefund(int SubscriptionID, ref double Refund, ref short LapsedDays, ref double OneDayFee, ref double UsedAmount)
        {
            clsSubscription Subscription = clsSubscription.FindBySubscriptionID(SubscriptionID);
           
            int Duration = (Subscription.ExpirationDate - Subscription.StartDate).Days;

            OneDayFee = Subscription.Price / Duration;
            LapsedDays = (short)(DateTime.Now - Subscription.StartDate).Days;

            UsedAmount = OneDayFee * LapsedDays;

            Refund = Subscription.Price - UsedAmount;

        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddSubscriptionCancellationID())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.UpdateMode:
                    return _UpdateSubscriptionCancellation();
            }
            return false;
        }

        static public clsSubscriptionCancellation Find(int CancellationID)
        {
            int SubscriptionID = -1, CancelledByUserID = -1;
            short ElapsedDays = 0;
            DateTime CancellationDate = DateTime.Now;
            string CancellationReason = string.Empty;
            double Refund = 0;

            bool IsFound = clsSubscriptionCancellationData.Find(CancellationID, ref SubscriptionID, ref CancellationReason, ref Refund, ref ElapsedDays,
               ref CancellationDate, ref CancelledByUserID);

            if (IsFound)
                return new clsSubscriptionCancellation(CancellationID, SubscriptionID, CancelledByUserID, ElapsedDays, CancellationDate, CancellationReason, Refund);
            else
                return null;
        }

        static public (double,short,double) RefundFees(clsMembers MemberInfo)
        {
            double TotalRemaining = clsPayments.FindBySubscriptionID(MemberInfo.LastSubscriptionID).TotalRemaining;
            short ElapsedDays = (short)(DateTime.Today.Date - MemberInfo.LastSubscriptionInfo.StartDate.Date).Days;


            double DailyFee = MemberInfo.LastSubscriptionInfo.Price / MemberInfo.LastSubscriptionInfo.PlanInfo.Duration;

            double Rest = MemberInfo.LastSubscriptionInfo.Price - (DailyFee * ElapsedDays);
            double RefundFee=Rest-TotalRemaining;
            return (Math.Floor(RefundFee),(ElapsedDays),(Math.Floor(DailyFee * ElapsedDays)));

                     //First item of tuple is a Refund and second item is how much price of elapsedDays
        }

    }
}