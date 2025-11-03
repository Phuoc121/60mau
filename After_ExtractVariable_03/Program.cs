using System;

class BannerRenderer
{
    private string platform;
    private string browser;
    private int resize;
    private bool initialized;

    public BannerRenderer(string platform, string browser, int resize, bool initialized)
    {
        this.platform = platform;
        this.browser = browser;
        this.resize = resize;
        this.initialized = initialized;
    }

    private bool WasInitialized()
    {
        return initialized;
    }

    public void RenderBanner()
    {
        if ((platform.ToUpper().IndexOf("MAC") > -1) &&
            (browser.ToUpper().IndexOf("IE") > -1) &&
            WasInitialized() && resize > 0)
        {
            Console.WriteLine("Rendering banner for MacOS IE...");
        }
        else
        {
            Console.WriteLine("Conditions not met, skipping banner.");
        }
    }
}

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
