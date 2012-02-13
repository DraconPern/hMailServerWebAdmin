using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hMailServerNetRemote
{
    public interface IClassFactory
    {
        IApplication CreateApplication();
        IMessage CreateMessage();
    }
}
