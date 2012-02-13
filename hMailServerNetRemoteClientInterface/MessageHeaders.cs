using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IMessageHeaders
    {
        int Count
        {
            get;
        }

        IMessageHeader this[int index]
        {
            get;
        }

        IMessageHeader this[string Name]
        {
            get;
        }

        IMessageHeader ItemByName(string Name);

    }
}
