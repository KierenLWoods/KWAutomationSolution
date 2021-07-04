using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.Tests.Challenging_DOM
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
   public class ChallengingDOMTests:BaseTest
    {
        [TestMethod]
        public void CheckValuesInTableInTheChallengingDOMPage()
        {
            _loginPage.LoginToApplication("admin", "bluebird");
            _landingPage.SelectTaskToBeAutomatedMenuOption("Challenging DOM");
            _challengingDOM.GetCellValue("Sit",3);
            Assert.IsTrue(_challengingDOM.Assertions.CheckCellValue("Definiebas2"));
            _challengingDOM.GetCellValue("Amet", 7);
            Assert.IsTrue(_challengingDOM.Assertions.CheckCellValue("Consequuntur6"));
            _challengingDOM.GetCellValue("Amet", 8);
            Assert.IsTrue(_challengingDOM.Assertions.CheckCellValue("Consequuntur7"));

        }
    }
}
