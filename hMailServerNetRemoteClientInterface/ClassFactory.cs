using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public class ClassFactory : MarshalByRefObject
    {
        public Application CreateApplication()
        {
            return new Application();
        }

        public Message CreateMessage()
        {
            return new Message();
        } 
    }
}
