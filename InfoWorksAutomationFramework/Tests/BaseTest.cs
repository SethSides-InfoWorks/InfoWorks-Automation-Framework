using Coypu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWorksAutomationFramework
{
    [TestFixture]
    class BaseTest
    {
        [SetUp]
        public void SetupTest()
        {
            SessionConfiguration sessionConfig = new SessionConfiguration();
            sessionConfig.Browser = Coypu.Drivers.Browser.Chrome;
            sessionConfig.Timeout = TimeSpan.FromSeconds(AutomationConstants.MaxTimeout);
            sessionConfig.RetryInterval = TimeSpan.FromSeconds(0.5);
            Browser.Start(sessionConfig);
            var url = System.Configuration.ConfigurationManager.AppSettings["URL"];
            Browser.MaximizeWindow();
            Browser.Visit(url);
        }

        [TearDown]
        public void TearDownTest()
        {
            Browser.Shutdown();
        }
    }
}
