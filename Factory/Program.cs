using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        public abstract class Factory
        {
            public Product Create(string owner)
            {
                Product p =  CreateProduct(owner);
                RegisterProduct(p);
                return p;
            }

            public abstract Product CreateProduct(string owner);
            public abstract void RegisterProduct(Product p);

        }

        public abstract class Product
        {
            public abstract void Use();
        }

        public class IDCardFactory: Factory
        {
            List<IDCard> owners = new List<IDCard>(); //?????????List<Product> owners = new List<Product>()??????????
            public override Product CreateProduct(string owner)
            {
                return new IDCard(owner);
            }

            public override void RegisterProduct(Product p)
            {
                owners.Add(p as IDCard);
            }
        }

        public class IDCard: Product
        {
            private string owner;

            public IDCard( string s)
            {
                owner = s;
                Console.WriteLine("製作了"+owner + "的ID卡");
            }
            public override void Use()
            {
                Console.WriteLine(owner+"使用了ID卡");
            }
        }

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
