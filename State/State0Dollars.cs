using System;

namespace State
{
    // Only 5, 10 dollar are allowed
    // AppleJuice 20$ 
    // Cola 15$
    // water 10$

    class State0Dollars : State
    {
        private static State0Dollars st = new State0Dollars();
        public static State0Dollars GetState()
        {
            return st;
        }
        private State0Dollars() : base(0)
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
