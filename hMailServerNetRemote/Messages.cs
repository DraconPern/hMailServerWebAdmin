using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Messages : MarshalByRefObject, IMessages
    {
        internal hMailServer.Messages _object;

        public Messages()
        {
        }

        internal Messages(hMailServer.Messages o)
        {
            _object = o;
        }

        public IMessage Add()
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

        public IMessage this[int index]
        {
            get
            {
                return new Message(_object[index]);
            }
        }

        public IMessage ItemByDBID(int DBID)
        {
            return new Message(_object.ItemByDBID[DBID]);
        }
    }
}
