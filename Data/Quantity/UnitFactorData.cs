using Abc.Data.Common;

namespace Abc.Data.Quantity
{
    public sealed class UnitFactorData : PeriodData
    {
        public string UnitID { get; set; }
        public string SystemOfUnitsID { get; set; }
        public double Factor { get; set; }
    }
}
