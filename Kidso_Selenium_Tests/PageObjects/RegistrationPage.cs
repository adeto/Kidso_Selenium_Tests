using Kidso_Selenium_Tests.PageObjects;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Kidso_Selenium_Tests
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://kidso.bg/vhod?create_account=1";

        public IWebElement Gender =>
            driver.FindElement(By.CssSelector(".form-control-valign > .radio-inline:nth-child(2) input"));
        public IWebElement LinkRegistrationPage =>
            driver.FindElement(By.XPath("//span[contains(.,'Регистрация')]"));

        public IWebElement TextBoxFirstName =>
            driver.FindElement(By.Name("firstname"));
        public IWebElement TextBoxLastName =>
            driver.FindElement(By.Name("lastname"));
        public IWebElement TextBoxEmail =>
            driver.FindElement(By.Name("email"));
        public IWebElement TextBoxPassword =>
            driver.FindElement(By.Name("password"));
        public IWebElement TextBoxKidName =>
            driver.FindElement(By.Name("kids[1][name]"));
        public IWebElement BirthDay =>
            driver.FindElement(By.Name("date_[day]"));
        public IWebElement BirthMonth =>
            driver.FindElement(By.Name("date_[month]"));
        public IWebElement BirthYear =>
            driver.FindElement(By.Name("date_[year]"));
        public IWebElement KidGender =>
            driver.FindElement(By.Id("RadioBoy"));
        public IWebElement GdprAccept =>
            driver.FindElement(By.Name("psgdpr"));
        public IWebElement Recaptcha =>
            driver.FindElement(By.CssSelector(".recaptcha-checkbox-border"));
        public IWebElement DefaultScreen =>
            driver.SwitchTo().ActiveElement();
        public IWebElement SaveButton =>
            driver.FindElement(By.XPath("//button[@data-link-action='save-customer']"));

        public void AddUser(string firstName, string lastName, string email, string password, string kidname)
        {
            this.Gender.Click();
            this.TextBoxFirstName.SendKeys(firstName);
            this.TextBoxLastName.SendKeys(lastName);
            this.TextBoxEmail.SendKeys(email);
            this.TextBoxPassword.SendKeys(password);
            this.TextBoxKidName.SendKeys(kidname);
            this.GdprAccept.Click();
            driver.SwitchTo().Frame(0);
            this.Recaptcha.Click();     // Recaptcha should be disabled on the test environment
            Thread.Sleep(5000);
            driver.SwitchTo().DefaultContent();
            this.SaveButton.Click();
        }
    }
}