using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetSockets
{
    public class NetStringServer : NetBaseServer<string>
    {
        protected override NetBaseStream<string> CreateStream(System.Net.Sockets.NetworkStream ns, System.Net.EndPoint ep)
        {
            return new NetStringStream(ns, ep);
        }
    }
}
