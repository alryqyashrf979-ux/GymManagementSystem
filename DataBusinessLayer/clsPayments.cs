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
        public string StatusString { get => GetStatusString(); }
        public double PaymentAmount { set; get; }
        public double ActualAmount { set; get; }
        public double TotalRemaining { set; get; }
        public int PaymentMethod { set; get; }
        public DateTime PaymentDate { set; get; }
        public int CreatedByUserID { set; get; }
        public enStatus Status { set; get; }
        public clsUsers UserInfo { get; private set; }
        public clsSubscription SubscriptionInfo { get; private set; }
        public clsMembers MemberInfo { get; private set; }
        public enum enMode { AddMode=1,UpdateMode=2 }
        private enMode _Mode = enMode.AddMode;
        public enum enStatus { Pending=1,Completed=2,Refunded=3,PartiallyRefunded=4 }
        private enStatus _eStatus = enStatus.Pending;
        public enum enPaymentMethod { Cash=1,Card=2};
        private enPaymentMethod _Method = enPaymentMethod.Cash;

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
            this.UserInfo = new clsUsers(); 
            this.SubscriptionInfo = new clsSubscription();
            this.MemberInfo = new clsMembers();
            _Mode = enMode.AddMode;
        }

        private clsPayments(int PaymentID,int SubscriptionID,double PaymentAmount,double ActualAmount,double TotalRemaining,
            int PaymentMethod,DateTime PaymentDate,int CreatedByUserID,byte Status)
        {
            _PaymentID = PaymentID;
            this.SubscriptionID = SubscriptionID;
            this.PaymentAmount = PaymentAmount;
            this.ActualAmount =ActualAmount;
            this.TotalRemaining = TotalRemaining;
            this.PaymentMethod = PaymentMethod;
            this.PaymentDate = PaymentDate;
            this.CreatedByUserID = CreatedByUserID;
            this.Status = Status;

            this.SubscriptionInfo = clsSubscription.FindBySubscriptionID(SubscriptionID);
            this.UserInfo = clsUsers.FindByUserID(CreatedByUserID);
            this.MemberInfo = clsMembers.FindMemberUsingMemberID(SubscriptionInfo.MemberID);
            _Mode = enMode.UpdateMode;
        }

        static public bool DeletePayment(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }

        private bool _AddPayment()
        {
            this._PaymentID = clsPaymentData.AddPayment(this.SubscriptionID, this.PaymentAmount, this.ActualAmount,this.TotalRemaining, this.PaymentMethod, this.CreatedByUserID,this.Status);

            return this._PaymentID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePayment(this._PaymentID,this.SubscriptionID,this.PaymentAmount,this.ActualAmount,this.PaymentMethod,this.CreatedByUserID);
        }

        public bool Save()
        {
            

            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddPayment())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:
                    return _UpdatePayment();
            }
            return false;
        }
        static public DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }
        static public clsPayments FindByPaymentID(int PaymentID)
        {
            
           int SubscriptionID = -1, PaymentMethod = -1, CreatedByUserID = -1;

          double  PaymentAmount = 0, ActualAmount = 0, TotalRemaining = 0;
            byte Status = 0;

          DateTime  PaymentDate = DateTime.Now;

            bool IsFound = clsPaymentData.Find(PaymentID, ref SubscriptionID, ref PaymentAmount, ref ActualAmount, ref TotalRemaining, ref PaymentMethod, ref PaymentDate, ref CreatedByUserID,ref Status);

            if (IsFound)
                return new clsPayments(PaymentID, SubscriptionID, PaymentAmount, ActualAmount, TotalRemaining, PaymentMethod, PaymentDate, CreatedByUserID,Status);
            else
                return null;
        }
        //added by aim
        static public clsPayments FindBySubscriptionID(int SubscriptionID)
        {
            
           int PaymentID = -1, PaymentMethod = -1, CreatedByUserID = -1;

          double  PaymentAmount = 0, ActualAmount = 0, TotalRemaining = 0;
            byte Status = 0;

          DateTime  PaymentDate = DateTime.Now;

            bool IsFound = clsPaymentData.Find(ref PaymentID,  SubscriptionID, ref PaymentAmount, ref ActualAmount, ref TotalRemaining, ref PaymentMethod, ref PaymentDate, ref CreatedByUserID,ref Status);

            if (IsFound)
                return new clsPayments(PaymentID, SubscriptionID, PaymentAmount, ActualAmount, TotalRemaining, PaymentMethod, PaymentDate, CreatedByUserID,Status);
            else
                return null;
        }

      //Edit by aim
        private string GetStatusString()
        {
            switch ((enStatus)Status)
            {
                case enStatus.Pending:
                    return "Pending";

                case enStatus.Completed:
                    return "Completed";

                case enStatus.Refunded:
                    return "Refunded";

                case enStatus.PartiallyRefunded:
                    return "Partially Refunded";

                default:
                   return "Unknown";
            }
        }

        public string SelectPaymentMethod()
        {
            switch ((enPaymentMethod)PaymentMethod)
            {
                case enPaymentMethod.Cash:
                    return "Cash";
                case enPaymentMethod.Card:
                    return "Card";

                default:
                    return "Unknown";
            }
        }
    }
}
