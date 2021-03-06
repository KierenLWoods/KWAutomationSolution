using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace KierenWoodsSolution.BaseInfrastructure
{
    public class BaseTestBehaviorObserver : ITestBehaviorObserver
    {
        private readonly ITestExecutionSubject _testExecutionSubject;

        public BaseTestBehaviorObserver(ITestExecutionSubject testExecutionSubject)
        {
            _testExecutionSubject = testExecutionSubject;
            testExecutionSubject.Attach(this);
        }

        public virtual void PreTestInit(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void PostTestInit(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void PreTestCleanup(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void PostTestCleanup(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void TestInstantiated(MemberInfo memberInfo)
        {
        }
    }
}
