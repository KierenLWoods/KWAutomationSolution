using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.BasicInputPage
{
   public class BasicInputPageElements
    {
        private readonly Driver _driver;
        public BasicInputPageElements(Driver driver)
        {
            _driver = driver;
        }
        public Element SubmitButton => _driver.FindElement(By.TagName("BUTTON"));
        public Element YesOption => _driver.FindElement(By.Id("r1"));
        public Element NoOption => _driver.FindElement(By.Id("r2"));
        public Element AgeField => _driver.FindElement(By.Id("n1"));
        public Element FruitField => _driver.FindElement(By.Id("t1"));
        public Element EmailField => _driver.FindElement(By.Id("t2"));
    }
}
