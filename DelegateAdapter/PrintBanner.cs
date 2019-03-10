namespace DelegateAdapter
{
    class PrintBanner : Print
    {
        private Banner banner;

        public PrintBanner(string s)
        {
            banner = new Banner(s);
        }
        public override void PrintWeak()
        {
            banner.ShowWithParen();
        }

        public override void PrintStrong()
        {
            banner.ShowWithAster();
        }
    }
}