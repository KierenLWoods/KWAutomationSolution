using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.ChallengingDom
{
   public class ChallengingDomExecution
    {
        
        public ChallengingDomExecution(Driver driver)
        {
            Elements = new ChallengingDomElements(driver);
            Assertions = new ChallengingDomAssertions();
        }
        public static string CellValue;
        ChallengingDomElements Elements { get; }
        public ChallengingDomAssertions Assertions { get; }

        public void GetCellValue(string columnName, int columnNumber)
        {
            int columnValue = 0;
            var tr = Elements.TableHeaders.FindElement(By.TagName("tr"));
            foreach (var th in tr.FindElements(By.TagName("th")))
            {
                if (th.Text.Equals(columnName))
                {
                    columnValue++;
                    goto breakout;
                }
                else
                {
                    columnValue++;
                }
            }
        breakout:;
            List<Element> td = Elements.BodyTableRows[columnNumber-1].FindElements(By.TagName("td"));
            CellValue = td[columnValue-1].Text.ToString();
        }

    }
}
