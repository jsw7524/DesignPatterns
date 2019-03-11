using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    public class Singleton // why not static class
    {
        private static Singleton singleton = new Singleton();

        private Singleton()
        {
            Console.WriteLine("生成了一個Singleton物件");
        }

        public static Singleton GetSingleton()
        {
            return singleton;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Singleton obj1 = Singleton.GetSingleton();
            Singleton obj2 = Singleton.GetSingleton();

            if (obj1 == obj2)
            {
                Console.WriteLine("obj1 == obj2");
            }
            else
            {
                Console.WriteLine("obj1 != obj2");
            }

            Console.ReadLine();
        }
    }
}
