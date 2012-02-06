using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Domain : MarshalByRefObject
    {
        internal hMailServer.Domain _object;

        public Domain()
        {

        }

        internal Domain(hMailServer.Domain o)
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

        public void SynchronizeDirectory()
        {
            _object.SynchronizeDirectory();
        }

        public Accounts Accounts
        {
            get
            {
                return new Accounts(_object.Accounts);
            }
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

        public string ADDomainName
        {
            get
            {
                return _object.ADDomainName;
            }
            set
            {
                _object.ADDomainName = value;
            }
        }

        public bool AddSignaturesToLocalMail
        {
            get
            {
                return _object.AddSignaturesToLocalMail;
            }
            set
            {
                _object.AddSignaturesToLocalMail = value;
            }
        }

        public bool AddSignaturesToReplies
        {
            get
            {
                return _object.AddSignaturesToReplies;
            }
            set
            {
                _object.AddSignaturesToReplies = value;
            }
        }

        public Aliases Aliases
        {
            get
            {
                return new Aliases(_object.Aliases);
            }
        }

        public long AllocatedSize
        {
            get
            {
                return _object.AllocatedSize;
            }
        }


        public bool AntiSpamEnableGreylisting
        {
            get
            {
                return _object.AntiSpamEnableGreylisting;
            }
            set
            {
                _object.AntiSpamEnableGreylisting = value;
            }
        }

        public DistributionLists DistributionLists
        {
            get
            {
                return new DistributionLists(_object.DistributionLists);
            }
        }

        public DomainAliases DomainAliases
        {
            get
            {
                return new DomainAliases(_object.DomainAliases);
            }
        }

        public int ID
        {
            get
            {
                return _object.ID;
            }
        }

        public int MaxAccountSize
        {
            get
            {
                return _object.MaxAccountSize;
            }
            set
            {
                _object.MaxAccountSize = value;
            }
        }

        public int MaxMessageSize
        {
            get
            {
                return _object.MaxMessageSize;
            }
            set
            {
                _object.MaxMessageSize = value;
            }
        }

        public int MaxNumberOfAccounts
        {
            get
            {
                return _object.MaxNumberOfAccounts;
            }
            set
            {
                _object.MaxNumberOfAccounts = value;
            }
        }

        public bool MaxNumberOfAccountsEnabled
        {
            get
            {
                return _object.MaxNumberOfAccountsEnabled;
            }
            set
            {
                _object.MaxNumberOfAccountsEnabled = value;
            }
        }

        public int MaxNumberOfAliases
        {
            get
            {
                return _object.MaxNumberOfAliases;
            }
            set
            {
                _object.MaxNumberOfAliases = value;
            }
        }

        public bool MaxNumberOfAliasesEnabled
        {
            get
            {
                return _object.MaxNumberOfAliasesEnabled;
            }
            set
            {
                _object.MaxNumberOfAliasesEnabled = value;
            }
        }

        public int MaxNumberOfDistributionLists
        {
            get
            {
                return _object.MaxNumberOfDistributionLists;
            }
            set
            {
                _object.MaxNumberOfDistributionLists = value;
            }
        }

        public bool MaxNumberOfDistributionListsEnabled
        {
            get
            {
                return _object.MaxNumberOfDistributionListsEnabled;
            }
            set
            {
                _object.MaxNumberOfDistributionListsEnabled = value;
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

        public string PlusAddressingCharacter
        {
            get
            {
                return _object.PlusAddressingCharacter;
            }
            set
            {
                _object.PlusAddressingCharacter = value;
            }
        }

        public bool PlusAddressingEnabled
        {
            get
            {
                return _object.PlusAddressingEnabled;
            }
            set
            {
                _object.PlusAddressingEnabled = value;
            }
        }

        public string Postmaster
        {
            get
            {
                return _object.Postmaster;
            }
            set
            {
                _object.Postmaster = value;
            }
        }

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

        public hMailServer.eDomainSignatureMethod SignatureMethod
        {
            get
            {
                return _object.SignatureMethod;
            }
            set
            {
                _object.SignatureMethod = value;
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

        public int Size
        {
            get
            {
                return _object.Size;
            }            
        }

        
    }
}
