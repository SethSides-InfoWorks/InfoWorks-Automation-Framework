using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace InfoWorksAutomationFramework
{
    public class InfoWorksElement
    {
        public ElementScope Element;

        public InfoWorksElement(ElementScope element)
        {
            Element = element;
        }

        public OpenQA.Selenium.Remote.RemoteWebDriver ElementWebDriver
        {
            get
            {
                var re = Element.Native as OpenQA.Selenium.Remote.RemoteWebElement;
                return re.WrappedDriver as OpenQA.Selenium.Remote.RemoteWebDriver;
            }
        }

        public string Text => Element.Text;
        public string Value => Element.Value;

        public InfoWorksElement Hover()
        {
            Element.Hover();
            return this;
        }

        public InfoWorksElement Click(int sleepTimeInSeconds = 0)
        {
            Element.Click();
            Thread.Sleep(sleepTimeInSeconds * 1000);
            return this;
        }

        public InfoWorksElement Type(string textToBeTyped)
        {
            Element.FillInWith(textToBeTyped);
            return this;
        }

        public InfoWorksElement Ereasetext()
        {
            Element.FillInWith(string.Empty);
            return this;
        }

        public bool Exists(Options options = null)
        {
            return Element.Exists(options);
        }

        public InfoWorksElement ScrollTo()
        {
            ((IJavaScriptExecutor) ElementWebDriver).ExecuteScript("arguments[0].scrollIntoView(true);",
                Element.Native);
            return this;
        }

        public InfoWorksElement ClassName(string className)
        {
            ElementWebDriver.FindElement(By.ClassName(className));
            return this;
        }
    }
}
