using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IAttachment
    {
        void Delete();

        void SaveAs(string sName);

        string Filename
        {
            get;
        }

        int Size
        {
            get;
        }
    }
}
