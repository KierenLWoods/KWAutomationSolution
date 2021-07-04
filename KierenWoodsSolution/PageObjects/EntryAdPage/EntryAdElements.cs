using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.EntryAdPage
{
   public class EntryAdElements
    {
        private readonly Driver _driver;
        public EntryAdElements(Driver driver)
        {
            _driver = driver;
        }
        public Element ModalWindow => _driver.FindElement(By.Id("modal"));
        public Element ModalClose => _driver.FindElement(By.XPath("//*[@id='modal']/div[2]/div[3]/p"));
        public Element DropDownListMenu => _driver.FindElement(By.Id("dropdown"));
    }
}
