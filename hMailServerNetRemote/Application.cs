using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class Application : MarshalByRefObject
    {
        hMailServer.Application _object;

        internal Application()
        {
            _object = new hMailServer.Application();
        }

        public Account Authenticate(string Username, string Password)
        {
            return new Account(_object.Authenticate(Username, Password));
        }

        public Domains Domains
        {
            get
            {
                return new Domains(_object.Domains);
            }
        }
    }
}
