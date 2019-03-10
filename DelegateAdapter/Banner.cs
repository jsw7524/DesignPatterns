using System;

namespace DelegateAdapter
{
    public class Banner
    {
        private string bannerString;

        public Banner(string s)
        {
            bannerString = s;
        }
        public void ShowWithParen()
        {
            Console.WriteLine("(" + bannerString + ")");
        }

        public void ShowWithAster()
        {
            Console.WriteLine("*" + bannerString + "*");
        }
    }
}