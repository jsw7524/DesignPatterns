using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay p1 =new CharDisplay('H');
            AbstractDisplay p2 = new StringDisplay("Hello World!");
            p1.Display();
            p2.Display();

            Console.ReadLine();

        }
    }
}
