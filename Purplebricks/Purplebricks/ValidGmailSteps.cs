using NUnit.Framework;
using OpenQA.Selenium;
using Purplebricks.Tests;
using System;
using TechTalk.SpecFlow;

namespace Purplebricks
{
    [Binding]
    public class ValidGmailSteps
    {
        [Given(@"I enter '(.*)' in the Create a password field")]
        public void GivenIEnterInTheCreateAPasswordField(string password)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("Passwd"), password);
        }

        [Given(@"I enter '(.*)' in the Confirm your password field")]
        public void GivenIEnterInTheConfirmYourPasswordField(string confirmPassword)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("PasswdAgain"), confirmPassword);
        }

        [Given(@"I enter '(.*)' in the Birthday Field")]
        public void GivenIEnterInTheBirthdayField(string birthday)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("BirthDay"), birthday);
        }

        [Given(@"I enter '(.*)' in the Month dropdown")]
        public void GivenIEnterInTheMonthDropdown(string month)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.CssSelector("#BirthMonth > div.goog-inline-block.goog-flat-menu-button.jfk-select"), month);
        }

        [Given(@"I enter '(.*)' in the Year field")]
        public void GivenIEnterInTheYearField(string year)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("BirthYear"), year);
        }

        [Given(@"I enter '(.*)' in the Gender dropdown")]
        public void GivenIEnterInTheGenderDropdown(string gender)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.CssSelector("#Gender > div.goog-inline-block.goog-flat-menu-button.jfk-select"), gender);
        }

        [Given(@"I click Next step")]
        public void GivenIClickNextStep()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.Id("submitbutton"));
        }

        [Given(@"I click Agree")]
        public void GivenIClickAgree()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.Id("iagreebutton"));
        }

        [Given(@"I click the scroll down arrow")]
        public void GivenIClickTheScrollDownArrow()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.ClassName("tos-scroll-button-icon"));
        }

        [Then(@"I enter '(.*)' in the phone number field")]
        public void ThenIEnterInThePhoneNumberField(string phoneNumber)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("signupidvinput"), phoneNumber);
        }

        [Then(@"I click Continue")]
        public void ThenIClickContinue()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.Id("next-button"));
        }

        [Then(@"I enter '(.*)' in the SMS code")]
        public void ThenIEnterInTheSMSCode(string smsCode)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.Id("verify-phone-input"), smsCode);
        }

        [Then(@"I click Continue after introducing SMS code")]
        public void ThenIClickContinueAfterIntroducingSMSCode()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.XPath("//input[@class='g-button g-button-submit']"));
        }

        [Then(@"I click Continue on the Welcome screen")]
        public void ThenIClickContinueOnTheWelcomeScreen()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.XPath("//input[@class='g-button g-button-submit']"));
        }

        [Then(@"To continue reintroduce password '(.*)'")]
        public void ThenToContinueReintroducePassword(string password)
        {
            Driver.Wait(1);
            Helpers.SendKeys(By.XPath("//input[@class='whsOnd zHQkBf']"), password);
        }

        [Then(@"I click NEXT")]
        public void ThenIClickNEXT()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.XPath("//content[@class='CwaK9']"));
        }

        [Then(@"I click on the GMAIL profile icon to open its menu")]
        public void ThenIClickOnTheGMAILProfileIconToOpenItsMenu()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.XPath("//a[@class=('gb_b gb_cb gb_R')]"));
        }

        [Then(@"I Sign Out")]
        public void ThenISignOut()
        {
            Driver.Wait(1);
            Helpers.ClickFirstElement(By.XPath("//a[@class=('gb_Ea gb_Ef gb_Mf gb_ue gb_yb')]"));
        }

        [Then(@"The warning message '(.*)' should be displayed")]
        public void ThenTheWarningMessageShouldBeDisplayed(string message)
        {
            Driver.Wait(1);
            Assert.IsTrue(Helpers.VerifyYourAccount(message));
        }
    }
}

