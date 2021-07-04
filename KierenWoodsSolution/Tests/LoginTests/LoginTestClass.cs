using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KierenWoodsSolution.Tests.LoginTests
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
    public  class LoginTestClass:BaseTest
    {
        [TestMethod]
        public void LoginTest()
        {
            _loginPage.LoginToApplication("admin", "bluebird");
           Assert.IsTrue(_landingPage.Assertions.CheckLogOutButtonIsVisible());
        }

        [TestMethod]
        public void TestToCheckUserAbleToLogOutAndNotGainAccessToLandingPageWithoutLoggingIn()
        {
            _loginPage.LoginToApplication("admin", "bluebird");
            _landingPage.SelectLogOutButton();
            _landingPage.GoToLandingPage();
            Assert.IsTrue(_loginPage.Assertions.CheckAlertIconPresentAndContainsExpectedText("You must login to view the secure area!"), "The expected message was not present");
        }
    }
}
