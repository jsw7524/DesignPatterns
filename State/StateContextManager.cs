using System;
using System.Collections.Generic;

namespace State
{
    public class StateContextManager
    {
        private State currentState = State0Dollars.GetState();



        public State GetCurrentState { get { return currentState; } }

        private Dictionary<(State, int), State> StateTransitionFunction = new Dictionary<(State, int), State>()
        {
            { (State0Dollars.GetState(),Operation.add5), State5Dollars.GetState() },
            { (State0Dollars.GetState(),Operation.add10), State10Dollars.GetState() },
            { (State0Dollars.GetState(),Operation.buyAppleJuice), State0Dollars.GetState() },
            { (State0Dollars.GetState(),Operation.buyCola), State0Dollars.GetState() },
            { (State0Dollars.GetState(),Operation.buyWater), State0Dollars.GetState() },

            { (State5Dollars.GetState(),Operation.add5), State10Dollars.GetState() },
            { (State5Dollars.GetState(),Operation.add10), State15Dollars.GetState() },
            { (State5Dollars.GetState(),Operation.buyAppleJuice), State5Dollars.GetState() },
            { (State5Dollars.GetState(),Operation.buyCola), State5Dollars.GetState() },
            { (State5Dollars.GetState(),Operation.buyWater), State5Dollars.GetState() },

            { (State10Dollars.GetState(),Operation.add5), State15Dollars.GetState() },
            { (State10Dollars.GetState(),Operation.add10), State20Dollars.GetState() },
            { (State10Dollars.GetState(),Operation.buyAppleJuice), State10Dollars.GetState() },
            { (State10Dollars.GetState(),Operation.buyCola), State10Dollars.GetState() },
            { (State10Dollars.GetState(),Operation.buyWater), State0Dollars.GetState() },

            { (State15Dollars.GetState(),Operation.add5), State20Dollars.GetState() },
            { (State15Dollars.GetState(),Operation.add10), State15Dollars.GetState() },
            { (State15Dollars.GetState(),Operation.buyAppleJuice), State15Dollars.GetState() },
            { (State15Dollars.GetState(),Operation.buyCola), State0Dollars.GetState() },
            { (State15Dollars.GetState(),Operation.buyWater), State5Dollars.GetState() },

            { (State20Dollars.GetState(),Operation.add5), State20Dollars.GetState() },
            { (State20Dollars.GetState(),Operation.add10), State20Dollars.GetState() },
            { (State20Dollars.GetState(),Operation.buyAppleJuice), State0Dollars.GetState() },
            { (State20Dollars.GetState(),Operation.buyCola), State5Dollars.GetState() },
            { (State20Dollars.GetState(),Operation.buyWater), State10Dollars.GetState() },

        };

        private static StateContextManager scm = new StateContextManager();

        private StateContextManager()
        {
        }

        public static StateContextManager GetStateContextManager()
        {
            return scm;
        }

        public State TransferState(State s, int m)
        {
            currentState = StateTransitionFunction[(s, m)];
            return currentState;
        }
        public State ResetState()
        {
            currentState = State0Dollars.GetState();
            return currentState;
        }
        public void RefundMoney(State s)
        {
            Console.WriteLine("Refund " + s.change + " dollars!");
            ResetState();
        }
    }
}
