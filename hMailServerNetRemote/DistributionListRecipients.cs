using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class DistributionListRecipients : MarshalByRefObject
    {
        internal hMailServer.DistributionListRecipients _object;

        public DistributionListRecipients()
        {
        }

        internal DistributionListRecipients(hMailServer.DistributionListRecipients o)
        {
            _object = o;
        }

        public DistributionListRecipient Add()
        {
            return new DistributionListRecipient(_object.Add());
        }

        public void Add(string address)
        {
            int c = Count;
            for (int i = 0; i < c; i++)
            {
                if (_object[i].RecipientAddress == address)
                    return;
            }

            hMailServer.DistributionListRecipient r = _object.Add();
            r.RecipientAddress = address;
            r.Save();
        }

        public void Delete(string address)
        {
            int c = Count;
            for (int i = 0; i < c; i++)
            {
                if (_object[i].RecipientAddress == address)
                {
                    _object[i].Delete();
                    return;
                }
            }
        }

        public void DeleteByDBID(int DBID)
        {
            _object.DeleteByDBID(DBID);
        }

        public int Count
        {
            get
            {
                return _object.Count;
            }
        }

        public DistributionListRecipient this[int index]
        {
            get
            {
                return new DistributionListRecipient(_object[index]);
            }
        }

        public DistributionListRecipient ItemByDBID(int DBID)
        {
            return new DistributionListRecipient(_object.ItemByDBID[DBID]);
        }

    }
}
