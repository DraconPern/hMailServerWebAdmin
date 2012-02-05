using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Aliases : MarshalByRefObject
    {
        internal hMailServer.Aliases _object;

        internal Aliases()
        {
        }

        internal Aliases(hMailServer.Aliases o)
        {
            _object = o;
        }

        public Alias Add()
        {
            return new Alias(_object.Add());
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

        public Alias this[int index]
        {
            get
            {
                return new Alias(_object[index]);
            }
        }

        public Alias this[string Name]
        {
            get
            {
                return ItemByName(Name);
            }
        }

        public Alias ItemByName(string Name)
        {
            return new Alias(_object.ItemByName[Name]);
        }

        public Alias ItemByDBID(int DBID)
        {
            return new Alias(_object.ItemByDBID[DBID]);
        }
    }
}
