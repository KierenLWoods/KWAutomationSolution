using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KierenWoodsSolution.PracticeFormTests
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
    public class PractiseFormScenarios:BaseTest
    {
        [TestMethod]
        public void ValidFormSubmittion()
        {
            _practiceFormPage.GotoPracticeFormPage();
            _practiceFormPage.PopulateMandatoryFields("first", "last", "male", "1234567891");
            Assert.IsTrue(_practiceFormPage.Assertions.CheckModalPopUpIsDisplayed());
        }

        [TestMethod]
        public void CheckFormValidation()
        {
            _practiceFormPage.GotoPracticeFormPage();
            _practiceFormPage.SelectSubmitButton();
            Assert.IsTrue(_practiceFormPage.Assertions.CheckMandatoryFieldValidation(_practiceFormPage.ReturnMandatoryElements()));

        }
    }
}
