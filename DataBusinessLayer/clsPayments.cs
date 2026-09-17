using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace DataBusinessLayer
{
   public class clsPayments
    {
        private int _PaymentID;
        public int PaymentID { get { return _PaymentID; } }
        public int SubscriptionID { set; get; }
        public double PaymentAmount { set; get; }
        public double ActualAmount { set; get; }
        public double TotalRemaining { set; get; }
        public int PaymentMethod { set; get; }
        public DateTime PaymentDate { set; get; }
        public int CreatedByUserID { set; get; }
        public enum enMode { AddMode=1,UpdateMode=2 }
        private enMode _Mode = enMode.AddMode;

        public clsPayments()
        {
            _PaymentID = -1;
            this.SubscriptionID = -1;
            this.PaymentAmount = 0;
            this.ActualAmount = 0;
            this.TotalRemaining = 0;
            this.PaymentMethod = -1;
            this.PaymentDate = DateTime.Now;
            this.CreatedByUserID = -1;
            _Mode = enMode.AddMode;
        }

        private clsPayments(int PaymentID,int SubscriptionID,double PaymentAmount,double ActualAmount,double TotalRemaining,
            int PaymentMethod,DateTime PaymentDate,int CreatedByUserID)
        {
            _PaymentID = PaymentID;
            this.SubscriptionID = SubscriptionID;
            this.PaymentAmount = PaymentAmount;
            this.ActualAmount =ActualAmount;
            this.TotalRemaining = TotalRemaining;
            this.PaymentMethod = PaymentMethod;
            this.PaymentDate = PaymentDate;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.UpdateMode;
        }

        static public bool DeletePayment(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }

        private bool _AddPayment()
        {
            this._PaymentID = clsPaymentData.AddPayment(this.SubscriptionID, this.PaymentAmount, this.ActualAmount, this.PaymentMethod, this.CreatedByUserID);

            return this._PaymentID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePayment(this._PaymentID,this.SubscriptionID,this.PaymentAmount,this.ActualAmount,this.PaymentMethod,this.CreatedByUserID);
        }

    }
}
