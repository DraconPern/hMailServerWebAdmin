using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Message : MarshalByRefObject, IMessage
    {
        internal hMailServer.Message _object;

        internal Message()
        {
            _object = new hMailServer.Message();
        }

        internal Message(hMailServer.Message o)
        {
            _object = o;
        }

        public void AddRecipient(string sName, string sAddress)
        {
            _object.AddRecipient(sName, sAddress);
        }

        public void Copy(int iDestinationFolderID)
        {
            _object.Copy(iDestinationFolderID);
        }

        public bool HasBodyType(string BodyType)
        {
            return _object.HasBodyType(BodyType);
        }

        public void RefreshContent()
        {
            _object.RefreshContent();
        }

        public void Save()
        {
            _object.Save();
        }

        public IAttachments Attachments
        {
            get
            {
                return new Attachments(_object.Attachments);
            }
        }

        public string Body
        {
            get
            {
                return _object.Body;
            }
            set
            {
                _object.Body = value;
            }
        }

        public string CC
        {
            get
            {
                return _object.CC;
            }
        }

        public string Charset
        {
            get
            {
                return _object.Charset;
            }
            set
            {
                _object.Charset = value;
            }
        }

        public string Date
        {
            get
            {
                return _object.Date;
            }
            set
            {
                _object.Date = value;
            }
        }

        public int DeliveryAttempt
        {
            get
            {
                return _object.DeliveryAttempt;
            }
        }

        public bool EncodeFields
        {
            get
            {
                return _object.EncodeFields;
            }
            set
            {
                _object.EncodeFields = value;
            }
        }

        public string Filename
        {
            get
            {
                return _object.Filename;
            }
        }

        public class MessageFlag : IMessageFlag
        {
            internal hMailServer.Message _object;
            public MessageFlag(hMailServer.Message o)
            {
                _object = o;
            }

            public bool this[eMessageFlag iType]
            {
                get
                {
                    return _object.Flag[(hMailServer.eMessageFlag) iType];
                }
                set
                {
                    _object.Flag[(hMailServer.eMessageFlag) iType] = value;
                }
            }
        }

        public IMessageFlag Flag
        {
            get
            {
                return new MessageFlag(_object);
            }
        }

        public string From
        {
            get
            {
                return _object.From;
            }
            set
            {
                _object.From = value;
            }
        }

        public string FromAddress
        {
            get
            {
                return _object.FromAddress;
            }
            set
            {
                _object.FromAddress = value;
            }
        }

        public IMessageHeaders Headers
        {
            get
            {
                return new MessageHeaders(_object.Headers);
            }
        }

        public class MessageHeaderValue : IMessageHeaderValue
        {
            internal hMailServer.Message _object;
            public MessageHeaderValue(hMailServer.Message o)
            {
                _object = o;
            }

            public string this[string FieldName]
            {
                get
                {
                    return _object.HeaderValue[FieldName];
                }
                set
                {
                    _object.HeaderValue[FieldName] = value;
                }
            }
        }

        public IMessageHeaderValue HeaderValue
        {
            get
            {
                return new MessageHeaderValue(_object);
            }
        }

        public string HTMLBody
        {
            get
            {
                return _object.HTMLBody;
            }
            set
            {
                _object.HTMLBody = value;
            }
        }

        public int ID
        {
            get
            {
                return _object.ID;
            }
        }

        public DateTime InternalDate
        {
            get
            {
                return _object.InternalDate;
            }
        }

        public IRecipients Recipients
        {
            get
            {
                return new Recipients(_object.Recipients);
            }
        }

        public int Size
        {
            get
            {
                return _object.Size;
            }
        }

        public int State
        {
            get
            {
                return _object.State;
            }
        }

        public string Subject
        {
            get
            {
                return _object.Subject;
            }
            set
            {
                _object.Subject = value;
            }
        }

        public string To
        {
            get
            {
                return _object.To;
            }
        }

    }
}
