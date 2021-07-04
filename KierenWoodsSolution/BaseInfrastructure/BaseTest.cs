using KierenWoodsSolution.BrowserAndDecorator;
using KierenWoodsSolution.PageObjects.BasicInputPage;
using KierenWoodsSolution.PageObjects.ChallengingDom;
using KierenWoodsSolution.PageObjects.EntryAdPage;
using KierenWoodsSolution.PageObjects.LandingPage;
using KierenWoodsSolution.PageObjects.LoginPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
[assembly: Parallelize(Workers = 50, Scope = ExecutionScope.MethodLevel)]
namespace KierenWoodsSolution.BaseInfrastructure
{
    public class BaseTest
    {
        public static string _baseUrl;
        private readonly Driver webDriver;
        public LoginPage _loginPage;
        public LandingPageExecution _landingPage;
        public ChallengingDomExecution _challengingDOM;
        public EntryAdExecution _entryAdPage;
        public BasicInputPageExecution _basicInputPage;
        private readonly ITestExecutionSubject CurrentTestExecutionSubject;
        public TestContext TestContext { get; set; }

        public string TestName => TestContext.TestName;
        public BaseTest()
        {           
                       
            CurrentTestExecutionSubject = new MsTestExecutionSubject();
            webDriver = new WebDriver();
            new TestCaseFailureObserver(CurrentTestExecutionSubject, webDriver);
            new BrowserLaunchTestBehaviorObserver(CurrentTestExecutionSubject, webDriver);
            var memberInfo = MethodBase.GetCurrentMethod();
            CurrentTestExecutionSubject.TestInstantiated(memberInfo);
            _loginPage = new LoginPage(webDriver);
            _landingPage = new LandingPageExecution(webDriver);
            _challengingDOM = new ChallengingDomExecution(webDriver);
            _entryAdPage = new EntryAdExecution(webDriver);
            _basicInputPage = new BasicInputPageExecution(webDriver);
            
        }
        [TestInitialize]
        public void CoreTestInit()
        {
            var memberInfo = GetType().GetMethod(TestContext.TestName);
            CurrentTestExecutionSubject.PreTestInit(TestContext, memberInfo);
           
        }

        [TestCleanup]
        public void CoreTestCleanup()
        {
            var memberInfo = GetType().GetMethod(TestContext.TestName);
            CurrentTestExecutionSubject.PostTestCleanup(TestContext, memberInfo);
            webDriver.Quit();
            
        }
    }
}
