using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_ExtractVariable_03
{
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
            bool isMacOs = platform.ToUpper().Contains("MAC");
            bool isIE = browser.ToUpper().Contains("IE");
            bool wasResized = resize > 0;

            if (isMacOs && isIE && WasInitialized() && wasResized)
            {
                Console.WriteLine("Rendering banner for MacOS IE...");
            }
            else
            {
                Console.WriteLine("Conditions not met, skipping banner.");
            }
        }
    }

}
