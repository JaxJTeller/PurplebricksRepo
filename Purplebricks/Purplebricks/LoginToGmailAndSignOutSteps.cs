using OpenQA.Selenium;
using Purplebricks.Tests;
using System;
using TechTalk.SpecFlow;

namespace Purplebricks
{
    [Binding]
    public class LoginToGmailAndSignOutSteps
    {
        [Given(@"I fill in the Email address '(.*)'")]
        public void GivenIFillInTheEmailAddress(string emailAccount)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("identifierId"), emailAccount);
            Helpers.SendKeys(By.Id("identifierId"), Keys.Enter);
        }

        [Given(@"I fill in the account Password '(.*)'")]
        public void GivenIFillInTheAccountPassword(string password)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.XPath("//input[@class='whsOnd zHQkBf']"), password);
        }

    }
}
