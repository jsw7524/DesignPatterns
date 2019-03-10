using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherentAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            InherentAdapter();

            Console.ReadLine();
        }

        internal static void InherentAdapter()
        {
            IPrint p = new PrintBanner("Hello InherentAdapter");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
