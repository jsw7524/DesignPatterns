using System;

namespace Prototype
{
    public interface IProduct : ICloneable
    {
        void Use(String s);
        IProduct CreateClone();
    }
}