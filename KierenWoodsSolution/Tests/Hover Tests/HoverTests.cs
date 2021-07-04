using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KierenWoodsSolution.Tests.Hover_Tests
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
    public class HoverTests:BaseTest
    {
        [TestMethod]
        public void HoverOverFields()
        {
            _hoverPage.GoToHoverPage();
            _hoverPage.HoverOverFields();
        }
    }
}
