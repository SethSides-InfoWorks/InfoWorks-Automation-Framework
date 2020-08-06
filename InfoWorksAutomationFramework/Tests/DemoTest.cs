using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InfoWorksAutomationFramework.Page_Objects;
using NUnit.Framework;

namespace InfoWorksAutomationFramework.Tests
{
    class DemoTest
    {

        [TestFixture]
        class ExampleTest : BaseTest
        {

            [Test]
            public void DemoAutomationTest1()
            {
                var firstName = "Seth";
                var lastName = "Sides";
                var dateOfBirth = "06141993";
                var email = "seth.sides@infoworks-tn.com";
                var url = "infoworks-tn.com";
                var telephone = "901-826-1359";
                var shoeSize = "10.5";
                var billingAddress = "This is the billing address";
                var postalCode = "37207";
                var country = "England";
                var cardType = "MasterCard";
                var creditCardName = "Seth M. Sides";
                var cardNumber = "1234123412341234";
                var securityCode = "123";
                var expirationDate = "December 2020";

                HtmlDoctorTestForm.FillInFirstNameTextBox(firstName);
                HtmlDoctorTestForm.FillInLastNameTextBox(lastName);
                HtmlDoctorTestForm.FillInDobTextBox(dateOfBirth);
                HtmlDoctorTestForm.FillInEmailTextBox(email);
                HtmlDoctorTestForm.FillInUrlTextBox(url);
                HtmlDoctorTestForm.FillInTelephoneTextBox(telephone);
                HtmlDoctorTestForm.FillInShoeSizeTextBox(shoeSize);
                HtmlDoctorTestForm.FillInBillingAddressTextBox(billingAddress);
                HtmlDoctorTestForm.FillInPostalCodeTextBox(postalCode);
                HtmlDoctorTestForm.SelectCountryFromDropdown();
                HtmlDoctorTestForm.SelectCardType();
                HtmlDoctorTestForm.FillInCardName(creditCardName);
                HtmlDoctorTestForm.FillInCardNumber(cardNumber);
                HtmlDoctorTestForm.FillInCardSecurityCode(securityCode);
                HtmlDoctorTestForm.FillInCardExpirationDate(expirationDate);
                HtmlDoctorTestForm.ClickPlaceOrderButton();
            }

        }
    }
}
