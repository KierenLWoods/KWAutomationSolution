using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KierenWoodsSolution.ElementsAndDecorators
{
    public class WebElement:Element
    {
        private readonly IWebDriver _webDriver;
        private readonly IWebElement _webElement;        
        private readonly By _by;

        public WebElement(IWebDriver webDriver, IWebElement webElement, By by)
        {
            _webDriver = webDriver;
            _webElement = webElement;
            _by = by;
        }

        public override By By => _by;

        public override string Text => _webElement?.Text;

        public override bool? Enabled => _webElement?.Enabled;

        public override bool? Displayed => _webElement?.Displayed;

        public override void Click()
        {
            WaitToExists();
            _webElement?.Click();
        }   

        public override Element FindElement(By locator)
        {
            return new WebElement(_webDriver, _webElement?.FindElement(locator), locator);

        }

        public override string GetAttribute(string attributeName)
        {
            return _webElement?.GetAttribute(attributeName);
        }
        public override string GetCssValue(string cssValue)
        {
            return _webElement?.GetCssValue(cssValue);
        }

        public override void TypeText(string text)
        {
            WaitToExists();
            _webElement?.Clear();
            _webElement?.SendKeys(text);
        }

        public override void WaitToExists()
        {
            var webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(90));
            webDriverWait.Until(ExpectedConditions.ElementExists(By));
        }

        public override void WaitUntilNotVisible()
        {
            var webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(90));
            webDriverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By));
        }

        private void WaitToBeClickable()
        {
            var webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(60));
            WaitToExists();
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(By));
        }

        public override void WaitUntilAttributeContains(string attribute, string contents)
        {
            var webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(90));
            webDriverWait.Until(d => _webElement.GetAttribute(attribute).Contains(contents));
        }
        public override void HoverOverElement()
        {
            Actions actions = new Actions(_webDriver);
            actions.MoveToElement(_webElement).Perform();
        }
        public override void DragAndDropElement(string ToLocationID)
        {
          
            IWebElement toLocation = _webDriver.FindElement(By.Id(ToLocationID));
            Actions actions = new Actions(_webDriver);
            actions.DragAndDrop(_webElement, toLocation).Build().Perform();
        }

        public override List<Element> FindElements(By locator)
        {
            
            ReadOnlyCollection<IWebElement> nativeWebElements = _webElement?.FindElements(locator);
            var elements = new List<Element>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                Element element = new WebElement(_webDriver, nativeWebElement, locator);
                elements.Add(element);
            }

            return elements;
        }
    }
}
