using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KierenWoodsSolution.Tests.AlertsTest
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
    public class AlertScenario:BaseTest
    {
        [TestMethod]
        public void ClickOnTheSecondButtonAndAcceptTheAlert()
        {
            _alertsPage.GoToAlertsPage();
            _alertsPage.SelectOnButtonClickAlertWillAppearIn5SecondsAndAcceptPopUpMessage();
        }
    }
}
