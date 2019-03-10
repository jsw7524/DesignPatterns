namespace InherentAdapter
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string s) : base(s)
        {
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }

        public void PrintStrong()
        {
            ShowWithAster();
        }
    }
}