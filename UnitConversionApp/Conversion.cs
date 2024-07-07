using System.Collections.Generic;
using System.Xml.Linq;

namespace UnitConversionApp
{
    public class Conversion
    {
        //        { "Foot (ft)|Millimeter (mm)", 304.8 },
        //{ "Foot (ft)|Centimeter (cm)", 30.48 },
        //{ "Foot (ft)|Decimeter (dm)", 3.048 },
        //{ "Foot (ft)|Meter (m)", 0.3048 },
        //{ "Foot (ft)|Dekameter (dam)", 0.03048 },
        //{ "Foot (ft)|Hectometer (hm)", 0.003048 },
        //{ "Foot (ft)|Kilometer (km)", 0.0003048 },
        //{ "Foot (ft)|Inch (in)", 12 },
        //{ "Foot (ft)|Foot (ft)", 1 },
        //{ "Foot (ft)|Yard (yd)", 0.333333 },
        //{ "Foot (ft)|Mile (mi)", 0.000189394 },
        //{ "Foot (ft)|Micrometer (µm)", 304800 },
        //{ "Foot (ft)|Nanometer (nm)", 3.048E+8 },
        Dictionary<string, string> measurementShortForm;
        //public double ValueFrom { get; set; }
        //public double ValueTo { get; set; }
        public string ConversionFrom { get; set; }
        public string ConversionTo { get; set; }
        public double conversionFactor { get; set; }

        public Conversion(double conversionFactor, string conversionFrom, string conversionTo)
        {
            this.conversionFactor = conversionFactor;
            ConversionFrom = conversionFrom;
            ConversionTo = conversionTo;
            measurementShortForm = new Dictionary<string, string>();
            InitializeDict();
        }

        private void InitializeDict()
        {
            measurementShortForm.Add("Millimeter (mm)", "mm");
            measurementShortForm.Add("Centimeter (cm)", "cm");
            measurementShortForm.Add("Decimeter (dm)", "dm");
            measurementShortForm.Add("Meter (m)", "m");
            measurementShortForm.Add("Dekameter (dam)", "dam");
            measurementShortForm.Add("Hectometer (hm)", "hm");
            measurementShortForm.Add("Kilometer (km)", "km");
            measurementShortForm.Add("Inch (in)", "in");
            measurementShortForm.Add("Foot (ft)", "ft");
            measurementShortForm.Add("Yard (yd)", "yd");
            measurementShortForm.Add("Mile (mi)", "mi");
            measurementShortForm.Add("Micrometer (µm)", "µm");
            measurementShortForm.Add("Nanometer (nm)", "nm");
        }

        public override string ToString()
        {
            return string.Format("1 {0} -> {1} {2}",
                measurementShortForm[ConversionFrom],
                conversionFactor,
                measurementShortForm[ConversionTo]);
        }
    }
}