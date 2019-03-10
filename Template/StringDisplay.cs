using System;

namespace Template
{
    public class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
        }

        public StringDisplay(string s)
        {
            str = s;
            width = s.Length;

        }
        public override void Open()
        {
            PrintLine();
        }

        public override void Close()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine("|"+str+"|");
        }
    }
}