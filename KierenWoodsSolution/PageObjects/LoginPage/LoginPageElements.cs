using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.LoginPage
{
    public class LoginPageElements
    {
        private readonly Driver _driver;
        public LoginPageElements(Driver driver)
        {
            _driver = driver;
        }
        public Element UsernameField => _driver.FindElement(By.Id("username"));
        public Element PasswordField => _driver.FindElement(By.Id("password"));
        public Element LoginButton => _driver.FindElement(By.ClassName("radius"));
        public Element AlertIcon => _driver.FindElement(By.Id("flash"));
    }
}
