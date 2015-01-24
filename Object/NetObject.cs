using System;

namespace NetSockets
{
    [Serializable]
    public class NetObject
    {
        public string Name { get; set; }
        public object Object { get; set; }
        public T Cast<T>()
        {
            return (T)Object;
        }

        public NetObject(string name, object obj)
        {
            Name = name;
            Object = obj;
        }
        public NetObject()
        {

        }
    }
}
