using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.ChallengingDom
{
    public class ChallengingDomElements
    {
        private readonly Driver _driver;
        public ChallengingDomElements(Driver driver)
        {
            _driver = driver;
        }

        public Element Table => _driver.FindElement(By.TagName("table"));
        public Element TableHeaders => Table.FindElement(By.TagName("thead"));
        public Element TableBody => Table.FindElement(By.TagName("tbody"));
        public List<Element> BodyTableRows => TableBody.FindElements(By.TagName("tr"));
    }
}
