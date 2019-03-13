using System;
using System.Collections.Generic;

namespace Prototype
{
    public class Manager
    {
        private Dictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();
        public void Register(String name, IProduct proto)
        {
            showcase.Add(name, proto);
        }
        public IProduct Create(String protoname)
        {
            IProduct p = (IProduct)showcase[protoname];
            return p.CreateClone();
        }
    }
}