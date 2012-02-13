using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IAlias
    {
        void Delete();

        void Save();

        bool Active
        {
            get;
            set;
        }

        int DomainID
        {
            get;
            set;
        }

        int ID
        {
            get;
        }

        string Name
        {
            get;
            set;
        }

        string Value
        {
            get;
            set;
        }

    }
}
