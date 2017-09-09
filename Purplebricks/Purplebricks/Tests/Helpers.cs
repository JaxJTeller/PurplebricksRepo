using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Purplebricks.Tests
{
    public static class Helpers
    {
        public static void SendKeys(By element, string keys)
        {
            var input = Driver.Instance.FindElement(element);
            input.SendKeys(keys);
        }

        public static void ClickFirstElement(By element = null, ReadOnlyCollection<IWebElement> elementCollection = null)
        {
            ReadOnlyCollection<IWebElement> clickElement = null;
            clickElement = elementCollection ?? Driver.Instance.FindElements(element);
            clickElement[0].Click();
        }

        public static void SelectFromDropdown(IWebElement button, string value)
        {
            var dropdown = new SelectElement(button);
            dropdown.SelectByText(value);
        }

        public static bool HasWarningMessage(string message)
        {
            var elementMessage = Driver.Instance.FindElement(By.XPath("//span[@id='errormsg_0_GmailAddress']"));
            return elementMessage.Displayed && elementMessage.Text == message;
        }

        public static bool VerifyYourAccount(string message)
        {
            var elementMessage = Driver.Instance.FindElement(By.XPath("//h1[@class='redtext']"));
            return elementMessage.Displayed && elementMessage.Text == message;
        }
    }
}
