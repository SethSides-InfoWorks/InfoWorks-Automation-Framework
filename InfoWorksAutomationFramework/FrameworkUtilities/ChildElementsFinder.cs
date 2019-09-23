using Coypu;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWorksAutomationFramework.FrameworkUtilities
{
    public class ChildElementsFinder
    {
        private ElementScope _parentElement;
        public ChildElementsFinder(ElementScope parentelement)
        {
            _parentElement = parentelement;
        }

        public List<UIElement> Css(string css)
        {
            var elements = _parentElement.FindAllCss(css);
            List<UIElement> UIElements = new List<UIElement>();
            foreach (var element in elements)
            {
                UIElements.Add(new UIElement(element));
            }
            return UIElements;
        }

        public List<UIElement> XPath(string xPath)
        {
            var elements = _parentElement.FindAllXPath(xPath);
            List<UIElement> UIElements = new List<UIElement>();
            foreach (var element in elements)
            {
                UIElements.Add(new UIElement(element));
            }
            return UIElements;
        }
        public List<UIElement> ClassName(string className)
        {
            var UIElements = new List<UIElement>();
            IWebElement webElement = ((IWebElement)_parentElement.Native);
            foreach(var element in webElement.FindElements(By.ClassName(className)))
            {
                UIElements.Add(new UIElement((ElementScope)element));
            }
            return UIElements;
        }
        public List<UIElement> TagName(string tagName)
        {
            var UIElements = new List<UIElement>();
            IWebElement webElement = ((IWebElement)_parentElement.Native);
            foreach (var element in webElement.FindElements(By.TagName(tagName)))
            {
                UIElements.Add(new UIElement((ElementScope)element));
            }
            return UIElements;
        }
    }
}
