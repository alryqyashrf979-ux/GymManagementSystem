using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace DataBusinessLayer
{
   public class clsSubscriptionChanges
    {

        private int _SubscriptionChangeID;
        public int SubscriptionChangeID { get { return _SubscriptionChangeID; } }
        public int NewSubscriptionID { get; set; }
        public int CancelledSubscriptionID { get; set; }
        public int ChangedByUserID { get; set; }
        public DateTime ChangeDateTime { get; set; }

        public enum enMode { AddMode=1,UpdateMode=2};
        private enMode _Mode = enMode.AddMode;

        public clsSubscriptionChanges()
        {
            _SubscriptionChangeID = -1;
            NewSubscriptionID = -1;
            CancelledSubscriptionID = -1;
            ChangedByUserID = -1;
            ChangeDateTime = DateTime.Now;

            _Mode = enMode.AddMode;
        }

        public clsSubscriptionChanges(int SubscriptionChangeID,int NewSubscriptionID,int CancelledSubscriptionID,int ChangedByUserID,DateTime ChangeDateTime)
        {
            _SubscriptionChangeID = SubscriptionChangeID;
            this.NewSubscriptionID = NewSubscriptionID;
            this.CancelledSubscriptionID = CancelledSubscriptionID;
            this.ChangedByUserID = ChangedByUserID;
            this.ChangeDateTime = ChangeDateTime;

            _Mode = enMode.UpdateMode;
        }

        private bool _AddSubscriptionChanges()
        {
            _SubscriptionChangeID = clsSubscriptionChangesData.AddSubscriptionChange(this.NewSubscriptionID, this.CancelledSubscriptionID, this.ChangedByUserID, this.ChangeDateTime);

            return _SubscriptionChangeID != -1;
        }

        private bool _UpdateSubscriptionChanges()
        {
            return clsSubscriptionChangesData.UpdateSubscriptionChange(_SubscriptionChangeID,NewSubscriptionID,CancelledSubscriptionID,this.ChangedByUserID,this.ChangeDateTime);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddSubscriptionChanges())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateSubscriptionChanges();
            }
            return false;
        }
    }
}
