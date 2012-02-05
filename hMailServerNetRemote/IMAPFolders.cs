using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class IMAPFolders : MarshalByRefObject
    {
        internal hMailServer.IMAPFolders _object;

        public IMAPFolders()
        {
        }

        internal IMAPFolders(hMailServer.IMAPFolders o)
        {
            _object = o;
        }

        public IMAPFolder Add(string sName)
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

        public IMAPFolder this[int index]
        {
            get
            {
                return new IMAPFolder(_object[index]);
            }
        }

        public IMAPFolder this[string sName]
        {
            get
            {
                return ItemByName(sName);
            }
        }

        public IMAPFolder ItemByName(string sName)
        {
            return new IMAPFolder(_object.ItemByName[sName]);
        }

        public IMAPFolder ItemByDBID(int DBID)
        {
            return new IMAPFolder(_object.ItemByDBID[DBID]);
        }
    }
}
