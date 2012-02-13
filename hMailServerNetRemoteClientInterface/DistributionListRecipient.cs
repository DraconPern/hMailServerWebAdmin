using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDistributionListRecipient
    {
        void Delete();

        void Save();

        int ID
        {
            get;
        }

        string RecipientAddress
        {
            get;
            set;
        }

    }
}
