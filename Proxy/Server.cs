﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Server : IServer
    {
        public String Request()
        {
            return "Hello World!";
        }
    }
}
