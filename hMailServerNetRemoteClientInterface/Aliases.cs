using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IAliases
    {
        IAlias Add();
        void Delete(int index);
        void DeleteByDBID(int DBID);

        void Refresh();

        int Count
        {
            get;
        }

        IAlias this[int index]
        {
            get;
        }

        IAlias this[string Name]
        {
            get;
        }

        IAlias ItemByName(string Name);

        IAlias ItemByDBID(int DBID);
    }
}
