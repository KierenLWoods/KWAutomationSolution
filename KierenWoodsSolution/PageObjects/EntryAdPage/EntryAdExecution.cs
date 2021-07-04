using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.EntryAdPage
{
   public class EntryAdExecution
    {
        public EntryAdExecution(Driver driver)
        {
            Elements = new EntryAdElements(driver);
            Assertions = new EntryAdPageAssertions(Elements);
        }
        EntryAdElements Elements { get; }
        public EntryAdPageAssertions Assertions { get; }
        public void CloseTheModalWindow()
        {
            Elements.ModalClose.Click();
        }
        public void SelectValueFromDropdown(string optionToSelect)
        {
            HelperClass.SelectValueFromDropdown(Elements.DropDownListMenu, optionToSelect);
        }
    }
}
