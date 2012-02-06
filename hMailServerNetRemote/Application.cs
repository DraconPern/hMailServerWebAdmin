using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Application : MarshalByRefObject
    {
        hMailServer.Application _object;
        bool Authed;

        internal Application()
        {
            _object = new hMailServer.Application();
            Authed = false;
        }

        public Account Authenticate(string Username, string Password)
        {
            hMailServer.Account a = _object.Authenticate(Username, Password);
            if (a != null)
            {
                Authed = true;
                return new Account(a);
            }

            return null;
        }

        public void Connect()
        {
            _object.Connect();
        }

        public void Reinitialize()
        {
            _object.Reinitialize();
        }

        public void Start()
        {
            _object.Start();
        }

        public void Stop()
        {
            _object.Stop();
        }

        public void SubmitEMail()
        {
            _object.SubmitEMail();
        }

        public Domains Domains
        {
            get
            {
                return new Domains(_object.Domains);
            }
        }

        public string Version
        {
            get
            {
                return _object.Version;
            }
        }

        public bool Authenticated
        {
            get
            {
                return Authed;
            }
        }
    }
}
