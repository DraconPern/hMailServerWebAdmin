using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IIMAPFolders
    {

        IIMAPFolder Add(string sName);

        void DeleteByDBID(int DBID);

        int Count
        {
            get;
        }

        IIMAPFolder this[int index]
        {
            get;
        }

        IIMAPFolder this[string sName]
        {
            get;
        }

        IIMAPFolder ItemByName(string sName);

        IIMAPFolder ItemByDBID(int DBID);
    }
}
