using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.LandingPage
{
   public class LandingPageAssertions
    {
        private readonly LandingPageElements _elements;
        public LandingPageAssertions(LandingPageElements pageElements)
        {
            _elements = pageElements;
        }

        public bool CheckLogOutButtonIsVisible()
        {
            if(_elements.LogOutButton.Enabled == true)
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
