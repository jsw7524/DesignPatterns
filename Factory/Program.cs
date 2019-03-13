using System;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product p1=factory.Create("Jason");
            Product p2 = factory.Create("Ruby");
            Product p3 = factory.Create("Waku");

            p1.Use();
            p2.Use();
            p3.Use();

            Console.ReadLine();

        }
    }
}
