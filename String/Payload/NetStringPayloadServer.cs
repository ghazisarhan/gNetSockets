﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetSockets
{
    public class NetStringPayloadServer : NetBaseServer<string>
    {
        protected override NetBaseStream<string> CreateStream(System.Net.Sockets.NetworkStream ns, System.Net.EndPoint ep)
        {
            return new NetStringPayloadStream(ns, ep);
        }
    }
}
