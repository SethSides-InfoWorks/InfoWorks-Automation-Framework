using Coypu;
using InfoWorksAutomationFramework.FrameworkUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWorksAutomationFramework
{
    public class UIElement
    {
        private ElementScope _element;
        public UIElement(ElementScope element)
        {
            _element = element;
            FindElementBy = new ChildElementFinder(element);
            FindElementsBy = new ChildElementsFinder(element);
        }
        public ChildElementFinder FindElementBy { get; }
        public ChildElementsFinder FindElementsBy { get; }
        public string Text => _element.Text;
        public string Value => _element.Value;
        public string Title => _element.Title;
        public string Name => _element.Name;
        public string InnerHTML => _element.InnerHTML;
        public string Id => _element.Id;
        public bool Disabled => _element.Disabled;

        public UIElement Hover()
        {
            _element.Hover();
            return this;
        }

        public UIElement Click()
        {
            _element.Click();
            return this;
        }

        public UIElement Type(string text)
        {
            _element.FillInWith(text);
            return this;
        }

        public UIElement Ereasetext()
        {
            _element.FillInWith(string.Empty);
            return this;
        }

        public bool Exists(Options options = null)
        {
            return _element.Exists(options);
        }

        public void RightClick()
        {
            Actions action = Browser.NewAction();
            action.ContextClick((IWebElement)_element).Build().Perform();
        }

        
    }
}
