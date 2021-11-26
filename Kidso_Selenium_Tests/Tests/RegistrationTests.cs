using NUnit.Framework;
using System;

namespace Kidso_Selenium_Tests.Tests
{
    public class RegistrationTests : BaseTest
    {
        [Test]
        public void Test_ViewRegistrationPage_Link()
        {
            var viewLoginPage = new RegistrationPage(driver);

            viewLoginPage.Open();
            viewLoginPage.LinkRegistrationPage.Click();

            Assert.IsTrue(new RegistrationPage(driver).IsOpen());


        }

        [Test]
        public void Test_ValidRegistration()
        {
            var page = new RegistrationPage(driver);
            page.Open();

            string firstName = "Test" + DateTime.Now.Ticks;
            string lastName = "Testov" + DateTime.Now.Ticks;
            string email = "atest" + DateTime.Now.Ticks + "@gmail.com";
            string password = "Password1";
            string kidname = "TestKid";

            page.AddUser(firstName, lastName, email, password, kidname);

            Assert.IsTrue(new RegistrationPage(driver).IsOpen());
            //var LoginPage = new ViewStudentsPage(driver);
            //Assert.IsTrue(viewStudentsPage.IsOpen());
            //var students = viewStudentsPage.GetRegisteredStudents();
            //string newStudent = firstName + lastName + "(" + email + ")";
            //Assert.Contains(newStudent, students);
        }
    }
}