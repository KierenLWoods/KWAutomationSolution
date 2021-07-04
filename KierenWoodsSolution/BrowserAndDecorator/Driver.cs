using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace KierenWoodsSolution.BrowserAndDecorator
{
    public abstract  class Driver
    {
        public abstract Uri Url { get; }
        public abstract void Start(Browser browser);

        public abstract void Maximise();
        public abstract void Quit();
        public abstract void RefreshPage();
        public abstract void GoToUrl(string url);
        public abstract string GetURL();
        public abstract Element FindElement(By locator);
        public abstract List<Element> FindElements(By locator);
        public abstract void WaitForAjax();
        public abstract void WaitUntilPageLoadsCompletely();
        public abstract void AcceptPopUp();
        public abstract void TakeScreenshot(string testName, string date);
    }
}
