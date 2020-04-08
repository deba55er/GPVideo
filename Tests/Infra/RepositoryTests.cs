using System;
using Abc.Aids;
using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra
{
    [TestClass]
    public abstract class RepositoryTests<TRepository, TObject, TData> : BaseTests
        where TRepository : IRepository<TObject>
        where TObject : Entity<TData>
        where TData : PeriodData, new()
    {
        private TData data;
        protected TRepository obj;


        public virtual void TestInitialize()
        {
            type = typeof(TRepository);
            data = GetRandom.Object<TData>();
        }


        [TestMethod]
        public void IsSealed() => Assert.IsTrue(type.IsSealed);

        [TestMethod]
        public void IsInherited() => Assert.AreEqual(GetBaseType().Name, type?.BaseType?.Name);
        
        protected abstract Type GetBaseType();


        [TestMethod]
        public void GetTest() => TestGetList();
        

        protected abstract void TestGetList();

        [TestMethod]
        public void GetByIdTest() => AddTest();
        

        [TestMethod]
        public void DeleteTest()
        {
            AddTest();
            var id = GetId(data);

            var expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);

            obj.Delete(id).GetAwaiter();
            expected = obj.Get(id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);

        }

        protected abstract string GetId(TData d);

        [TestMethod]
        public void AddTest()
        {
            var id = GetId(data);
            var expected = obj.Get(id).GetAwaiter().GetResult();
            Assert.IsNotNull(expected);
            Assert.IsNull(expected.Data);
            obj.Add(GetObject(data)).GetAwaiter();
            expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
        }

        protected abstract TObject GetObject(TData d);

        [TestMethod]
        public void UpdateTest()
        {
            AddTest();
            var id = GetId(data);
            var newData = GetRandom.Object<TData>();
            SetId(newData, id);
            obj.Update(GetObject(newData)).GetAwaiter();

            var expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(newData, expected.Data);
        }

        protected abstract void SetId(TData d, string id);

    }

}