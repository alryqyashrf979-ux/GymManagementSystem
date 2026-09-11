using DataAccessLayer;
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

        public static clsSubscriptionPlans Find(int PlanID)
        {
            string PlanName = string.Empty;
            string PlanDescription = string.Empty;
            string Note = string.Empty;
            decimal PlanPrice = default(decimal);
            bool Availiablity = true;

            if (clsSubscriptionPlansDataAccess.FindPlan(PlanID, ref PlanName, ref PlanDescription, ref Availiablity, ref PlanPrice, ref Note))
                return new clsSubscriptionPlans(PlanID, PlanName, PlanDescription, Availiablity, PlanPrice, Note);
            else return null;
        }

        private bool _Add()
        {
            this._PlanID = clsSubscriptionPlansDataAccess.Add(this.PlanName, this.PlanDescription, this.Availiability, this.PlanPrice, this.Note);
            return this._PlanID > -1;
        }

        private bool _Update()
        {
            return clsSubscriptionPlansDataAccess.Update(this.PlanName, this.PlanDescription, this.Availiability, this.PlanPrice, this.Note);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        if (_Update())
                            return true;
                        else return false;
                    }

            }
            return false;
        }

        public static bool Delete(int planID)
        {
            return clsSubscriptionPlansDataAccess.Delete(planID);
        }

    }
}
