using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Recipients : MarshalByRefObject, IRecipients
    {
        internal hMailServer.Recipients _object;

        internal Recipients()
        {
        }

        internal Recipients(hMailServer.Recipients o)
        {
            _object = o;
        }
        
        public int Count
        {
            get
            {
                return _object.Count;
            }
        }

        public IRecipient this[int index]
        {
            get
            {
                return new Recipient(_object[index]);
            }
        }
    }
}
