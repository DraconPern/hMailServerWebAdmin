using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class IMAPFolder : MarshalByRefObject, IIMAPFolder
    {
        internal hMailServer.IMAPFolder _object;

        internal IMAPFolder()
        {

        }

        internal IMAPFolder(hMailServer.IMAPFolder o)
        {
            _object = o;
        }

        public void Delete()
        {
            _object.Delete();
        }

        public void Save()
        {
            _object.Save();
        }       

        public int ID
        {
            get
            {
                return _object.ID;
            }
        }

        public IMessages Messages
        {
            get
            {
                return new Messages(_object.Messages);
            }            
        }

        public string Name
        {
            get
            {
                return _object.Name;
            }
            set
            {
                _object.Name = value;
            }
        }

        public int ParentID
        {
            get
            {
                return _object.ParentID;
            }           
        }

        /*
        public IMAPFolderPermissions Permissions
        {
            get
            {
                return new IMAPFolderPermissions(_object.Permissions);
            }
        }*/

        public IIMAPFolders SubFolders
        {
            get
            {
                return new IMAPFolders(_object.SubFolders);
            }
        }

        public bool Subscribed
        {
            get
            {
                return _object.Subscribed;
            }
            set
            {
                _object.Subscribed = value;
            }
        }
    }
}
