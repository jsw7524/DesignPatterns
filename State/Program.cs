using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            StateContextManager scm = StateContextManager.GetStateContextManager();
            while (true)
            {
                Console.WriteLine("### money:" + scm.GetCurrentState.change + "$ ###");
                string input = Console.ReadLine();
                State currentState = scm.GetCurrentState;
                switch (input)
                {
                    case "5":
                        scm.TransferState(currentState, 5);
                        break;
                    case "10":
                        scm.TransferState(currentState, 10);
                        break;
                    case "r":
                        currentState.Refund(scm);
                        break;
                    case "a":
                        currentState.BuyAppleJuice(scm);
                        break;
                    case "c":
                        currentState.BuyCola(scm);
                        break;
                    case "w":
                        currentState.BuyWater(scm);
                        break;
                }
            }
        }
    }
}
