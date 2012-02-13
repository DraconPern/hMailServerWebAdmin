using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Accounts : MarshalByRefObject, IAccounts
    {
        internal hMailServer.Accounts _object;

        internal Accounts()
        {
        }

        internal Accounts(hMailServer.Accounts o)
        {
            _object = o;
        }

        public IAccount Add()
        {
            return new Account(_object.Add());
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

        public IAccount this[int index]
        {
            get
            {
                return new Account(_object[index]);                
            }
        }

        public IAccount this[string Address]
        {
            get
            {
                return ItemByAddress(Address);
            }
        }

        public IAccount ItemByAddress(string Address)
        {
            return new Account(_object.ItemByAddress[Address]);            
        }

        public IAccount ItemByDBID(int DBID)
        {
            return new Account(_object.ItemByDBID[DBID]);            
        }        
    }
}
