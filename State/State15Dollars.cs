using System;

namespace State
{
    class State15Dollars : State
    {
        private static State15Dollars st = new State15Dollars();
        public static State15Dollars GetState()
        {
            return st;
        }

        private State15Dollars() : base(15)
        {

        }
        public override State BuyAppleJuice(StateContextManager scm)
        {
            Console.WriteLine("not enough money!");
            return base.BuyAppleJuice(scm);
        }

        public override State BuyCola(StateContextManager scm)
        {
            Console.WriteLine("You get a bottle of Cola!");
            return base.BuyCola(scm);
        }

        public override State BuyWater(StateContextManager scm)
        {
            Console.WriteLine("You get a bottle of Water!");
            return base.BuyWater(scm);
        }
    }
}
