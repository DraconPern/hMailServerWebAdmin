using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IAccounts
    {


        IAccount Add();

        void Delete(int index);

        void DeleteByDBID(int DBID);

        void Refresh();
        int Count
        {
            get;
        }

        IAccount this[int index]
        {
            get;
        }

        IAccount this[string Address]
        {
            get;
        }

        IAccount ItemByAddress(string Address);

        IAccount ItemByDBID(int DBID);
    }
}
