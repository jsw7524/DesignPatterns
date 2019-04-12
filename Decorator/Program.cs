using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Display
    {
        public abstract int GetColumns();
        public abstract int GetRows();
        public abstract string GetRowText(int r);

        public void Show()
        {
            for (int i = 0; i < GetRows(); i++)
            {
                Console.WriteLine(GetRowText(i));
            }
        }

    }

    class StringDisplay : Display
    {
        private string content;

        public StringDisplay(string s)
        {
            content = s;
        }
        public override int GetColumns()
        {
            return content.Length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int r)
        {
            return  content;
        }
    }

    abstract class Border : Display
    {
        protected Display display;

        public Border(Display d)
        {
            display = d;
        }

    }

    class SideBorder : Border
    {
        private char borderChar;
        public SideBorder(Display d, char c):base(d)
        {
            borderChar = c;
        }
        public override int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return display.GetRows();
        }

        public override string GetRowText(int r)
        {
            return borderChar + display.GetRowText(r) + borderChar;
        }
    }

    class FullBorder : Border
    {
        public FullBorder(Display d) :base(d)
        {
                
        }
        public override int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + display.GetRows() + 1;
        }

        public override string GetRowText(int r)
        {
            if (r == 0)
            {
                return '+'+MakeLine('-' , display.GetColumns())+ '+';
            }
            else if (r == display.GetRows()+1)
            {
                return '+' + MakeLine('-', display.GetColumns()) + '+';
            }
            return '|' + display.GetRowText(r-1) + '|';
        }

        private string MakeLine(char c, int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Display d1= new StringDisplay("Hello World!");
            Display d2 = new SideBorder(d1,'#');
            Display d3 = new FullBorder(d2);

            //d1.Show();
            //d2.Show();
            //d3.Show();

            Display d4 = new FullBorder(d3);

            Display d5 = new FullBorder(d4);

            d5.Show();

            Console.ReadLine();
        }
    }
}
