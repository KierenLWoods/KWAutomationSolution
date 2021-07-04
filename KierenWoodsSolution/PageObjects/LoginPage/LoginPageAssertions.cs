using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.LoginPage
{
  public class LoginPageAssertions
    {
        private readonly LoginPageElements _elements;
        public LoginPageAssertions(LoginPageElements pageElements)
        {
            _elements = pageElements;
        }

        public bool CheckAlertIconPresentAndContainsExpectedText(string expectedAlertMessage)
        {
            if (_elements.AlertIcon.GetAttribute("innerText").Contains(expectedAlertMessage))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
