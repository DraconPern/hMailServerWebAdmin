using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class DistributionListRecipient : MarshalByRefObject, IDistributionListRecipient
    {
        internal hMailServer.DistributionListRecipient _object;

        public DistributionListRecipient()
        {

        }

        internal DistributionListRecipient(hMailServer.DistributionListRecipient o)
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

        public int ID
        {
            get
            {
                return _object.ID;
            }
        }

        public string RecipientAddress
        {
            get
            {
                return _object.RecipientAddress;
            }
            set
            {
                _object.RecipientAddress = value;
            }
        }

    }
}
