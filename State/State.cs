namespace State
{
    public abstract class State
    {
        public readonly int change;
        protected State(int c)
        {
            change = c;
        }
        public virtual State Transfer(StateContextManager scm)
        {
            return null;
        }

        public virtual State Reset(StateContextManager scm)
        {
            return scm.ResetState();
        }
        public virtual State Refund(StateContextManager scm)
        {
            scm.RefundMoney(this);
            return Reset(scm);
        }

        public State GetState()
        {
            return this;
        }

        public virtual State BuyCola(StateContextManager scm)
        {
            return scm.TransferState(this, Operation.buyCola);
        }
        public virtual State BuyAppleJuice(StateContextManager scm)
        {
            return scm.TransferState(this, Operation.buyAppleJuice);
        }

        public virtual State BuyWater(StateContextManager scm)
        {
            return scm.TransferState(this, Operation.buyWater);
        }


    }
}
