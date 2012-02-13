using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IAccount
    {
        void Delete();
        void Save();
        void UnlockMailbox();
        bool ValidatePassword(string Password);

        bool Active
        {
            get;
            set;
        }

        string ADDomain
        {
            get;
            set;
        }

        string Address
        {
            get;
            set;
        }

        eAdminLevel AdminLevel
        {
            get;
            set;
        }

        string ADUsername
        {
            get;
            set;
        }

        int DomainID
        {
            get;
            set;
        }

        /*
         FetchAccounts FetchAccounts
        {
            get;
        }
         */

        string ForwardAddress
        {
            get;
            set;
        }

        bool ForwardEnabled
        {
            get;
            set;
        }

        bool ForwardKeepOriginal
        {
            get;
            set;
        }

        int ID
        {
            get;
        }

        IIMAPFolders IMAPFolders
        {
            get;
        }

        bool IsAD
        {
            get;
            set;
        }

        DateTime LastLogonTime
        {
            get;
        }

        int MaxSize
        {
            get;
            set;
        }

        IMessages Messages
        {
            get;
        }

        string Password
        {
            get;
            set;
        }

        string PersonFirstName
        {
            get;
            set;
        }

        string PersonLastName
        {
            get;
            set;
        }

        int QuotaUsed
        {
            get;
        }

        /*
         Rules Rules
        {
            get;
        }*/

        bool SignatureEnabled
        {
            get;
            set;
        }

        string SignatureHTML
        {
            get;
            set;
        }

        string SignaturePlainText
        {
            get;
            set;
        }

        float Size
        {
            get;
        }

        /// <summary>
        /// The vacation IMessage
        /// </summary>
        string VacationMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Vacation IMessage is set to expire
        /// </summary>
        bool VacationMessageExpires
        {
            get;
            set;
        }

        /// <summary>
        /// The vacation IMessage expires this date
        /// </summary>
        string VacationMessageExpiresDate
        {
            get;
            set;
        }

        /// <summary>
        /// Vacation IMessage is turned on.
        /// </summary>
        bool VacationMessageIsOn
        {
            get;
            set;
        }

        /// <summary>
        /// The vacation IMessage subject
        /// </summary>
        string VacationSubject
        {
            get;
            set;
        }
    }

    public enum eAdminLevel
    {
        hAdminLevelNormal = 0,
        hAdminLevelDomainAdmin = 1,
        hAdminLevelServerAdmin = 2,
    }
}
