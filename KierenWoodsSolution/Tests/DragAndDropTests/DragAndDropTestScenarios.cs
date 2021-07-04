using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KierenWoodsSolution.Tests.DragAndDropTests
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
  public class DragAndDropTestScenarios:BaseTest
    {
        [TestMethod]
        public void DragAndDropTest()
        {
            _dropPage.GoToDropAndDropPage();
            _dropPage.DragAndDropItem();
        }
    }
}
