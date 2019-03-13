using System;

namespace Prototype
{
    public class MessageBox : IProduct
    {
        private char decochar;
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }
        public void Use(String s)
        {
            int length = s.Length;
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine(decochar + " " + s + " " + decochar);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
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