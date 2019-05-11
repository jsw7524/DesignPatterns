using System;

namespace State
{
    class State20Dollars : State
    {
        private static State20Dollars st = new State20Dollars();
        public static State20Dollars GetState()
        {
            return st;
        }

        private State20Dollars() : base(20)
        {

        }
        public override State BuyAppleJuice(StateContextManager scm)
        {
            Console.WriteLine("You get a bottle of AppleJuice!");
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
