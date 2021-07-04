using KierenWoodsSolution.ElementsAndDecorators;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KierenWoodsSolution.BrowserAndDecorator
{
    public class WebDriver:Driver
    {
        private IWebDriver _webDriver;        
        private WebDriverWait _webDriverWait;
        private WebDriverWait _quickWait;     

        public override Uri Url => new Uri(_webDriver.Url);

        public override void Start(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    var options = new ChromeOptions();
                    options.AddArguments(new List<string>()
                    {
                        "--headless",
                        "--no-sandbox",
                        "--window-size=1280,1920",
                        "--start-maximized",

                    });

                    _webDriver = new ChromeDriver(Environment.CurrentDirectory, options, TimeSpan.FromMinutes(3));

                    break;
                case Browser.Firefox:
                    _webDriver = new FirefoxDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Edge:
                    _webDriver = new EdgeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Opera:
                    _webDriver = new OperaDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Safari:
                    _webDriver = new SafariDriver(Environment.CurrentDirectory);
                    break;
                case Browser.InternetExplorer:
                    _webDriver = new InternetExplorerDriver(Environment.CurrentDirectory);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(60));

            _quickWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));            
        }

        public override void Quit()
        {
            _webDriver.Close();
            
        }

        public override void GoToUrl(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
            
        }

        public override void RefreshPage()
        {
            _webDriver.Navigate().Refresh();
        }

        public override Element FindElement(By locator)
        {
            IWebElement nativeWebElement =
                _webDriverWait.Until(ExpectedConditions.ElementExists(locator));
            Element element = new WebElement(_webDriver, nativeWebElement, locator);          
            return element;
        }

        public override List<Element> FindElements(By locator)
        {
            ReadOnlyCollection<IWebElement> nativeWebElements =
                _webDriverWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            var elements = new List<Element>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                Element element = new WebElement(_webDriver, nativeWebElement, locator);
                elements.Add(element);
            }

            return elements;
        }
       


        public override void WaitForAjax()
        {
            try
            {
                var js = (IJavaScriptExecutor)_webDriver;
                _quickWait.Until(wd => js.ExecuteScript("return jQuery.active").ToString() == "0");
                WaitUntilPageLoadsCompletely();
            }
            catch (Exception) { }
        }

        public override void WaitUntilPageLoadsCompletely()
        {
            var js = (IJavaScriptExecutor)_webDriver;
            _webDriverWait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }       

        public override void Maximise()
        {
            _webDriver.Manage().Window.Maximize();
        }

        public override void AcceptPopUp()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.AlertIsPresent());
            _webDriver.SwitchTo().Alert().Accept();

        }
        public override void TakeScreenshot(string filePath, string date)
        {
            Screenshot screenshot = ((ITakesScreenshot)_webDriver).GetScreenshot();
            screenshot.SaveAsFile(filePath, OpenQA.Selenium.ScreenshotImageFormat.Png);
        }
        public override string GetURL()
        {
           string url = _webDriver.Url.ToString();
            return url;
        }

    }
}
