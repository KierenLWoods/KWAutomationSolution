using KierenWoodsSolution.BrowserAndDecorator;
using System;

namespace KierenWoodsSolution.BaseInfrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class ExecutionBrowserAttribute : Attribute
    {
        public ExecutionBrowserAttribute(Browser browser)
        {
            BrowserConfiguration = new BrowserConfiguration(browser);
        }

        public BrowserConfiguration BrowserConfiguration { get; set; }
    }
}
