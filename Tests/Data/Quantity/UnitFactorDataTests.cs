using Abc.Data.Common;
using Abc.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Quantity
{
    [TestClass]
    public class UnitFactorDataTests : SealedClassTest<UnitFactorData, PeriodData>
    {

        [TestMethod]
        public void FactorTest()
        {
            isProperty(() => obj.Factor, x => obj.Factor = x);
        }


        [TestMethod]
        public void SystemOfUnitsIdTest()
        {
            isNunllableProperty(() => obj.SystemOfUnitsID, x => obj.SystemOfUnitsID = x);
        }


        [TestMethod]
        public void UnitIdTest()
        {
            isNunllableProperty(() => obj.UnitID, x => obj.UnitID = x);
        }
    }
}