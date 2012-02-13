using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class IMAPFolders : MarshalByRefObject, IIMAPFolders
    {
        internal hMailServer.IMAPFolders _object;

        public IMAPFolders()
        {
        }

        internal IMAPFolders(hMailServer.IMAPFolders o)
        {
            _object = o;
        }

        public IIMAPFolder Add(string sName)
        {
            return new IMAPFolder(_object.Add(sName));
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

        public IIMAPFolder this[int index]
        {
            get
            {
                return new IMAPFolder(_object[index]);
            }
        }

        public IIMAPFolder this[string sName]
        {
            get
            {
                return ItemByName(sName);
            }
        }

        public IIMAPFolder ItemByName(string sName)
        {
            return new IMAPFolder(_object.ItemByName[sName]);
        }

        public IIMAPFolder ItemByDBID(int DBID)
        {
            return new IMAPFolder(_object.ItemByDBID[DBID]);
        }
    }
}
