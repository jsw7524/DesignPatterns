using System;

namespace Template
{
    public class CharDisplay : AbstractDisplay
    {
        private char ch;

        public CharDisplay(char c)
        {
            ch = c;
        }
        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Close()
        {
            Console.Write(">>\n");
        }

        public override void Print()
        {
            Console.Write(ch);
        }
    }
}