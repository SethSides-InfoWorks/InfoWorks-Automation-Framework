using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;

namespace InfoWorksAutomationFramework
{
    public class PageObject1
    {
        public BrowserWindow Browser;

        public PageObject1(BrowserWindow browser)
        {
            this.Browser = browser;
        }

        public InfoWorksElement Testing => new InfoWorksElement(Browser.FindLink("About"));

        public void ClickingIt()
        {
            Testing.Click();
        }
    }
}
