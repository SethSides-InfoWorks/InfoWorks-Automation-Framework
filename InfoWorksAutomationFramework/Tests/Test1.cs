using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace InfoWorksAutomationFramework
{
    [TestFixture]
    class Test1 : SuperTest
    {

        [Test]
        public void testing()
        {
            PageObject1 classOne = new PageObject1(CurrentBrowser);
            classOne.ClickingIt();
            Thread.Sleep(5000);
        }

    }
}
