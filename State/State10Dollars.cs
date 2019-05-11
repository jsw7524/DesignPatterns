using System;

namespace State
{
    class State10Dollars : State
    {
        private static State10Dollars st = new State10Dollars();
        public static State10Dollars GetState()
        {
            return st;
        }

        private State10Dollars() : base(10)
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
            Console.WriteLine("You get a bottle of Water!");
            return base.BuyWater(scm);
        }
    }
}
