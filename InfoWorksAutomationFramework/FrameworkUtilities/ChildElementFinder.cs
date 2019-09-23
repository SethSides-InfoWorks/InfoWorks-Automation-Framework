using Coypu;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWorksAutomationFramework.FrameworkUtilities
{
    public class ChildElementFinder
    {
        private ElementScope _parentElement;
        public ChildElementFinder(ElementScope parentElement)
        {
            _parentElement = parentElement;
        }

        public UIElement Css(string css)
        {
            return new UIElement(_parentElement.FindCss(css));
        }

        public UIElement ButtonText(string buttonText)
        {
            return new UIElement(_parentElement.FindButton(buttonText));
        }

        public UIElement Id(string id)
        {
            return new UIElement(_parentElement.FindId(id));
        }

        public UIElement LinkText(string linkText)
        {
            return new UIElement(_parentElement.FindLink(linkText));
        }

        public UIElement XPath(string xPath)
        {
            return new UIElement(_parentElement.FindXPath(xPath));
        }
        public UIElement TagName(string tagName)
        {
            IWebElement element = (IWebElement)_parentElement.Native;
            return new UIElement ((ElementScope)element.FindElement(By.TagName(tagName)));
        }
        public UIElement ClassName(string className)
        {
            IWebElement element = (IWebElement)_parentElement.Native;
            return new UIElement((ElementScope)element.FindElement(By.ClassName(className)));
        }

    }
    //TODO:
    //Implement FindChildElement()
    //Implement FindChildElements()
}
