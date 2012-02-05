using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class MessageHeaders : MarshalByRefObject
    {
        internal hMailServer.MessageHeaders _object;

        internal MessageHeaders()
        {

        }

        internal MessageHeaders(hMailServer.MessageHeaders o)
        {
            _object = o;
        }
        
        public int Count
        {
            get
            {
                return _object.Count;
            }           
        }

        public MessageHeader this[int index]
        {
            get
            {
                return new MessageHeader(_object[index]);
            }
        }

        public MessageHeader this[string Name]
        {
            get
            {
                return ItemByName(Name);
            }
        }

        public MessageHeader ItemByName(string Name)
        {
            return new MessageHeader(_object.ItemByName[Name]);
        }        

    }
}
