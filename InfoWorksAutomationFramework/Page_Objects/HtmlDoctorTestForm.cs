using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InfoWorksAutomationFramework.Page_Objects
{
    public static class HtmlDoctorTestForm
    {
        private static UIElement PageHeader => Browser.FindElementBy.XPath("//*[@id=\"register\"]/h1");

        private static UIElement FirstNameTextBox => Browser.FindElementBy.Id("given-name");

        private static UIElement LastNameTextBox => Browser.FindElementBy.Id("family-name");

        private static UIElement DateOfBirthTextBox => Browser.FindElementBy.Id("dob");

        private static UIElement EmailTextBox => Browser.FindElementBy.Id("email");

        private static UIElement UrlTextBox => Browser.FindElementBy.Id("url");

        private static UIElement TelephoneTextBox => Browser.FindElementBy.Id("phone");

        private static UIElement ShoeSizeTextBox => Browser.FindElementBy.Id("shoes");

        private static UIElement BillingAddressTextBox => Browser.FindElementBy.Id("address");

        private static UIElement PostalCodeTextBox => Browser.FindElementBy.Id("postCode");

        private static UIElement CountryDropDown => Browser.FindElementBy.Id("country");

        private static UIElement CountryNames => Browser.FindElementBy.XPath("//*[@id=\"country-names\"]");

        private static UIElement CardType => Browser.FindElementBy.Id("mastercard");

        private static UIElement CardNameTextBox => Browser.FindElementBy.Id("cardName");

        private static UIElement CardNumberTextBox => Browser.FindElementBy.Id("cardNo");

        private static UIElement SecurityCodeTextBox => Browser.FindElementBy.Id("security");

        private static UIElement ExpirationDateTextBox => Browser.FindElementBy.Id("expiry");

        private static UIElement PlaceOrderButton =>
            Browser.FindElementBy.XPath("//*[@id=\"register\"]/fieldset[4]/div/button");



        public static void VerifyPageHeader()
        {
            Assert.AreEqual("Register for Miss Bakers Space Cadets", PageHeader.Text);
        }

        public static void FillInFirstNameTextBox(string firstName)
        {
            FirstNameTextBox.Type(firstName);
        }

        public static void FillInLastNameTextBox(string lastName)
        {
            LastNameTextBox.Type(lastName);
        }

        public static void FillInDobTextBox(string dob)
        {
            DateOfBirthTextBox.Type(dob);
        }

        public static void FillInEmailTextBox(string email)
        {
            EmailTextBox.Type(email);
        }

        public static void FillInUrlTextBox(string url)
        {
            UrlTextBox.Type(url);
        }

        public static void FillInTelephoneTextBox(string telephone)
        {
            TelephoneTextBox.Type(telephone);
        }
        
        public static void FillInShoeSizeTextBox(string shoeSize)
        {
            ShoeSizeTextBox.Type(shoeSize);
        }

        public static void FillInBillingAddressTextBox(string billingAddress)
        {
            BillingAddressTextBox.Type(billingAddress);
        }

        public static void FillInPostalCodeTextBox(string postalCode)
        {
            PostalCodeTextBox.Type(postalCode);
        }

        public static void SelectCountryFromDropdown()
        {
            CountryDropDown.Type("England");
        }

        public static void SelectCardType()
        {
            CardType.Click();
        }

        public static void FillInCardName(string cardName)
        {
            CardNameTextBox.Type(cardName);
        }

        public static void FillInCardNumber(string cardNumber)
        {
            CardNumberTextBox.Type(cardNumber);
        }

        public static void FillInCardSecurityCode(string securityCode)
        {
            SecurityCodeTextBox.Type(securityCode);
        }

        public static void FillInCardExpirationDate(string expirationDate)
        {
            ExpirationDateTextBox.Type(expirationDate);
        }

        public static void ClickPlaceOrderButton()
        {
            PlaceOrderButton.Click();
        }

    }
}
