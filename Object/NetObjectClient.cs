using System.Net;
using System.Net.Sockets;

namespace NetSockets
{
    public class NetObjectClient : NetBaseClient<NetObject>
    {
        public void Send(string name, object obj)
        {
            Send(new NetObject { Name = name, Object = obj });
        }

        protected override NetBaseStream<NetObject> CreateStream(NetworkStream ns, EndPoint ep)
        {
            return new NetObjectStream(ns, ep);
        }
    }
}
