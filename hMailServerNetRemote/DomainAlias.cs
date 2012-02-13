using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class DomainAlias : MarshalByRefObject, IDomainAlias
    {
        internal hMailServer.DomainAlias _object;

        public DomainAlias()
        {
        }

        internal DomainAlias(hMailServer.DomainAlias o)
        {
            _object = o;
        }

        public void Delete()
        {
            _object.Delete();
        }

        public void Save()
        {
            _object.Save();
        }

        public string AliasName
        {
            get
            {
                return _object.AliasName;
            }
            set
            {
                _object.AliasName = value;
            }
        }

        public int DomainID
        {
            get
            {
                return _object.DomainID;
            }
            set
            {
                _object.DomainID = value;
            }
        }

        public int ID
        {
            get
            {
                return _object.ID;
            }
        }

        

    }
}
