using Abc.Data.Common;
using Abc.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Quantity
{
    [TestClass]
    public class UnitFactorDataTests : SealedClassTest<UnitFactorData, PeriodData>
    {

        [TestMethod]
        public void FactorTest()
        {
            IsProperty(() => obj.Factor, x => obj.Factor = x);
        }


        [TestMethod]
        public void SystemOfUnitsIdTest()
        {
            IsNullableProperty(() => obj.SystemOfUnitsID, x => obj.SystemOfUnitsID = x);
        }


        [TestMethod]
        public void UnitIdTest()
        {
            IsNullableProperty(() => obj.UnitID, x => obj.UnitID = x);
        }
    }
}