using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    interface Observer
    {
        void Update(NumberGenerator ng);
    }

    class DigitObserver : Observer
    {
        public void Update(NumberGenerator ng)
        {
            Console.WriteLine("Value:"+ng.GetNumber());
        }
    }

    class GraphObserver : Observer
    {
        public void Update(NumberGenerator ng)
        {
            Console.Write("Value:");
            for (int i=0;i< ng.GetNumber();i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }


    abstract class NumberGenerator
    {
        List<Observer> Observers = new List<Observer>();

        public void AddObserver(Observer o)
        {
            Observers.Add(o);
        }

        public void NotifyObservers()
        {
            foreach (var i in Observers)
            {
                i.Update(this);
            }
        }

        abstract public int GetNumber();
        abstract public void Execute();

    }

    class RandomNumberGenerator: NumberGenerator
    {
        private Random rnd = new Random();
        private int number = 0;

        public override void Execute()
        {
            for (int i=0;i<10;i++)
            {
                number = rnd.Next(0, 10);
                NotifyObservers();
            }
        }
        public override int GetNumber()
        {
            return number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator rng = new RandomNumberGenerator();
            DigitObserver d = new DigitObserver();
            GraphObserver g = new GraphObserver();
            rng.AddObserver(d);
            rng.AddObserver(g);

            rng.Execute();

            Console.ReadKey();

        }
    }
}
