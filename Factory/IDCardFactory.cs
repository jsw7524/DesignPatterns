using System.Collections.Generic;

namespace Factory
{
    public class IDCardFactory : Factory
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
}