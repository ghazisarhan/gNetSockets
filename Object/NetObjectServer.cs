using System.Net;
using System.Net.Sockets;

namespace NetSockets
{
    public class NetObjectServer : NetBaseServer<NetObject>
    {
        protected override NetBaseStream<NetObject> CreateStream(NetworkStream ns, EndPoint ep)
        {
            return new NetObjectStream(ns, ep);
        }
    }
}
