using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IApplication
    {
        IAccount Authenticate(string Username, string Password);

        void Connect();

        void Reinitialize();

        void Start();

        void Stop();

        void SubmitEMail();

        IDomains Domains
        {
            get;
        }

        string Version
        {
            get;
        }

        bool Authenticated
        {
            get;
        }
    }
}
