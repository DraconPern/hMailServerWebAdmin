using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Alias : MarshalByRefObject
    {
        internal hMailServer.Alias _object;

        internal Alias()
        {

        }

        internal Alias(hMailServer.Alias o)
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

        public bool Active
        {
            get
            {
                return _object.Active;
            }
            set
            {
                _object.Active = value;
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

        public string Name
        {
            get
            {
                return _object.Name;
            }
            set
            {
                _object.Name = value;
            }
        }

        public string Value
        {
            get
            {
                return _object.Value;
            }
            set
            {
                _object.Value = value;
            }
        }

    }
}
