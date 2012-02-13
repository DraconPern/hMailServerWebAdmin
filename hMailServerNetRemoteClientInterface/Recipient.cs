using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IRecipient
    {
        string Address
        {
            get;
        }

        bool IsLocalUser
        {
            get;
        }

        string OriginalAddress
        {
            get;
        }

    }
}
