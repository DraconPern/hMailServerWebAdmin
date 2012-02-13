using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IMessage
    {

        void AddRecipient(string sName, string sAddress);

        void Copy(int iDestinationFolderID);

        bool HasBodyType(string BodyType);

        void RefreshContent();

        void Save();
        IAttachments Attachments
        {
            get;
        }

        string Body
        {
            get;
            set;
        }

        string CC
        {
            get;
        }

        string Charset
        {
            get;
            set;
        }

        string Date
        {
            get;
            set;
        }

        int DeliveryAttempt
        {
            get;
        }

        bool EncodeFields
        {
            get;
            set;
        }

        string Filename
        {
            get;
        }

        IMessageFlag Flag
        {
            get;
        }

        string From
        {
            get;
            set;
        }

        string FromAddress
        {
            get;
            set;
        }

        IMessageHeaders Headers
        {
            get;
        }


        IMessageHeaderValue HeaderValue
        {
            get;
        }

        string HTMLBody
        {
            get;
            set;
        }

        int ID
        {
            get;
        }

        DateTime InternalDate
        {
            get;
        }

        IRecipients Recipients
        {
            get;
        }

        int Size
        {
            get;
        }

        int State
        {
            get;
        }

        string Subject
        {
            get;
            set;
        }

        string To
        {
            get;
        }

    }

    public interface IMessageFlag
    {
        bool this[eMessageFlag iType]
        {
            get;
            set;
        }
    }

    public enum eMessageFlag
    {
        eMFSeen = 1,
        eMFDeleted = 2,
        eMFFlagged = 4,
        eMFAnswered = 8,
        eMFDraft = 16,
        eMFRecent = 32,
        eMFVirusScan = 64,
    }

    public interface IMessageHeaderValue
    {
        string this[string FieldName]
        {
            get;
            set;
        }
    }


}
