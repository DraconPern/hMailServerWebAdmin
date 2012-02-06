using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Domains : MarshalByRefObject
    {
        internal hMailServer.Domains _object;

        public Domains()
        {
        }

        internal Domains(hMailServer.Domains o)
        {
            _object = o;
        }

        public Domain Add()
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

        public Domain this[int index]
        {
            get
            {
                return new Domain(_object[index]);                
            }
        }

        public Domain this[string ItemName]
        {
            get
            {
                return ItemByName(ItemName);
            }
        }

        public Domain ItemByName(string ItemName)
        {
            return new Domain(_object.ItemByName[ItemName]);            
        }

        public Domain ItemByDBID(int DBID)
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

        public List<Domain> ToList()
        {
            List<Domain> domains = new List<Domain>();
            for (int i = 0; i < _object.Count; i++)
            {
                domains.Add(this[i]);
            }

            return domains;
        }

    }
}
