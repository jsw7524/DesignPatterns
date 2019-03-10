using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{

    public interface IPrint
    {
        void PrintWeak();
        void PrintStrong();
    }

    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string s) : base(s)
        {
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }

        public void PrintStrong()
        {
            ShowWithAster();
        }
    }

    public class Banner
    {
        private string bannerString;

        public Banner( string s)
        {
            bannerString = s;
        }
        public void ShowWithParen()
        {
            Console.WriteLine("("+ bannerString + ")");
        }

        public void ShowWithAster()
        {
            Console.WriteLine("*" + bannerString + "*");
        }
    }

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
