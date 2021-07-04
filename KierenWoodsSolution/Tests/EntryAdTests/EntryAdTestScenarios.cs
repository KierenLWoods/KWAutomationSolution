using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.Tests.EntryAdTests
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
   public class EntryAdTestScenarios:BaseTest
    {
        [TestMethod]
        public void TestToCheckModalWindowPresentAndUserCanSelectValueFromDropDown()
        {
            _loginPage.LoginToApplication("admin", "bluebird");
            _landingPage.SelectTaskToBeAutomatedMenuOption("Entry Ad");
            Assert.IsTrue(_entryAdPage.Assertions.CheckModalWindowIsPresent());
            _entryAdPage.CloseTheModalWindow();
            _entryAdPage.SelectValueFromDropdown("Option 2");
        }
        
    }
}
