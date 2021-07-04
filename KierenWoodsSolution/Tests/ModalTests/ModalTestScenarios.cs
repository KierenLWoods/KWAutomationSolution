using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KierenWoodsSolution.Tests.ModalTests
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
    public  class ModalTestScenarios:BaseTest
    {
        [TestMethod]
        public void ModalDialogTest()
        {
            _modalPage.GoToModalDialogPage();
            _modalPage.SelectSmallModalButton();
            _modalPage.CloseModalPopUp();
        }
    }
}
