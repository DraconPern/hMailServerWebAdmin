using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IIMAPFolder
    {

        void Delete();

        void Save();
        int ID
        {
            get;
        }

        IMessages Messages
        {
            get;
        }

        string Name
        {
            get;
            set;
        }

        int ParentID
        {
            get;
        }

        /*
         IMAPFolderPermissions Permissions
        {
            get
            {
                return new IMAPFolderPermissions(_object.Permissions);
            }
        }*/

        IIMAPFolders SubFolders
        {
            get;
        }

        bool Subscribed
        {
            get;
            set;
        }
    }
}
