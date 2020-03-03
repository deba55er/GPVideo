using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public abstract class BaseTest<TClass, TBaseClass> where TClass : new()
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new TClass());
        }

        [TestMethod]
        public void InheritedTest()
        {
            Assert.AreEqual(typeof(TBaseClass),
                new TClass().GetType().BaseType);
        }
    }
}