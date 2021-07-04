using KierenWoodsSolution.BrowserAndDecorator;

namespace KierenWoodsSolution.BaseInfrastructure
{
    public class BrowserConfiguration
    {
        public BrowserConfiguration()
        {
            Browser = Browser.NotSet;
            
        }

        public BrowserConfiguration(Browser browser)
        {
            Browser = browser;
            
        }

        public Browser Browser { get; set; }
       
    }
}
