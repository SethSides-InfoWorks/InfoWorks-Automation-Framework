using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWorksAutomationFramework.Page_Objects
{
    public static class NavBar
    {
        private static UIElement SolutionsLink => Browser.FindElementBy.LinkText("Solutions");
        private static UIElement IndustriesLink => Browser.FindElementBy.Id("menu-item-2989");
        private static UIElement AboutUsLink => Browser.FindElementBy.XPath("//*[@id='menu-item-2970']");
        private static UIElement CareersLink => Browser.FindElementBy.LinkText("Careers");
        private static UIElement BlogLink => Browser.FindElementBy.LinkText("Blog");
        private static UIElement NewsLink => Browser.FindElementBy.LinkText("News");
        private static UIElement ContactLink => Browser.FindElementBy.LinkText("Contact Us");

        #region Industries Links
        private static UIElement HealthCareLink => IndustriesLink.FindElementBy.LinkText("Healthcare");
        private static UIElement FinancialServicesLink => IndustriesLink.FindElementBy.Id("menu-item-2986");
        private static UIElement ManufacturingLink => IndustriesLink.FindElementBy.ClassName("menu-item-2971");
        private static UIElement RetailLink => IndustriesLink.FindElementBy.Id("menu-item-2985");
        private static UIElement NonProfitLink => IndustriesLink.FindElementBy.Id("menu-item-3162");
        #endregion

        #region Site Navigation Methods
        public static void GoToSolutions()
        {
            SolutionsLink.Click();
        }
        public static void GoToHealthCareIndustry()
        {
            IndustriesLink.Hover();
            HealthCareLink.Click();
        }
        public static void GoToFinancialServicesIndustry()
        {
            IndustriesLink.Hover();
            FinancialServicesLink.Click();
        }
        public static void GoToManufacturingIndustry()
        {
            IndustriesLink.Hover();
            ManufacturingLink.Click();
        }
        public static void GoToRetailIndustry()
        {
            IndustriesLink.Hover();
            RetailLink.Click();
        }
        public static void GoToNonProfitIndustry()
        {
            IndustriesLink.Hover();
            NonProfitLink.Click();
        }
        public static void GoToAboutUs()
        {
            AboutUsLink.Click();
        }
        public static void GoToCareers()
        {
            CareersLink.Click();
        }
        public static void GoToBlog()
        {
            BlogLink.Click();
        }
        public static void GoToNews()
        {
            NewsLink.Click();
        }
        public static void GoToContactUs()
        {
            ContactLink.Click();
        }
        #endregion
    }
}
