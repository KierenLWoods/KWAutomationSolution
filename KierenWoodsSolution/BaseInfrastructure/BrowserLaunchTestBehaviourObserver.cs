using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace KierenWoodsSolution.BaseInfrastructure
{
    public class BrowserLaunchTestBehaviorObserver : BaseTestBehaviorObserver
    {
        private readonly Driver _driver;
        private BrowserConfiguration _currentBrowserConfiguration;
        

        public BrowserLaunchTestBehaviorObserver(ITestExecutionSubject testExecutionSubject, Driver driver)
            : base(testExecutionSubject)
        {
            _driver = driver;
        }
        public override void PreTestInit(TestContext context, MemberInfo memberInfo)
        {
            _currentBrowserConfiguration = GetBrowserConfiguration(memberInfo);
            _driver.Start(_currentBrowserConfiguration.Browser);
            _driver.Maximise();
            _driver.GoToUrl("http://51.145.101.201:443/");

        }
        private BrowserConfiguration GetBrowserConfiguration(MemberInfo memberInfo)
        {
            var result = new BrowserConfiguration();
            var classBrowserType = GetExecutionBrowserClassLevel(memberInfo.DeclaringType);
            var methodBrowserType = GetExecutionBrowserMethodLevel(memberInfo);
            if (methodBrowserType != null)
            {
                result = methodBrowserType;
            }
            else if (classBrowserType != null)
            {
                result = classBrowserType;
            }

            return result;
        }

        private BrowserConfiguration GetExecutionBrowserMethodLevel(MemberInfo memberInfo)
        {
            var executionBrowserAttribute = memberInfo.GetCustomAttribute<ExecutionBrowserAttribute>(true);
            return executionBrowserAttribute?.BrowserConfiguration;
        }

        private BrowserConfiguration GetExecutionBrowserClassLevel(Type type)
        {
            var executionBrowserAttribute = type.GetCustomAttribute<ExecutionBrowserAttribute>(true);
            return executionBrowserAttribute?.BrowserConfiguration;
        }
    }
}
