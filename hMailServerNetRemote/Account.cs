using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Account : MarshalByRefObject, IAccount
    {
        internal hMailServer.Account _object;

        internal Account()
        {
        }

        internal Account(hMailServer.Account o)
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

        public void UnlockMailbox()
        {
            _object.UnlockMailbox();
        }

        public bool ValidatePassword(string Password)
        {
            return _object.ValidatePassword(Password);
        }

        public bool Active
        {
            get
            {
                return _object.Active;
            }
            set
            {
                _object.Active = value;
            }
        }

        public string ADDomain
        {
            get
            {
                return _object.ADDomain;
            }
            set
            {
                _object.ADDomain = value;
            }
        }

        public string Address
        {
            get
            {
                return _object.Address;
            }
            set
            {
                _object.Address = value;
            }
        }

        public eAdminLevel AdminLevel
        {
            get
            {
                return (eAdminLevel) _object.AdminLevel;
            }
            set
            {
                _object.AdminLevel = (hMailServer.eAdminLevel) value;
            }
        }

        public string ADUsername
        {
            get
            {
                return _object.ADUsername;
            }
            set
            {
                _object.ADUsername = value;
            }
        }

        public int DomainID
        {
            get
            {
                return _object.DomainID;
            }
            set
            {
                _object.DomainID = value;
            }
        }

        /*
        public FetchAccounts FetchAccounts
        {
            get
            {
                return new FetchAccounts(_object.FetchAccounts);
            }
        }
         */ 

        public string ForwardAddress
        {
            get
            {
                return _object.ForwardAddress;
            }
            set
            {
                _object.ForwardAddress = value;
            }
        }

        public bool ForwardEnabled
        {
            get
            {
                return _object.ForwardEnabled;
            }
            set
            {
                _object.ForwardEnabled = value;
            }
        }

        public bool ForwardKeepOriginal
        {
            get
            {
                return _object.ForwardKeepOriginal;
            }
            set
            {
                _object.ForwardKeepOriginal = value;
            }
        }

        public int ID
        {
            get
            {
                return _object.ID;
            }
        }

        public IIMAPFolders IMAPFolders
        {
            get
            {
                return new IMAPFolders(_object.IMAPFolders);
            }
        }

        public bool IsAD
        {
            get
            {
                return _object.IsAD;
            }
            set
            {
                _object.IsAD = value;
            }
        }

        public DateTime LastLogonTime
        {
            get
            {
                return _object.LastLogonTime;
            }
        }

        public int MaxSize
        {
            get
            {
                return _object.MaxSize;
            }
            set
            {
                _object.MaxSize = value;
            }
        }

        public IMessages Messages
        {
            get
            {
                return new Messages(_object.Messages);
            }
        }

        public string Password
        {
            get
            {
                return _object.Password;
            }
            set
            {
                _object.Password = value;
            }
        }

        public string PersonFirstName
        {
            get
            {
                return _object.PersonFirstName;
            }
            set
            {
                _object.PersonFirstName = value;
            }
        }

        public string PersonLastName
        {
            get
            {
                return _object.PersonLastName;
            }
            set
            {
                _object.PersonLastName = value;
            }
        }

        public int QuotaUsed
        {
            get
            {
                return _object.QuotaUsed;
            }
        }

        /*
        public Rules Rules
        {
            get
            {
                return new Rules(_object.Rules);
            }
        }*/

        public bool SignatureEnabled
        {
            get
            {
                return _object.SignatureEnabled;
            }
            set
            {
                _object.SignatureEnabled = value;
            }
        }

        public string SignatureHTML
        {
            get
            {
                return _object.SignatureHTML;
            }
            set
            {
                _object.SignatureHTML = value;
            }
        }

        public string SignaturePlainText
        {
            get
            {
                return _object.SignaturePlainText;
            }
            set
            {
                _object.SignaturePlainText = value;
            }
        }

        public float Size
        {
            get
            {
                return _object.Size;
            }
        }

        /// <summary>
        /// The vacation message
        /// </summary>
        public string VacationMessage
        {
            get
            {
                return _object.VacationMessage;
            }
            set
            {
                _object.VacationMessage = value;
            }
        }

        /// <summary>
        /// Vacation message is set to expire
        /// </summary>
        public bool VacationMessageExpires
        {
            get
            {
                return _object.VacationMessageExpires;
            }
            set
            {
                _object.VacationMessageExpires = value;
            }
        }

        /// <summary>
        /// The vacation message expires this date
        /// </summary>
        public string VacationMessageExpiresDate
        {
            get
            {
                return _object.VacationMessageExpiresDate;
            }
            set
            {
                _object.VacationMessageExpiresDate = value;
            }
        }

        /// <summary>
        /// Vacation message is turned on.
        /// </summary>
        public bool VacationMessageIsOn
        {
            get
            {
                return _object.VacationMessageIsOn;
            }
            set
            {
                _object.VacationMessageIsOn = value;
            }
        }

        /// <summary>
        /// The vacation message subject
        /// </summary>
        public string VacationSubject
        {
            get
            {
                return _object.VacationSubject;
            }
            set
            {
                _object.VacationSubject = value;
            }
        }
    }

    
}
