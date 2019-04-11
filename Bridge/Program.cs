using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class DisplayImpl
    {
        public abstract void RawOpen();
        public abstract void RawPrint();
        public abstract void RawClose();
    }

    class StringDisplayImpl : DisplayImpl
    {
        string content;
        int width;

        public StringDisplayImpl(string s)
        {
            content = s;
            width = s.Length;
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine("|"+content+ "|");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i=0;i<width;i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

    }

    class Display
    {
        DisplayImpl impl;
        public Display(DisplayImpl d)
        {
            impl = d;
        }
        public void Open()
        {
            impl.RawOpen();
        }
        public void Print()
        {
            impl.RawPrint();
        }
        public void Close()
        {
            impl.RawClose();
        }
        public virtual void Show()
        {
            Open();
            Print();
            Close();
        }
    }

    class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl d) :base(d)
        {
        }

        public override void Show()
        {
            Open();
            base.Show();
            Close();
        }

        public void MultiDisplay(int times)
        {
            Open();
            for (int i=0; i<times;i++)
            {
                Print();
            }
            Close();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello d1"));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello d2"));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello d3"));

            d1.Show();
            d2.Show();
            d3.Show();
            d3.MultiDisplay(5);

            Console.ReadLine();
        }
    }
}
