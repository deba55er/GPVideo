using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public abstract class BaseTest<TClass, TBaseClass>
    {
        protected TClass obj;
        protected Type type;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = obj.GetType();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void IsInheritedTest()
        {
            Assert.AreEqual(typeof(TBaseClass), type.BaseType);
        }

    }
}