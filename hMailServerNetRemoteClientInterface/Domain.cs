using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IDomain
    {
        void Delete();

        void Save();

        void SynchronizeDirectory();

        IAccounts Accounts
        {
            get;
        }

        bool Active
        {
            get;
            set;
        }

        string ADDomainName
        {
            get;
            set;
        }

        bool AddSignaturesToLocalMail
        {
            get;
            set;
        }

        bool AddSignaturesToReplies
        {
            get;
            set;
        }

        IAliases Aliases
        {
            get;
        }

        long AllocatedSize
        {
            get;
        }


        bool AntiSpamEnableGreylisting
        {
            get;
            set;
        }

        IDistributionLists DistributionLists
        {
            get;
        }

        IDomainAliases DomainAliases
        {
            get;
        }

        int ID
        {
            get;
        }

        int MaxAccountSize
        {
            get;
            set;
        }

        int MaxMessageSize
        {
            get;
            set;
        }

        int MaxNumberOfAccounts
        {
            get;
            set;
        }

        bool MaxNumberOfAccountsEnabled
        {
            get;
            set;
        }

        int MaxNumberOfAliases
        {
            get;
            set;
        }

        bool MaxNumberOfAliasesEnabled
        {
            get;
            set;
        }

        int MaxNumberOfDistributionLists
        {
            get;
            set;
        }

        bool MaxNumberOfDistributionListsEnabled
        {
            get;
            set;
        }

        int MaxSize
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string PlusAddressingCharacter
        {
            get;
            set;
        }

        bool PlusAddressingEnabled
        {
            get;
            set;
        }

        string Postmaster
        {
            get;
            set;
        }

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

        eDomainSignatureMethod SignatureMethod
        {
            get;
            set;
        }

        string SignaturePlainText
        {
            get;
            set;
        }

        int Size
        {
            get;
        }

    }

    public enum eDomainSignatureMethod
    {
        eSMUnknown = 0,
        eSMSetIfNotSpecifiedInAccount = 1,
        eSMOverwriteAccountSignature = 2,
        eSMAppendToAccountSignature = 3,
    }
}
