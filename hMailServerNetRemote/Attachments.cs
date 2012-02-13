using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Attachments : MarshalByRefObject, IAttachments
    {
        internal hMailServer.Attachments _object;

        public Attachments()
        {
        }

        internal Attachments(hMailServer.Attachments o)
        {
            _object = o;
        }

        public void Add(string sFilename)
        {
            _object.Add(sFilename);
        }        

        public void Clear()
        {
            _object.Clear();
        }

        public int Count
        {
            get
            {
                return _object.Count;
            }
        }

        public IAttachment this[int index]
        {
            get
            {
                return new Attachment(_object[index]);
            }
        }
    }
}
