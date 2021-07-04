using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.Tests.BasicInput
{

    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
    public class BasicInputTestScenarios:BaseTest
    {
        [TestMethod]
        public void BasicFormInputSubmissionTest()
        {
            _loginPage.LoginToApplication("admin", "bluebird");
            _landingPage.SelectTaskToBeAutomatedMenuOption("Input");
            _basicInputPage.ClickSubmitButton();
            Assert.IsTrue(_basicInputPage.Assertions.CheckURL("http://51.145.101.201:443/inputs"),$"The current url does not match the expected URL");
            _basicInputPage.PopulateForm("Yes","25","Banana","Test");
            Assert.IsTrue(_basicInputPage.Assertions.CheckURL("http://51.145.101.201:443/inputs"), $"The current url does not match the expected URL");
            Assert.IsTrue(_basicInputPage.Assertions.CheckEmailValidation("Please include an '@' in the email address. 'Test' is missing an '@'."));
            _basicInputPage.PopulateEmailField("Test@test.com");
            _basicInputPage.ClickSubmitButton();
            Assert.IsTrue(_basicInputPage.Assertions.CheckURL("http://51.145.101.201:443/inputs?driver=yes&age=25&fruit=Banana&email=Test%40test.com&msg="));
            Assert.IsTrue(_basicInputPage.Assertions.CheckFormIsClear());
        }
    }
}
