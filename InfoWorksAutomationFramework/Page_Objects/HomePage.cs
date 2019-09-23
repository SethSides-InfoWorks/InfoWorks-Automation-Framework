using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWorksAutomationFramework.Page_Objects
{
    public static class HomePage
    {
        private static UIElement AnalyticsLink => Browser.FindElementBy.LinkText("Analytics Solutions");
        private static UIElement ManagementLink => Browser.FindElementBy.LinkText("Management Solutions");
        private static UIElement TechnologyLink => Browser.FindElementBy.LinkText("Technology Solutions");

        public static void GoToManagementPage()
        {
            ManagementLink.Click();
        }

        public static void GoToAnalyticsPage()
        {
            AnalyticsLink.Click();
        }

        public static void GoToTechnologyPage()
        {
            TechnologyLink.Click();
        }
    }
}
