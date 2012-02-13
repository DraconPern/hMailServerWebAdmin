using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IRecipients
    {
        int Count
        {
            get;
        }

        IRecipient this[int index]
        {
            get;
        }
    }
}
