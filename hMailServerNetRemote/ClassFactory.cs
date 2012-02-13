using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class ClassFactory : MarshalByRefObject, IClassFactory
    {
        public IApplication CreateApplication()
        {
            return new Application();
        }

        public IMessage CreateMessage()
        {
            return new Message();
        } 
    }
}
