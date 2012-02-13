using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDomainAliases
    {
        IDomainAlias Add();

        void Delete(int index);

        void DeleteByDBID(int DBID);

        void Refresh();

        int Count
        {
            get;
        }

        IDomainAlias this[int index]
        {
            get;
        }

        IDomainAlias ItemByDBID(int DBID);
    }
}
