using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class DistributionLists : MarshalByRefObject, IDistributionLists
    {
        internal hMailServer.DistributionLists _object;

        public DistributionLists()
        {
        }

        internal DistributionLists(hMailServer.DistributionLists o)
        {
            _object = o;
        }

        public IDistributionList Add()
        {
            return new DistributionList(_object.Add());
        }

        public void DeleteByDBID(int DBID)
        {
            _object.DeleteByDBID(DBID);
        }

        public void Refresh()
        {
            _object.Refresh();
        }

        public int Count
        {
            get
            {
                return _object.Count;
            }
        }

        public IDistributionList this[int index]
        {
            get
            {
                return new DistributionList(_object[index]);                
            }
        }

        public IDistributionList this[string ItemName]
        {
            get
            {
                return ItemByAddress(ItemName);
            }
        }

        public IDistributionList ItemByAddress(string ItemName)
        {
            return new DistributionList(_object.ItemByAddress[ItemName]);            
        }

        public IDistributionList ItemByDBID(int DBID)
        {
            return new DistributionList(_object.ItemByDBID[DBID]);            
        }        

    }
}
