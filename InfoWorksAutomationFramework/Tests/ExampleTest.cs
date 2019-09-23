using Coypu;
using InfoWorksAutomationFramework.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWorksAutomationFramework
{
    [TestFixture]
    class ExampleTest: BaseTest
    {

        [Test]
        public void ActualTest()
        {
            
            NavBar.GoToHealthCareIndustry();
            Thread.Sleep(3000);
            NavBar.GoToFinancialServicesIndustry();
            Thread.Sleep(3000);
            NavBar.GoToManufacturingIndustry();
            Thread.Sleep(3000);
            NavBar.GoToNonProfitIndustry();
            Thread.Sleep(3000);
            NavBar.GoToRetailIndustry();
            Thread.Sleep(3000);
        }   

    }
}
