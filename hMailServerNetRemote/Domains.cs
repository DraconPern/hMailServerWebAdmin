using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Domains : MarshalByRefObject, IDomains
    {
        internal hMailServer.Domains _object;

        public Domains()
        {
        }

        internal Domains(hMailServer.Domains o)
        {
            _object = o;
        }

        public IDomain Add()
        {
            return new Domain(_object.Add());
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

        public IDomain this[int index]
        {
            get
            {
                return new Domain(_object[index]);                
            }
        }

        public IDomain this[string ItemName]
        {
            get
            {
                return ItemByName(ItemName);
            }
        }

        public IDomain ItemByName(string ItemName)
        {
            return new Domain(_object.ItemByName[ItemName]);            
        }

        public IDomain ItemByDBID(int DBID)
        {
            return new Domain(_object.ItemByDBID[DBID]);            
        }

        public string Names
        {
            get
            {
                return _object.Names;
            }
        }

        //

        public List<IDomain> ToList()
        {
            List<IDomain> domains = new List<IDomain>();
            for (int i = 0; i < _object.Count; i++)
            {
                domains.Add(this[i]);
            }

            return domains;
        }

    }
}
