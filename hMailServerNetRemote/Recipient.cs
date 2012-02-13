using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Recipient : MarshalByRefObject, IRecipient
    {
        internal hMailServer.Recipient _object;

        internal Recipient()
        {            
        }

        internal Recipient(hMailServer.Recipient o)
        {
            _object = o;
        }

        public string Address
        {
            get
            {
                return _object.Address;
            }
        }

        public bool IsLocalUser
        {
            get
            {
                return _object.IsLocalUser;
            }
        }

        public string OriginalAddress
        {
            get
            {
                return _object.OriginalAddress;
            }
        }

    }
}
