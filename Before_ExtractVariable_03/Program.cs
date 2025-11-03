using System;

namespace Before_ExtractVariable_03
{

    class Program
    {
        static void Main()
        {
            BannerRenderer banner = new BannerRenderer("Mac", "IE", 10, true);
            banner.RenderBanner();

            BannerRenderer banner2 = new BannerRenderer("Windows", "Chrome", 10, true);
            banner2.RenderBanner();

            Console.ReadKey();
        }
    }
}