using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class DomainAliases : MarshalByRefObject, IDomainAliases
    {
        internal hMailServer.DomainAliases _object;

        public DomainAliases()
        {
        }

        internal DomainAliases(hMailServer.DomainAliases o)
        {
            _object = o;
        }

        public IDomainAlias Add()
        {
            return new DomainAlias(_object.Add());
        }

        public void Delete(int index)
        {
            _object.Delete(index);
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

        public IDomainAlias this[int index]
        {
            get
            {
                return new DomainAlias(_object[index]);
            }
        }

        public IDomainAlias ItemByDBID(int DBID)
        {
            return new DomainAlias(_object.ItemByDBID[DBID]);
        }
    }
}
