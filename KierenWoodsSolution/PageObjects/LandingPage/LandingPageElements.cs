using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.LandingPage
{
   public class LandingPageElements
    {
        private readonly Driver _driver;
        public LandingPageElements(Driver driver)
        {
            _driver = driver;
        }

        public Element LogOutButton => _driver.FindElement(By.XPath("//*[@href='/logout']"));
        public Element TaskOptionList => _driver.FindElement(By.TagName("ul"));

    }
}
