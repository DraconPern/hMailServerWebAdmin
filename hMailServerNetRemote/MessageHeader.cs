using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class MessageHeader : MarshalByRefObject
    {
        internal hMailServer.MessageHeader _object;

        internal MessageHeader()
        {
        }

        internal MessageHeader(hMailServer.MessageHeader o)
        {
            _object = o;
        }

        public void Delete()
        {
            _object.Delete();
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
