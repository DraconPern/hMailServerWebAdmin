using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IMessages
    {
        IMessage Add();

        void Clear();

        void DeleteByDBID(int DBID);
        int Count
        {
            get;
        }

        IMessage this[int index]
        {
            get;
        }

        IMessage ItemByDBID(int DBID);
    }
}
