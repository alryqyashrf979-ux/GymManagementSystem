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


    }
}
