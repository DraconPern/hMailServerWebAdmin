using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDistributionListRecipients
    {

        IDistributionListRecipient Add();

        void Add(string address);

        void Delete(string address);

        void DeleteByDBID(int DBID);

        int Count
        {
            get;
        }

        IDistributionListRecipient this[int index]
        {
            get;
        }

        IDistributionListRecipient ItemByDBID(int DBID);

    }
}
