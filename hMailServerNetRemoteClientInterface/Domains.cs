using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDomains
    {


        IDomain Add();

        void DeleteByDBID(int DBID);

        void Refresh();

        int Count
        {
            get;
        }

        IDomain this[int index]
        {
            get;
        }

        IDomain this[string ItemName]
        {
            get;
        }

        IDomain ItemByName(string ItemName);

        IDomain ItemByDBID(int DBID);

        string Names
        {
            get;
        }

        //

        List<IDomain> ToList();
    }
}
