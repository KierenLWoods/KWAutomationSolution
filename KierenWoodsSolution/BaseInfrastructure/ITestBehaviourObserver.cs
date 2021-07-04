using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace KierenWoodsSolution.BaseInfrastructure
{
    public interface ITestBehaviorObserver
    {
        void PreTestInit(TestContext context, MemberInfo memberInfo);

        void PostTestInit(TestContext context, MemberInfo memberInfo);

        void PreTestCleanup(TestContext context, MemberInfo memberInfo);

        void PostTestCleanup(TestContext context, MemberInfo memberInfo);

        void TestInstantiated(MemberInfo memberInfo);
    }
}
