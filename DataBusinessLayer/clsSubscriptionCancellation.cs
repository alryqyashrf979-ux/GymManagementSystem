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
        public byte ElapsedDays { get; set; }
        public DateTime CancellationDate { get; set; }
        public string CancellationReason { get; set; }
        public double Refund { get; set; }

        public enum enMode { AddMode=1,UpdateMode=2}
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
            _Mode = enMode.AddMode;
        }


        private clsSubscriptionCancellation(int CancellationID, int SubscriptionID, int UserID, byte ElapsedDays, DateTime CancellationDate,
            string CancellationReason, double Refund)
        {
            this._CancellationID = CancellationID;
            this.SubscriptionID = SubscriptionID;
            this.CancelledByUserID = UserID;
            this.ElapsedDays = ElapsedDays;
            this.CancellationDate = CancellationDate;
            this.CancellationReason = CancellationReason;
            this.Refund = Refund;
            _Mode = enMode.UpdateMode;

        }

        static public bool DeleteSubscriptionCancellation(int SubscriptionCancellationID)
        {
            return clsSubscriptionCancellationData.DeleteSubscriptionCancellation(SubscriptionCancellationID);
        }

        private bool _AddSubscriptionCancellationID()
        {
            this._CancellationID = clsSubscriptionCancellationData.AddSubscriptionCancellation(this.SubscriptionID, this.CancellationReason, this.Refund, this.ElapsedDays, this.CancellationDate, this.CancelledByUserID);

            return this._CancellationID != -1;
        }

        private bool _UpdateSubscriptionCancellation()
        {
            return clsSubscriptionCancellationData.UpdateSubscriptionCancellation(this._CancellationID, this.SubscriptionID, this.CancellationReason, this.Refund, this.ElapsedDays, this.CancellationDate, this.CancelledByUserID);
        }

    }
}
