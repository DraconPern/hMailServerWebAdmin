using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Messages : MarshalByRefObject
    {
        internal hMailServer.Messages _object;

        public Messages()
        {
        }

        internal Messages(hMailServer.Messages o)
        {
            _object = o;
        }

        public Message Add()
        {
            return new Message(_object.Add());
        }

        public void Clear()
        {
            _object.Clear();
        }

        public void DeleteByDBID(int DBID)
        {
            _object.DeleteByDBID(DBID);
        }
        
        public int Count
        {
            get
            {
                return _object.Count;
            }
        }

        public Message this[int index]
        {
            get
            {
                return new Message(_object[index]);
            }
        }

        public Message ItemByDBID(int DBID)
        {
            return new Message(_object.ItemByDBID[DBID]);
        }
    }
}
