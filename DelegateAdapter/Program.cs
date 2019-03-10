using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateAdapter();
            Console.ReadLine();
        }

        private static void DelegateAdapter()
        {
            Print p = new PrintBanner("Hello DelegateAdapter");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
