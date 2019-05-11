using System;

namespace State
{
    class State5Dollars : State
    {
        private static State5Dollars st = new State5Dollars();
        public static State5Dollars GetState()
        {
            return st;
        }

        private State5Dollars() : base(5)
        {

        }
        public override State BuyAppleJuice(StateContextManager scm)
        {
            Console.WriteLine("not enough money!");
            return base.BuyAppleJuice(scm);
        }

        public override State BuyCola(StateContextManager scm)
        {
            Console.WriteLine("not enough money!");
            return base.BuyCola(scm);
        }

        public override State BuyWater(StateContextManager scm)
        {
            Console.WriteLine("not enough money!");
            return base.BuyWater(scm);
        }
    }
}
