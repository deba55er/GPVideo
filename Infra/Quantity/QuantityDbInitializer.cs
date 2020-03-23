using System.Collections.Generic;
using System.Linq;
using Abc.Data.Quantity;

namespace Abc.Infra.Quantity
{
    public static class QuantityDbInitializer
    {

        internal static MeasureData time = new MeasureData
        {
            Id = "Time",
            Name = "Time",
            Code = "t",
            Definition = "In physical science, time is defined as a measurement, " +
                         "or as what the clock face reads."
        };
        internal static MeasureData length = new MeasureData
        {
            Id = "Length",
            Name = "Length",
            Code = "l",
            Definition = "The measurement or extent of something from end to end."
        };
        internal static MeasureData mass = new MeasureData
        {
            Id = "Mass",
            Name = "Mass",
            Code = "m",
            Definition = "The quantity of matter which a body contains, as measured by " +
                         "its acceleration under a given force or by the force exerted on " +
                         "it by a gravitational field"
        };
        internal static MeasureData current = new MeasureData
        {
            Id = "Current",
            Name = "Electric Current",
            Code = "I",
            Definition = "An electric current is the rate of flow of electric charge " +
                         "past a point or region. An electric current is said to exist " +
                         "when there is a net flow of electric charge through a region." +
                         "In electric circuits this charge is often carried by electrons " +
                         "moving through a wire. It can also be carried by ions in an " +
                         "electrolyte, or by both ions and electrons such as in an " +
                         "ionized gas (plasma)"
        };
        internal static MeasureData temperature = new MeasureData
        {
            Id = "Temperature",
            Name = "Thermodynamic Temperature",
            Code = "T",
            Definition = "Thermodynamic temperature is the absolute measure of temperature " +
                         "and is one of the principal parameters of thermodynamics."
        };
        internal static MeasureData substance = new MeasureData
        {
            Id = "Substance",
            Name = "Amount of Substance",
            Code = "n",
            Definition = "In chemistry, the amount of substance in a given " +
                         "sample of matter is the number of discrete atomic-scale " +
                         "particles in it; where the particles may be molecules, " +
                         "atoms, ions, electrons, or other, depending on the context. " +
                         "It is sometimes referred to as the chemical amount."
        };
        internal static MeasureData luminous = new MeasureData
        {
            Id = "Luminous",
            Name = "Luminous Intensity",
            Code = "Iv",
            Definition = "In photometry, luminous intensity is a measure of the " +
                         "wavelength-weighted power emitted by a light source in a " +
                         "particular direction per unit solid angle, based on the " +
                         "luminosity function, a standardized model of the sensitivity " +
                         "of the human eye"
        };

        internal static List<MeasureData> Measures => new List<MeasureData> {
            time, length, mass, current,temperature,substance,luminous
        };

        public const string NanosecondsName = "Nanoseconds";
        public const string MicrosecondsName = "Microseconds";
        public const string MillisecondsName = "Milliseconds";
        public const string SecondsName = "Seconds";
        public const string MinutesName = "Minutes";
        public const string HoursName = "Hours";
        public const string DaysName = "Days";
        public const string WeeksName = "Weeks";
        public const string FortnightsName = "Fortnights";
        public const string MonthsName = "Months";
        public const string YearsName = "Years";
        public const string DecadesName = "Decades";
        public const string CenturiesName = "Centuries";
        public const string MillenniumName = "Millennium";

        internal static List<UnitData> TimeUnits => new List<UnitData> {
            CreateUnitData(time.Id, CenturiesName),
            CreateUnitData(time.Id, DecadesName),
            CreateUnitData(time.Id, DaysName),
            CreateUnitData(time.Id, FortnightsName),
            CreateUnitData(time.Id, HoursName, null, "h"),
            CreateUnitData(time.Id, MicrosecondsName),
            CreateUnitData(time.Id, MillenniumName),
            CreateUnitData(time.Id, MillisecondsName),
            CreateUnitData(time.Id, MinutesName, null, "min"),
            CreateUnitData(time.Id, MonthsName),
            CreateUnitData(time.Id, NanosecondsName),
            CreateUnitData(time.Id, SecondsName, null,  "sec"),
            CreateUnitData(time.Id, WeeksName),
            CreateUnitData(time.Id, YearsName)
        };

        public const string AstronomicalUnitsName = "AstronomicalUnits";
        public const string AngstromsName = "Angstroms";
        public const string CentimetersName = "Centimeters";
        public const string ChainsName = "Chains";
        public const string CubitsName = "Cubits";
        public const string DecametersName = "Decameters";
        public const string DecimetersName = "Decimeters";
        public const string FeetName = "Feet";
        public const string FathomsName = "Fathoms";
        public const string FurlongsName = "Furlongs";
        public const string GigametersName = "Gigameters";
        public const string HandsName = "Hands";
        public const string HectometersName = "Hectometers";
        public const string InchesName = "Inches";
        public const string KilometersName = "Kilometers";
        public const string LightYearsName = "LightYears";
        public const string LightSecondsName = "LightSeconds";
        public const string LinksName = "Links";
        public const string MetersName = "Meters";
        public const string MicromicronsName = "Micromicrons";
        public const string MegametersName = "Megameters";
        public const string MicronsName = "Microns";
        public const string MilesName = "Miles";
        public const string MillimetersName = "Millimeters";
        public const string MillimicronsName = "Millimicrons";
        public const string NanometersName = "Nanometers";
        public const string NauticalMilesName = "NauticalMiles";
        public const string PacesName = "Paces";
        public const string ParsecsName = "Parsecs";
        public const string PicasName = "Picas";
        public const string PointsName = "Points";
        public const string RodsName = "Rods";
        public const string YardsName = "Yards";
        internal static List<UnitData> LenghtUnits => new List<UnitData>();
        public const string CentigramsName = "Centigrams";
        public const string DecagramsName = "Decagrams";
        public const string DecigramsName = "Decigrams";
        public const string DramsName = "Drams";
        public const string GrainsName = "Grains";
        public const string GramsName = "Grams";
        public const string HectogramsName = "Hectograms";
        public const string KilogramsName = "Kilograms";
        public const string LongTonsName = "LongTons";
        public const string MetricTonsName = "MetricTons";
        public const string MicrogramsName = "Micrograms";
        public const string MilligramsName = "Milligrams";
        public const string NanogramsName = "Nanograms";
        public const string OuncesName = "Ounces";
        public const string PoundsName = "Pounds";
        public const string StonesName = "Stones";
        public const string TonsName = "Tons";
        internal static List<UnitData> MassUnits => new List<UnitData> {
            CreateUnitData(mass.Id, DecagramsName),
            CreateUnitData(mass.Id, DecigramsName),
            CreateUnitData(mass.Id, DramsName),
            CreateUnitData(mass.Id, GrainsName),
            CreateUnitData(mass.Id, GramsName, null, "g"),
            CreateUnitData(mass.Id, HectogramsName),
            CreateUnitData(mass.Id, KilogramsName, null, "kg"),
            CreateUnitData(mass.Id, LongTonsName),
            CreateUnitData(mass.Id, MetricTonsName, null, "T"),
            CreateUnitData(mass.Id, MicrogramsName),
            CreateUnitData(mass.Id, MilligramsName),
            CreateUnitData(mass.Id, NanogramsName),
            CreateUnitData(mass.Id, OuncesName),
            CreateUnitData(mass.Id, PoundsName),
            CreateUnitData(mass.Id, StonesName),
            CreateUnitData(mass.Id, TonsName)
        };
        internal static List<UnitData> CurrentUnits => new List<UnitData>();
        public const string CelsiusName = "Celsius";
        public const string FahrenheitName = "Fahrenheit";
        public const string KelvinName = "Kelvin";
        public const string RankineName = "Rankine";
        internal static List<UnitData> TemperatureUnits => new List<UnitData> {
            CreateUnitData(temperature.Id, CelsiusName,  null, "°C"),
            CreateUnitData(temperature.Id, FahrenheitName,  null, "°F"),
            CreateUnitData(temperature.Id, KelvinName,  null, "K"),
            CreateUnitData(temperature.Id, RankineName,  null, "°R")
        };

        private static UnitData CreateUnitData(string measureId, string id, string name = null, string code = null)
        {
            return new UnitData
            {
                Id = id,
                MeasureId = measureId,
                Name = name ?? id,
                Code = code
            };
        }

        internal static List<UnitData> SubstanceUnits => new List<UnitData>();
        internal static List<UnitData> LuminousUnits => new List<UnitData>();

        public static void Initialize(QuantityDbContext db)
        {
            InitializeMeasures(db);
            InitializeUnits(db);
        }

        private static void InitializeUnits(QuantityDbContext db)
        {
            if (db.Units.Count() != 0) return;
            db.Units.AddRange(TimeUnits);
            db.Units.AddRange(LenghtUnits);
            db.Units.AddRange(MassUnits);
            db.Units.AddRange(TemperatureUnits);
            db.Units.AddRange(SubstanceUnits);
            db.Units.AddRange(LuminousUnits);
            db.Units.AddRange(CurrentUnits);
            db.SaveChanges();
        }

        private static void InitializeMeasures(QuantityDbContext db)
        {
            if (db.Measures.Count() != 0) return;
            db.Measures.AddRange(Measures);
            db.SaveChanges();
        }

    }
}
