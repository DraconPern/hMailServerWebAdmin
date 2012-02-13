using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDistributionList
    {

        void Delete();

        void Save();

        bool Active
        {
            get;
        }


        string Address
        {
            get;
        }

        int ID
        {
            get;
        }

        eDistributionListMode Mode
        {
            get;
            set;
        }

        IDistributionListRecipients Recipients
        {
            get;
        }

        string RequireSenderAddress
        {
            get;
            set;
        }

        bool RequireSMTPAuth
        {
            get;
            set;
        }

    }

    public enum eDistributionListMode
    {
        eLMPublic = 0,
        eLMMembership = 1,
        eLMAnnouncement = 2,
        eLMDomainMembers = 3,
        eLMServerMembers = 4,
    }
}
