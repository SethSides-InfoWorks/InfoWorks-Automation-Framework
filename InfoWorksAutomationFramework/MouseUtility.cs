using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace InfoWorksAutomationFramework
{
    public class MouseUtility
    {
        public static void DragAndDrop(BrowserWindow currentBrowser, ElementScope elementFrom, ElementScope elementTo, bool clickAfter = true)
        {
            Actions action = new Actions((OpenQA.Selenium.Remote.RemoteWebDriver)((BrowserSession)currentBrowser).Native);

            action.DragAndDrop((IWebElement)elementFrom.Native, (IWebElement)elementTo.Native).Build().Perform();

            if (clickAfter)
            {
                elementTo.Click();
            }
        }

        public static void RightClick(BrowserWindow currentBrowser, ElementScope element)
        {
            Actions action = new Actions((OpenQA.Selenium.Remote.RemoteWebDriver)((BrowserSession)currentBrowser).Native);

            action.ContextClick((IWebElement)element).Build().Perform();
        }

        public static void HoverAndClick(BrowserWindow currentBrowser, ElementScope element, int waitTimeInSeconds = 2,
            string xpath = "")
        {
            var remoteWebDriver = (OpenQA.Selenium.Remote.RemoteWebDriver)((BrowserSession)currentBrowser).Native;
            Actions action = new Actions(remoteWebDriver);
            IWebElement target = (IWebElement) element.Native;
            if (!string.IsNullOrEmpty(xpath)) target = remoteWebDriver.FindElementByXPath(xpath);

            action.MoveToElement(target).Build().Perform();
            System.Threading.Thread.Sleep(waitTimeInSeconds * 1000);
            action.Click(target).Build().Perform();
        }

    }
}
