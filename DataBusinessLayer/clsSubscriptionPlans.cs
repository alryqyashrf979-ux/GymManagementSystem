using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsSubscriptionPlans
    {

        //PlanID , PlanName , PlanDescription , Availablity, PlanPrice  , Note .
        private int _PlanID = -1;
        public int PlanID { get { return _PlanID; } }

        public string PlanName { set; get; }
        public string PlanDescription { set; get; }
        public bool Availiability { set; get; }

        public decimal PlanPrice { set; get; }

        public string Note { set; get; }

        enum enMode { Add, Update };
        enMode Mode = enMode.Add;

        public clsSubscriptionPlans()
        {
            _PlanID = -1;
            PlanName = string.Empty;
            PlanDescription = string.Empty;
            Availiability = true;
            PlanPrice = default(decimal);
            Note = string.Empty;
            Mode = enMode.Add;

        }
        public clsSubscriptionPlans(int planID, string planName, string planDescription, bool availiablity, decimal planPrice, string note)
        {
            this._PlanID = planID;
            this.PlanName = planName;
            this.PlanDescription = planDescription;
            this.Availiability = availiablity;
            this.PlanPrice = planPrice;
            this.Note = note;
            this.Mode = enMode.Update;

        }




    }
}
