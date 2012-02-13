using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDomainAlias
    {

        void Delete();

        void Save();

        string AliasName
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

    }
}
