using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.LandingPage
{
    public class LandingPageExecution
    {
       readonly Driver _driver;
        public LandingPageExecution(Driver driver)
        {
            _driver = driver;
            Elements = new LandingPageElements(driver);
            Assertions = new LandingPageAssertions(Elements);
        }
        LandingPageElements Elements{ get; }
      public  LandingPageAssertions Assertions { get; }

        public void GoToLandingPage()
        {
            _driver.GoToUrl("http://51.145.101.201:443/secure");
        }
        public void SelectLogOutButton()
        {
            Elements.LogOutButton.Click();
        }

        public void SelectTaskToBeAutomatedMenuOption(string optionToSelect)
        {
            HelperClass.SelectListItemFromList(Elements.TaskOptionList,optionToSelect);
        }
    }
}
