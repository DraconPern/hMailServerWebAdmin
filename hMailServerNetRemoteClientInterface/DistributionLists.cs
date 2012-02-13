using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDistributionLists
    {

        IDistributionList Add();

        void DeleteByDBID(int DBID);

        void Refresh();

        int Count
        {
            get;
        }

        IDistributionList this[int index]
        {
            get;
        }

        IDistributionList this[string ItemName]
        {
            get;
        }

        IDistributionList ItemByAddress(string ItemName);

        IDistributionList ItemByDBID(int DBID);
    }
}
