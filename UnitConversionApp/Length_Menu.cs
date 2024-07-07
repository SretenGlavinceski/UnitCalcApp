using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversionApp
{
    public partial class Length_Menu : UserControl
    {
        Dictionary<string, double> conversionFactors = new Dictionary<string, double>
            {
                 // Conversion factors for millimeter (mm)
    { "Millimeter (mm)|Millimeter (mm)", 1 },
    { "Millimeter (mm)|Centimeter (cm)", 0.1 },
    { "Millimeter (mm)|Decimeter (dm)", 0.01 },
    { "Millimeter (mm)|Meter (m)", 0.001 },
    { "Millimeter (mm)|Dekameter (dam)", 1.0 / 10000 },
    { "Millimeter (mm)|Hectometer (hm)", 1.0 / 100000 },
    { "Millimeter (mm)|Kilometer (km)", 1.0 / 1000000 },
    { "Millimeter (mm)|Inch (in)", 0.0393701 },
    { "Millimeter (mm)|Foot (ft)", 0.00328084 },
    { "Millimeter (mm)|Yard (yd)", 0.00109361 },
    { "Millimeter (mm)|Mile (mi)", 1.0 / 1609344 },
    { "Millimeter (mm)|Micrometer (µm)", 1000 },
    { "Millimeter (mm)|Nanometer (nm)", 1.0E+6 },

    // Conversion factors for centimeter (cm)
    { "Centimeter (cm)|Millimeter (mm)", 10 },
    { "Centimeter (cm)|Centimeter (cm)", 1 },
    { "Centimeter (cm)|Decimeter (dm)", 0.1 },
    { "Centimeter (cm)|Meter (m)", 0.01 },
    { "Centimeter (cm)|Dekameter (dam)", 1.0 / 100 },
    { "Centimeter (cm)|Hectometer (hm)", 1.0 / 1000 },
    { "Centimeter (cm)|Kilometer (km)", 1.0 / 10000 },
    { "Centimeter (cm)|Inch (in)", 0.393701 },
    { "Centimeter (cm)|Foot (ft)", 0.0328084 },
    { "Centimeter (cm)|Yard (yd)", 0.0109361 },
    { "Centimeter (cm)|Mile (mi)", 1.0 / 160934 },
    { "Centimeter (cm)|Micrometer (µm)", 10000 },
    { "Centimeter (cm)|Nanometer (nm)", 1.0E+7 },

    // Conversion factors for decimeter (dm)
    { "Decimeter (dm)|Millimeter (mm)", 100 },
    { "Decimeter (dm)|Centimeter (cm)", 10 },
    { "Decimeter (dm)|Decimeter (dm)", 1 },
    { "Decimeter (dm)|Meter (m)", 0.1 },
    { "Decimeter (dm)|Dekameter (dam)", 1.0 / 10 },
    { "Decimeter (dm)|Hectometer (hm)", 1.0 / 100 },
    { "Decimeter (dm)|Kilometer (km)", 1.0 / 1000 },
    { "Decimeter (dm)|Inch (in)", 3.93701 },
    { "Decimeter (dm)|Foot (ft)", 0.328084 },
    { "Decimeter (dm)|Yard (yd)", 0.109361 },
    { "Decimeter (dm)|Mile (mi)", 1.0 / 16093.4 },
    { "Decimeter (dm)|Micrometer (µm)", 100000 },
    { "Decimeter (dm)|Nanometer (nm)", 1.0E+8 },

    // Conversion factors for meter (m)
    { "Meter (m)|Millimeter (mm)", 1000 },
    { "Meter (m)|Centimeter (cm)", 100 },
    { "Meter (m)|Decimeter (dm)", 10 },
    { "Meter (m)|Meter (m)", 1 },
    { "Meter (m)|Dekameter (dam)", 0.1 },
    { "Meter (m)|Hectometer (hm)", 0.01 },
    { "Meter (m)|Kilometer (km)", 0.001 },
    { "Meter (m)|Inch (in)", 39.3701 },
    { "Meter (m)|Foot (ft)", 3.28084 },
    { "Meter (m)|Yard (yd)", 1.09361 },
    { "Meter (m)|Mile (mi)", 1.0 / 1609.34 },
    { "Meter (m)|Micrometer (µm)", 1.0E+6 },
    { "Meter (m)|Nanometer (nm)", 1.0E+9 },

    // Conversion factors for dekameter (dam)
    { "Dekameter (dam)|Millimeter (mm)", 10000 },
    { "Dekameter (dam)|Centimeter (cm)", 1000 },
    { "Dekameter (dam)|Decimeter (dm)", 100 },
    { "Dekameter (dam)|Meter (m)", 10 },
    { "Dekameter (dam)|Dekameter (dam)", 1 },
    { "Dekameter (dam)|Hectometer (hm)", 0.1 },
    { "Dekameter (dam)|Kilometer (km)", 0.01 },
    { "Dekameter (dam)|Inch (in)", 393.701 },
    { "Dekameter (dam)|Foot (ft)", 32.8084 },
    { "Dekameter (dam)|Yard (yd)", 10.9361 },
    { "Dekameter (dam)|Mile (mi)", 1.0 / 160.934 },
    { "Dekameter (dam)|Micrometer (µm)", 1.0E+7 },
    { "Dekameter (dam)|Nanometer (nm)", 1.0E+10 },

    // Conversion factors for hectometer (hm)
    { "Hectometer (hm)|Millimeter (mm)", 100000 },
    { "Hectometer (hm)|Centimeter (cm)", 10000 },
    { "Hectometer (hm)|Decimeter (dm)", 1000 },
    { "Hectometer (hm)|Meter (m)", 100 },
    { "Hectometer (hm)|Dekameter (dam)", 10 },
    { "Hectometer (hm)|Hectometer (hm)", 1 },
    { "Hectometer (hm)|Kilometer (km)", 0.1 },
    { "Hectometer (hm)|Inch (in)", 3937.01 },
    { "Hectometer (hm)|Foot (ft)", 328.084 },
    { "Hectometer (hm)|Yard (yd)", 109.361 },
    { "Hectometer (hm)|Mile (mi)", 1.0 / 16.0934 },
    { "Hectometer (hm)|Micrometer (µm)", 1.0E+8 },
    { "Hectometer (hm)|Nanometer (nm)", 1.0E+11 },

    // Conversion factors for kilometer (km)
    { "Kilometer (km)|Millimeter (mm)", 1.0E+6 },
    { "Kilometer (km)|Centimeter (cm)", 1.0E+5 },
    { "Kilometer (km)|Decimeter (dm)", 1.0E+4 },
    { "Kilometer (km)|Meter (m)", 1000 },
    { "Kilometer (km)|Dekameter (dam)", 100 },
    { "Kilometer (km)|Hectometer (hm)", 10 },
    { "Kilometer (km)|Kilometer (km)", 1 },
    { "Kilometer (km)|Inch (in)", 39370.1 },
    { "Kilometer (km)|Foot (ft)", 3280.84 },
    { "Kilometer (km)|Yard (yd)", 1093.61 },
    { "Kilometer (km)|Mile (mi)", 0.621371 },
    { "Kilometer (km)|Micrometer (µm)", 1.0E+9 },
    { "Kilometer (km)|Nanometer (nm)", 1.0E+12 },

    // Conversion factors for inch
    { "Inch (in)|Millimeter (mm)", 25.4 },
    { "Inch (in)|Centimeter (cm)", 2.54 },
    { "Inch (in)|Decimeter (dm)", 0.254 },
    { "Inch (in)|Meter (m)", 0.0254 },
    { "Inch (in)|Dekameter (dam)", 0.00254 },
    { "Inch (in)|Hectometer (hm)", 0.000254 },
    { "Inch (in)|Kilometer (km)", 2.54E-5 },
    { "Inch (in)|Inch (in)", 1 },
    { "Inch (in)|Foot (ft)", 0.0833333 },
    { "Inch (in)|Yard (yd)", 0.0277778 },
    { "Inch (in)|Mile (mi)", 1.5783E-5 },
    { "Inch (in)|Micrometer (µm)", 25400 },
    { "Inch (in)|Nanometer (nm)", 2.54E+7 },

    // Conversion factors for foot
    { "Foot (ft)|Millimeter (mm)", 304.8 },
    { "Foot (ft)|Centimeter (cm)", 30.48 },
    { "Foot (ft)|Decimeter (dm)", 3.048 },
    { "Foot (ft)|Meter (m)", 0.3048 },
    { "Foot (ft)|Dekameter (dam)", 0.03048 },
    { "Foot (ft)|Hectometer (hm)", 0.003048 },
    { "Foot (ft)|Kilometer (km)", 0.0003048 },
    { "Foot (ft)|Inch (in)", 12 },
    { "Foot (ft)|Foot (ft)", 1 },
    { "Foot (ft)|Yard (yd)", 0.333333 },
    { "Foot (ft)|Mile (mi)", 0.000189394 },
    { "Foot (ft)|Micrometer (µm)", 304800 },
    { "Foot (ft)|Nanometer (nm)", 3.048E+8 },

    // Conversion factors for yard
    { "Yard (yd)|Millimeter (mm)", 914.4 },
    { "Yard (yd)|Centimeter (cm)", 91.44 },
    { "Yard (yd)|Decimeter (dm)", 9.144 },
    { "Yard (yd)|Meter (m)", 0.9144 },
    { "Yard (yd)|Dekameter (dam)", 0.09144 },
    { "Yard (yd)|Hectometer (hm)", 0.009144 },
    { "Yard (yd)|Kilometer (km)", 0.0009144 },
    { "Yard (yd)|Inch (in)", 36 },
    { "Yard (yd)|Foot (ft)", 3 },
    { "Yard (yd)|Yard (yd)", 1 },
    { "Yard (yd)|Mile (mi)", 0.000568182 },
    { "Yard (yd)|Micrometer (µm)", 914400 },
    { "Yard (yd)|Nanometer (nm)", 9.144E+8 },

    // Conversion factors for mile
    { "Mile (mi)|Millimeter (mm)", 1.60934E+6 },
    { "Mile (mi)|Centimeter (cm)", 160934 },
    { "Mile (mi)|Decimeter (dm)", 16093.4 },
    { "Mile (mi)|Meter (m)", 1609.34 },
    { "Mile (mi)|Dekameter (dam)", 160.934 },
    { "Mile (mi)|Hectometer (hm)", 16.0934 },
    { "Mile (mi)|Kilometer (km)", 1.60934 },
    { "Mile (mi)|Inch (in)", 63360 },
    { "Mile (mi)|Foot (ft)", 5280 },
    { "Mile (mi)|Yard (yd)", 1760 },
    { "Mile (mi)|Mile (mi)", 1 },
    { "Mile (mi)|Micrometer (µm)", 1.60934E+9 },
    { "Mile (mi)|Nanometer (nm)", 1.60934E+12 },

    // Conversion factors for micrometer (µm)
    { "Micrometer (µm)|Millimeter (mm)", 0.001 },
    { "Micrometer (µm)|Centimeter (cm)", 0.0001 },
    { "Micrometer (µm)|Decimeter (dm)", 1.0E-5 },
    { "Micrometer (µm)|Meter (m)", 1.0E-6 },
    { "Micrometer (µm)|Dekameter (dam)", 1.0E-10 },
    { "Micrometer (µm)|Hectometer (hm)", 1.0E-11 },
    { "Micrometer (µm)|Kilometer (km)", 1.0E-12 },
    { "Micrometer (µm)|Inch (in)", 3.93701E-5 },
    { "Micrometer (µm)|Foot (ft)", 3.28084E-6 },
    { "Micrometer (µm)|Yard (yd)", 1.09361E-6 },
    { "Micrometer (µm)|Mile (mi)", 6.21371E-10 },
    { "Micrometer (µm)|Micrometer (µm)", 1 },
    { "Micrometer (µm)|Nanometer (nm)", 1000 },

    // Conversion factors for nanometer (nm)
    { "Nanometer (nm)|Millimeter (mm)", 1.0E-6 },
    { "Nanometer (nm)|Centimeter (cm)", 1.0E-7 },
    { "Nanometer (nm)|Decimeter (dm)", 1.0E-8 },
    { "Nanometer (nm)|Meter (m)", 1.0E-9 },
    { "Nanometer (nm)|Dekameter (dam)", 1.0E-13 },
    { "Nanometer (nm)|Hectometer (hm)", 1.0E-14 },
    { "Nanometer (nm)|Kilometer (km)", 1.0E-15 },
    { "Nanometer (nm)|Inch (in)", 3.93701E-8 },
    { "Nanometer (nm)|Foot (ft)", 3.28084E-9 },
    { "Nanometer (nm)|Yard (yd)", 1.09361E-9 },
    { "Nanometer (nm)|Mile (mi)", 6.21371E-13 },
    { "Nanometer (nm)|Micrometer (µm)", 0.001 },
    { "Nanometer (nm)|Nanometer (nm)", 1 }
            };
        public List<string> conversions { get; set; }
        public Length_Menu()
        {
            InitializeComponent();
            conversions = new List<string>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {


            if (tbValueFrom.Text != "" && cbFrom.SelectedItem != null && cbTo.SelectedItem != null)
            {
                lblExplanation.Text = "";

                // Get selected items as strings
                string fromUnit = cbFrom.SelectedItem.ToString();
                string toUnit = cbTo.SelectedItem.ToString();

                // Check if conversion factor exists in the dictionary
                if (conversionFactors.ContainsKey($"{fromUnit}|{toUnit}"))
                {
                    double value;
                    bool isValidNumber = double.TryParse(tbValueFrom.Text, out value);

                    if (isValidNumber)
                    {
                        double conversionFactor = conversionFactors[$"{fromUnit}|{toUnit}"];
                        double result = value * conversionFactor;

                        // Display result
                        tbValueTo.Text = result.ToString();
                        lblExplanation.Text = $"1 {fromUnit} = {conversionFactor} {toUnit}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter a valid number.");
                    }
                    addConversions();
                }
                else
                {
                    MessageBox.Show("Conversion from selected units is not supported.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields and select units for conversion.");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            tbValueFrom.Text = "";
            tbValueTo.Text = "";
            cbFrom.SelectedItem = null;
            cbTo.SelectedItem = null;
            lblExplanation.Text = "";
        }
        private void addConversions()
        {
            string valueFrom = tbValueFrom.Text;
            string valueTo = tbValueTo.Text;

            if (string.IsNullOrEmpty(valueFrom) || string.IsNullOrEmpty(valueTo) || cbFrom.SelectedItem == null || cbTo.SelectedItem == null)
            {
                return;
            }
            else
            {
                string fromUnit = cbFrom.SelectedItem.ToString();
                string toUnit = cbTo.SelectedItem.ToString();
                double conversionFactor = conversionFactors[$"{fromUnit}|{toUnit}"];

                Conversion c = new Conversion(conversionFactor, cbFrom.SelectedItem.ToString(), cbTo.SelectedItem.ToString());


                if (conversions.Contains(c.ToString()))
                {
                    MessageBox.Show("This conversion already exists!");
                    return;
                }
                
                conversions.Add(c.ToString());
                lbUsedConversions.Items.Add(c);
            }
        }

        private void btnUseConversion_Click(object sender, EventArgs e)
        {
            if (lbUsedConversions.SelectedIndex == -1)
            {
                MessageBox.Show("Select valid conversion units from list!");
                return;
            }

            Conversion conversion = lbUsedConversions.SelectedItem as Conversion;

            tbValueFrom.Clear();
            tbValueTo.Clear();
            cbFrom.SelectedItem = conversion.ConversionFrom;
            cbTo.SelectedItem = conversion.ConversionTo;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }
