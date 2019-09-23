using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Coypu;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace InfoWorksAutomationFramework
{
    
    public static class Browser
    {
        private static ConcurrentDictionary<int, BrowserSession> _browserSessions = new ConcurrentDictionary<int, BrowserSession>();
        public static string PageTitle => BrowserSession().Title;

        private static BrowserSession BrowserSession()
        {
            return _browserSessions[Thread.CurrentThread.GetHashCode()];
        }

        private static RemoteWebDriver WebDriver()
        {
            return ((RemoteWebDriver)BrowserSession().Native);
        }

        public static void Start(SessionConfiguration sessionConfig)
        {
            _browserSessions.TryAdd(Thread.CurrentThread.GetHashCode(), new BrowserSession(sessionConfig));
        }

        public static void Shutdown()
        {
            _browserSessions[Thread.CurrentThread.GetHashCode()].Dispose();
            _browserSessions.TryRemove(Thread.CurrentThread.GetHashCode(), out BrowserSession _);
        }

        public static Actions NewAction()
        {
            return new Actions(WebDriver());
        }

        #region Browser Manipulations
        public static void Visit(string url)
        {
            BrowserSession().Visit(url);
        }
      
        public static void MaximizeWindow()
        {
            BrowserSession().MaximiseWindow();
        }

        public static void ResizeTo(int width, int height)
        {
            BrowserSession().ResizeTo(width, height);
        }
       
        public static object ExecuteScript(string javascript, params object[] args)
        {
            return BrowserSession().ExecuteScript(javascript, args);
        }
       
        public static void GoBack()
        {
            BrowserSession().GoBack();
        }

        public static void GoForward()
        {
            BrowserSession().GoForward();
        }

        public static void Refresh()
        {
            BrowserSession().Refresh();
        }
       
        public static void SaveScreenshot(string saveAs)
        {
            BrowserSession().SaveScreenshot(saveAs);
        }

        #endregion


        public static ElementFinder FindElementBy => ElementFinder.Instance;

        public static ElementsFinder FindElementsBy => ElementsFinder.Instance;


        #region Element Finder
        //TODO: Implement finding elements
        public class ElementFinder
        {
            private ElementFinder()
            {

            }

            private static readonly ElementFinder _instance = new ElementFinder();

            public static ElementFinder Instance => _instance;


            public UIElement ClassName(string className)
            {
                return new UIElement((ElementScope)WebDriver().FindElementByClassName(className));
            }
            public UIElement ButtonText(string buttonText, Options options = null)
            {
                return new UIElement(BrowserSession().FindButton(buttonText, options));
            }
            public UIElement Id(string id, Options options = null)
            {
                return new UIElement(BrowserSession().FindId(id, options));
            }
            public UIElement LinkText(string linkText, Options options = null)
            {
                return new UIElement(BrowserSession().FindLink(linkText, options));
            }
            public UIElement XPath(string xPath, Options options = null)
            {
                return new UIElement(BrowserSession().FindXPath(xPath, options));
            }
            public UIElement TagName(string tagName)
            {
                return new UIElement((ElementScope)WebDriver().FindElementByTagName(tagName));
            }
        }
        #endregion

        #region Elements Finder
        //TODO: Implement finding elements
        public class ElementsFinder
        {
            private ElementsFinder()
            {

            }

            private static readonly ElementsFinder _instance = new ElementsFinder();

            public static ElementsFinder Instance => _instance;



            public List<UIElement> Css(string css)
            {
                var elements = BrowserSession().FindAllCss(css);
                List<UIElement> UIElements = new List<UIElement>();
                foreach(var element in elements)
                {
                    UIElements.Add(new UIElement(element));
                }
                return UIElements;
            }

            public List<UIElement> XPath(string xPath, Options option = null)
            {
                var elements = BrowserSession().FindAllXPath(xPath);
                List<UIElement> UIElements = new List<UIElement>();
                foreach (var element in elements)
                {
                    UIElements.Add(new UIElement(element));
                }
                return UIElements;
            }
            
            public List<UIElement> TagName(string tagName)
            {
                var elements = WebDriver().FindElementsByTagName(tagName);
                List<UIElement> UIElements = new List<UIElement>();
                foreach(var element in elements)
                {
                    UIElements.Add(new UIElement((ElementScope)element));
                }
                return UIElements;
            }

            public List<UIElement> ClassName(string className)
            {
                var elements = WebDriver().FindElementsByClassName(className);
                List<UIElement> UIElements = new List<UIElement>();
                foreach (var element in elements)
                {
                    UIElements.Add(new UIElement((ElementScope)element));
                }
                return UIElements;
            }
        }
        #endregion
    }
}
