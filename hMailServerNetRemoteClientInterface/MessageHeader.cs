using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IMessageHeader
    {

        void Delete();

        string Name
        {
            get;
            set;
        }

        string Value
        {
            get;
            set;
        }

    }
}
