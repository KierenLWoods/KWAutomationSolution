using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;


namespace KierenWoodsSolution.HelperMethods
{
    public static class HelperClass
    {
        public static Driver _driver;
                
        public static string MonthPlusOne{get;set;}
        public static string Day { get; set; }
        public static string Year { get; set; }
        public static string MonthAndDay { get; set; }
        
        public static void GetDatePlusOneMonth()
        {
            DateTime now = DateTime.Now;
            MonthPlusOne = now.AddMonths(1).ToString("MMMM");
            Day = now.AddMonths(1).ToString("d");
            Year = now.AddMonths(1).ToString("yyyy");
            MonthAndDay = now.AddMonths(1).ToString("dddd"+", "+"MMMM"+" "+"d");

        }

        internal static void SelectValueFromDropdown(Element dropDownID, string valueToSelect)
        {
            foreach (var option in dropDownID.FindElements(By.TagName("option")))
            {
                if (option.Text.Contains(valueToSelect))
                {
                    option.Click();
                    break;
                }
            }
        }

        internal static void SelectDateFromGrid(Element table, string date)
        {
            foreach (var week in table.FindElements(By.TagName("div")))
            {
                if (week.GetAttribute("innerHTML").Contains(HelperClass.MonthAndDay))
                {
                    foreach (var day in week.FindElements(By.TagName("div")))
                    {
                        if (day.GetAttribute("aria-label").Contains(date))
                        {
                            day.Click();
                            goto exit;
                        }
                    }
                }
            }
        exit:;
        }

        public static void SelectListItemFromList(Element table,string itemToSelect)
        {
            foreach (var listItem in table.FindElements(By.TagName("li")))
            {
                if (listItem.GetAttribute("textContent").Contains(itemToSelect))
                {
                    listItem.FindElement(By.TagName("a")).Click();
                    break;
                }
            }
        }

        //public static void TakeScreenShot(TestContext context)
        //{
        //    string TestName = context.Test.Name.ToString();

        //    string baseDirectory = Directory.GetCurrentDirectory();
        //    string screenGrabs = Path.Combine(baseDirectory, $"{DateTime.Now:yyyy-MM-dd}");

        //    if (!Directory.Exists(baseDirectory))
        //    {
        //        Directory.CreateDirectory(baseDirectory);
        //    }

        //    if (!Directory.Exists(screenGrabs))
        //    {
        //        Directory.CreateDirectory(screenGrabs);
        //    }


        //    //Create these folders if not present
        //    string filename = Path.Combine(screenGrabs, $"{TestName}-{DateTime.Now:yyyy-MM-dd_hh-mm-ss-tt}.png");
        //    _driver.TakeScreenshot(filename, TestName);
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(filename))
        //        {
        //            TestContext.AddTestAttachment(filename);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        //i dont want to stop test because it cant find the screenshot
        //    }
        //}

    }
}
