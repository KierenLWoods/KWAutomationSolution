using OpenQA.Selenium;
using System.Collections.Generic;

namespace KierenWoodsSolution.ElementsAndDecorators
{
    public abstract class Element
    {
        public abstract By By { get; }
        public abstract string Text { get; }
        public abstract bool? Enabled { get; }
        public abstract bool? Displayed { get; }
        public abstract void TypeText(string text);
        public abstract Element FindElement(By locator);
        public abstract List<Element> FindElements(By locator);
        public abstract void Click();
        public abstract string GetAttribute(string attributeName);
        public abstract string GetCssValue(string cssValue);
        public abstract void WaitToExists();
        public abstract void WaitUntilAttributeContains(string attribute, string contents);
       public abstract void WaitUntilNotVisible();
        public abstract void HoverOverElement();
        public abstract void DragAndDropElement(string toLocationID);
    }
}
