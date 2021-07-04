using KierenWoodsSolution.BrowserAndDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.LoginPage
{
   public  class LoginPage
    {
        public LoginPage(Driver driver)
        {
            Elements = new LoginPageElements(driver);
            Assertions = new LoginPageAssertions(Elements);
        }
        LoginPageElements Elements { get; set; }
        public LoginPageAssertions Assertions { get; }
        public void LoginToApplication(string username,string password)
        {
            this.PopulateUserNameField(username);
            this.PopulatePasswordField(password);
            this.SelectSigninButton();
        }

        public void PopulateUserNameField(string username)
        {
            Elements.UsernameField.TypeText(username);
        }
        public void PopulatePasswordField(string password)
        {
            Elements.PasswordField.TypeText(password);
        }

        public void SelectSigninButton()
        {
            Elements.LoginButton.Click();
        }

    }
}
