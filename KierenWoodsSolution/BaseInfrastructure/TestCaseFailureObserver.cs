using KierenWoodsSolution.BrowserAndDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace KierenWoodsSolution.BaseInfrastructure
{
    public class TestCaseFailureObserver : BaseTestBehaviorObserver
    {
        private readonly Driver _driver;
        public TestCaseFailureObserver(ITestExecutionSubject testExecutionSubject, Driver driver)
            : base(testExecutionSubject)
        {
            _driver = driver;
        }

        public override void PostTestCleanup(TestContext context, MemberInfo memberInfo)
        {
            if (context.CurrentTestOutcome.ToString() == "Failed")
            {
                var testoutcome = context.CurrentTestOutcome.ToString();
                string TestName = context.TestName.ToString();

                string baseDirectory = Directory.GetCurrentDirectory();
                string screenGrabs = Path.Combine(baseDirectory, $"{DateTime.Now:yyyy-MM-dd}");

                if (!Directory.Exists(baseDirectory))
                {
                    Directory.CreateDirectory(baseDirectory);
                }

                if (!Directory.Exists(screenGrabs))
                {
                    Directory.CreateDirectory(screenGrabs);
                }


                //Create these folders if not present
                string filename = Path.Combine(screenGrabs, $"{TestName}-{DateTime.Now:yyyy-MM-dd_hh-mm-ss-tt}.png");
                _driver.TakeScreenshot(filename, TestName);
                try
                {
                    if (!string.IsNullOrEmpty(filename))
                    {
                        context.AddResultFile(filename);
                    }
                }
                catch (Exception)
                {
                    //i dont want to stop test because it cant find the screenshot
                }
                

            }

        }
    }
}
