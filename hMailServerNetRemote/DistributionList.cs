using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class DistributionList : MarshalByRefObject
    {
        internal hMailServer.DistributionList _object;

        public DistributionList()
        {

        }

        internal DistributionList(hMailServer.DistributionList o)
        {
            _object = o;
        }

        public void Delete()
        {
            _object.Delete();
        }

        public void Save()
        {
            _object.Save();
        }

        public bool Active
        {
            get
            {
                return _object.Active;
            }
        }


        public string Address
        {
            get
            {
                return _object.Address;
            }
        }

        public int ID
        {
            get
            {
                return _object.ID;
            }
        }

        public hMailServer.eDistributionListMode Mode
        {
            get
            {
                return _object.Mode;
            }
            set
            {
                _object.Mode = value;
            }
        }
       
        public DistributionListRecipients Recipients
        {
            get
            {
                return new DistributionListRecipients(_object.Recipients);
            }
        }

        public string RequireSenderAddress
        {
            get
            {
                return _object.RequireSenderAddress;
            }
            set
            {
                _object.RequireSenderAddress = value;
            }
        }

        public bool RequireSMTPAuth
        {
            get
            {
                return _object.RequireSMTPAuth;
            }
            set
            {
                _object.RequireSMTPAuth = value;
            }
        }


    }
}
