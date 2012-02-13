using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IAttachments
    {
        void Add(string sFilename);

        void Clear();
        int Count
        {
            get;
        }

        IAttachment this[int index]
        {
            get;
        }
    }
}
