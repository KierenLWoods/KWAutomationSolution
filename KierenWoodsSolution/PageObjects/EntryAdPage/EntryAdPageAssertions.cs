using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.EntryAdPage
{
   public class EntryAdPageAssertions
    {
        private readonly EntryAdElements _elements;
        public EntryAdPageAssertions(EntryAdElements pageElements)
        {
            _elements = pageElements;
        }
        public bool CheckModalWindowIsPresent()
        {
            _elements.ModalWindow.WaitUntilAttributeContains("style", "display: block;");
            if (_elements.ModalClose.Displayed == true)
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
