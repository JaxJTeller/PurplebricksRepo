using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Purplebricks.Tests;
using System;
using TechTalk.SpecFlow;

namespace Purplebricks
{
    [Binding]
    public class NonValidGMAILSteps
    {
        [BeforeScenario]
        public void InitializeBeforeScenario()
        {
            Driver.Wait(1);
            Driver.Instantiate();
        }

        [Given(@"I navigate to '(.*)'")]
        public void GivenINavigateTo(string myURL)
        {
            Driver.Wait(1);
            Driver.Instance.Navigate().GoToUrl(myURL);
        }

        [Given(@"I enter '(.*)' in the first name field")]
        public void GivenIEnterInTheFirstNameField(string firstName)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("FirstName"), firstName);
        }
        
        [Given(@"I enter '(.*)' in the last name field")]
        public void GivenIEnterInTheLastNameField(string lastName)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("LastName"), lastName);
        }

        [Given(@"I enter '(.*)' in the mail username field")]
        public void GivenIEnterInTheMailUsernameField(string userName)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("GmailAddress"), userName);
            Helpers.SendKeys(By.Id("GmailAddress"), Keys.Enter);
        }

        [Then(@"The Warning Message '(.*)' For Invalid User Should Be Displayed")]
        public void ThenTheWarningMessageForInvalidUserShouldBeDisplayed(string message)
        {
            Driver.Wait(1);
            Assert.IsTrue(Helpers.HasWarningMessage(message));
        }

        [AfterScenario]
        public void Shutdown()
        {
            Driver.Instance.Close();
            Driver.Instance.Quit();
        }
    }
}
