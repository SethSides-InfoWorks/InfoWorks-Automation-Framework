using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;
using Coypu.Drivers;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace InfoWorksAutomationFramework
{
    [TestFixture]
    public class SuperTest
    {
        public static SessionConfiguration SessConfiguration = new SessionConfiguration();
        protected static BrowserSession Browser = null;
        protected static string _browserName;

        protected static BrowserWindow CurrentBrowser
        {
            get => Browser;
            set => Browser = (BrowserSession) value;
        }

        [SetUp]
        public void SetupTest()
        {
            SessConfiguration.Browser = Coypu.Drivers.Browser.Chrome;
            SessConfiguration.Timeout = TimeSpan.FromSeconds(AutomationConstants.MaxTimeout);
            SessConfiguration.RetryInterval = TimeSpan.FromSeconds(0.5);

            var url = System.Configuration.ConfigurationManager.AppSettings["URL"];
            Browser = new BrowserSession(SessConfiguration);
            CurrentBrowser = Browser;
            ((RemoteWebDriver) Browser.Native).Manage().Window.Maximize();
            Browser.Visit(url);
        }

        public static void AdjustMaxTimeout(double newTimeoutInSeconds)
        {
            SessConfiguration.Timeout = TimeSpan.FromSeconds(newTimeoutInSeconds);
        }

        public static void ResetMaxTimeout()
        {
            SessConfiguration.Timeout = TimeSpan.FromSeconds(AutomationConstants.MaxTimeout);
        }

        [TearDown]
        public void CloseTest()
        {
            Browser.Dispose();
        }

    }
}
