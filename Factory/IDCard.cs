using System;

namespace Factory
{
    public class IDCard : Product
    {
        private string owner;

        public IDCard(string s)
        {
            owner = s;
            Console.WriteLine("製作了" + owner + "的ID卡");
        }
        public override void Use()
        {
            Console.WriteLine(owner + "使用了ID卡");
        }
    }
}