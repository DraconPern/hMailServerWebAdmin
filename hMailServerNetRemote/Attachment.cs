using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Attachment : MarshalByRefObject
    {
        internal hMailServer.Attachment _object;

        internal Attachment()
        {
        }

        internal Attachment(hMailServer.Attachment o)
        {
            _object = o;
        }

        public void Delete()
        {
            _object.Delete();
        }

        public void SaveAs(string sName)
        {
            _object.SaveAs(sName);
        }

        public string Filename
        {
            get
            {
                return _object.Filename;
            }
        }

        public int Size
        {
            get
            {
                return _object.Size;
            }
        }
    }
}
