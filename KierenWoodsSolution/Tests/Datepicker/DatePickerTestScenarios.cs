using KierenWoodsSolution.BaseInfrastructure;
using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KierenWoodsSolution.Tests.Datepicker
{
    [TestClass]
    [ExecutionBrowser(Browser.Chrome)]
    public class DatePickerTestScenarios:BaseTest
    {
        [TestMethod]
        public void DatePickerTests()
        {
            _datePickerPage.GoToDatePickerPage();
            _datePickerPage.SelectDateField();
            _datePickerPage.SelectDateFromDatePicker();
        }
    }
}
