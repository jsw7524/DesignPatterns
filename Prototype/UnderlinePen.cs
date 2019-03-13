using System;

namespace Prototype
{
    public class UnderlinePen : IProduct
    {
        private char ulchar;
        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }
        public void Use(String s)
        {
            int length = s.Length;
            Console.WriteLine("\"" + s + "\"");
            Console.WriteLine(" ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
        }
        public IProduct CreateClone()
        {
            IProduct p = null;
            try
            {
                p = (IProduct)Clone();
            }
            catch (Exception e)
            {
                throw e;
            }
            return p;
        }

        public object Clone()
        {
            return this.MemberwiseClone(); // shallow copy only
        }
    }
}