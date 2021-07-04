using KierenWoodsSolution.BrowserAndDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.BasicInputPage
{
    public class BasicInputPageAssertions
    {
        private readonly BasicInputPageElements _elements;
        private readonly Driver _driver;
        public BasicInputPageAssertions(BasicInputPageElements pageElements,Driver driver)
        {
            _elements = pageElements;
            _driver = driver;
        }

        public bool CheckURL(string expectedURL)
        {
            if (expectedURL == _driver.GetURL())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckEmailValidation(string validationMessage)
        {
            if (_elements.EmailField.GetAttribute("validationMessage").Contains(validationMessage))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckFormIsClear()
        {
           
            bool formclear = false;
            if (_elements.YesOption.GetAttribute("checked") == null && _elements.NoOption.GetAttribute("checked") == null && _elements.AgeField.GetAttribute("textContent") == "" && _elements.FruitField.GetAttribute("textContent") == "" && _elements.EmailField.GetAttribute("textContent") == "")
            {
                formclear = true;
            }

            return formclear;
        }
    }
}
