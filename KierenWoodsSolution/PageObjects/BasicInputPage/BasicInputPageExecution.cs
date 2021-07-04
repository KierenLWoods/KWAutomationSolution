using KierenWoodsSolution.BrowserAndDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.BasicInputPage
{
   public class BasicInputPageExecution
    {
        public BasicInputPageExecution(Driver driver)
        {
            Elements = new BasicInputPageElements(driver);
            Assertions = new BasicInputPageAssertions(Elements, driver) ;
        }
        BasicInputPageElements Elements { get; }
        public BasicInputPageAssertions Assertions { get; }
        public void ClickSubmitButton()
        {
            Elements.SubmitButton.Click();
        }
        public void SelectDriverOrNot(string YesorNo)
        {
            switch (YesorNo)
            {
                case "Yes":
                    Elements.YesOption.Click();
                    break;
                case "No":
                    Elements.NoOption.Click();
                    break;
            }
        }
        public void PopulateAgeField(string age)
        {
            Elements.AgeField.TypeText(age);
        }
        public void PopulateFruitField(string fruit)
        {
            Elements.FruitField.TypeText(fruit);
        }
        public void PopulateEmailField(string email)
        {
            Elements.EmailField.TypeText(email);
        }

        public void PopulateForm(string YesOrNo,string age, string fruit,string email)
        {
            SelectDriverOrNot(YesOrNo);
            PopulateAgeField(age);
            PopulateFruitField(fruit);
            PopulateEmailField(email);
            ClickSubmitButton();
        }
       
    }
}
