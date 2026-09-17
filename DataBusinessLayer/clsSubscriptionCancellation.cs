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


    }
}
