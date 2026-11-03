using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusinessLayer
{
    internal class clsRefund
    {
        public int RefundID { get; private set; }
        public int CreatedByUserID { set; get; }
        public byte RefundMethod { get; set; }
        public DateTime RefundDate { get; set; }
        public int SubscriptionID { get; set; }
        public StringBuilder Reason { set; get; }
        public double RefundAmount { set; get; }
        public enum enMethod { Cash=1,Card=2}
        private enMethod _Method = enMethod.Card;
        public enum enMode { AddMode,UpdateMode}
        private enMode _Mode = enMode.AddMode;
       public clsRefund()
        {
            RefundID = -1;
            CreatedByUserID = -1;
            _Method = enMethod.Card;
            RefundMethod = (Byte)_Method;
            RefundDate = DateTime.Now;
            SubscriptionID = -1;
            Reason.Clear();
            RefundAmount = 0;
            _Mode = enMode.AddMode;
        }

        public clsRefund(int RefundID,int SubscriptionID,int CreatedByUserID,double RefundAmount,DateTime RefundDate,byte RefundMethod,StringBuilder Reason)
        {
            this.RefundID = RefundID;
            this.CreatedByUserID = CreatedByUserID;
            _Method =(enMethod) RefundMethod;
            this.RefundMethod = (Byte)_Method;
            this.RefundDate = DateTime.Now;
            this.SubscriptionID = -1;
            this.Reason.Append(Reason);
            this.RefundAmount = RefundAmount;
            _Mode = enMode.UpdateMode;
        }

        static public DataTable GetAllRefund()
        {
            return clsRefundData.GetAllRefunds();
        }

        static public bool Delete(int RefundID)
        {
            return clsRefundData.DeleteRefund(RefundID);
        }
        private bool _AddNewRefund()
        {
            this.RefundID = clsRefundData.AddRefund(this.SubscriptionID, this.RefundAmount, this.RefundMethod, this.CreatedByUserID, this.Reason);
            return (this.RefundID != -1);
        }
        private bool _UpdateRefund()
        {
            return clsRefundData.UpdateRefund(this.SubscriptionID, this.RefundAmount, this.RefundMethod, this.CreatedByUserID, this.Reason);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddNewRefund())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.UpdateMode:
                    return _UpdateRefund();
            }
            return false;
        }

        static public clsRefund Find(int RefundID)
        {
            int SubscriptionID = -1, CreatedByUserID = -1;
            double RefundAmount = 0;
            DateTime RefundDate = DateTime.Now;
            byte RefundMethod = 0;
            StringBuilder Reason = null;

            bool IsFound = clsRefundData.Find(RefundID,ref SubscriptionID,ref RefundAmount,ref RefundMethod,ref RefundDate,ref CreatedByUserID);
            if (IsFound)
                return new clsRefund(RefundID, SubscriptionID, CreatedByUserID, RefundAmount, RefundDate, RefundMethod, Reason);
            else
                return null;
        }

        static public clsRefund FindBySubscriptionID(int SubscriptionID)
        {
            int RefundID = -1, CreatedByUserID = -1;
            double RefundAmount = 0;
            DateTime RefundDate = DateTime.Now;
            byte RefundMethod = 0;
            StringBuilder Reason = null;

            bool IsFound = clsRefundData.FindBySubscriptionID(SubscriptionID, ref RefundID, ref RefundAmount, ref RefundMethod, ref RefundDate, ref CreatedByUserID);
            if (IsFound)
                return new clsRefund(RefundID, SubscriptionID, CreatedByUserID, RefundAmount, RefundDate, RefundMethod, Reason);
            else
                return null;
        }
    }
}
