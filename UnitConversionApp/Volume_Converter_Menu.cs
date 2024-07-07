using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UnitConversionApp
{
    public partial class Volume_Converter_Menu : UserControl
    {
        // 0 -> cube, 1 -> cylinder, 2 -> sphere, 3 -> pyramid
        public int typeShape { get; set; }

        private CubeDrawer cubeDrawer;
        private CylinderDrawer cylinderDrawer;
        private PyramidDrawer pyramidDrawer;
        private SphereDrawer sphereDrawer;

        private Dictionary<string, double> conversionFactors = new Dictionary<string, double>
        {
            // Conversion factors relative to cubic meters (m³)
            { "Cubic Meter (m³)|Cubic Meter (m³)", 1 },
            { "Cubic Meter (m³)|Liter (L)", 1000 },
            { "Cubic Meter (m³)|Milliliter (mL)", 1.0E+6 },
            { "Cubic Meter (m³)|Cubic Centimeter (cm³)", 1.0E+6 },
            { "Cubic Meter (m³)|Cubic Inch (in³)", 61023.7441 },
            { "Cubic Meter (m³)|Cubic Foot (ft³)", 35.3146667 },
            { "Cubic Meter (m³)|Cubic Yard (yd³)", 1.30795062 },

            // Conversion factors relative to liters (L)
            { "Liter (L)|Cubic Meter (m³)", 0.001 },
            { "Liter (L)|Liter (L)", 1 },
            { "Liter (L)|Milliliter (mL)", 1000 },
            { "Liter (L)|Cubic Centimeter (cm³)", 1000 },
            { "Liter (L)|Cubic Inch (in³)", 61.0237441 },
            { "Liter (L)|Cubic Foot (ft³)", 0.0353146667 },
            { "Liter (L)|Cubic Yard (yd³)", 0.00130795062 },

            // Conversion factors relative to milliliters (mL)
            { "Milliliter (mL)|Cubic Meter (m³)", 1.0E-6 },
            { "Milliliter (mL)|Liter (L)", 0.001 },
            { "Milliliter (mL)|Milliliter (mL)", 1 },
            { "Milliliter (mL)|Cubic Centimeter (cm³)", 1 },
            { "Milliliter (mL)|Cubic Inch (in³)", 0.0610237441 },
            { "Milliliter (mL)|Cubic Foot (ft³)", 3.53146667E-5 },
            { "Milliliter (mL)|Cubic Yard (yd³)", 1.30795062E-6 },

            // Conversion factors relative to cubic centimeters (cm³)
            { "Cubic Centimeter (cm³)|Cubic Meter (m³)", 1.0E-6 },
            { "Cubic Centimeter (cm³)|Liter (L)", 0.001 },
            { "Cubic Centimeter (cm³)|Milliliter (mL)", 1 },
            { "Cubic Centimeter (cm³)|Cubic Centimeter (cm³)", 1 },
            { "Cubic Centimeter (cm³)|Cubic Inch (in³)", 0.0610237441 },
            { "Cubic Centimeter (cm³)|Cubic Foot (ft³)", 3.53146667E-5 },
            { "Cubic Centimeter (cm³)|Cubic Yard (yd³)", 1.30795062E-6 },

            // Conversion factors relative to cubic inches (in³)
            { "Cubic Inch (in³)|Cubic Meter (m³)", 1.6387E-5 },
            { "Cubic Inch (in³)|Liter (L)", 0.016387064 },
            { "Cubic Inch (in³)|Milliliter (mL)", 16.387064 },
            { "Cubic Inch (in³)|Cubic Centimeter (cm³)", 16.387064 },
            { "Cubic Inch (in³)|Cubic Inch (in³)", 1 },
            { "Cubic Inch (in³)|Cubic Foot (ft³)", 0.000578704 },
            { "Cubic Inch (in³)|Cubic Yard (yd³)", 2.14335E-5 },

            // Conversion factors relative to cubic feet (ft³)
            { "Cubic Foot (ft³)|Cubic Meter (m³)", 0.0283168466 },
            { "Cubic Foot (ft³)|Liter (L)", 28.3168466 },
            { "Cubic Foot (ft³)|Milliliter (mL)", 28316.8466 },
            { "Cubic Foot (ft³)|Cubic Centimeter (cm³)", 28316.8466 },
            { "Cubic Foot (ft³)|Cubic Inch (in³)", 1728 },
            { "Cubic Foot (ft³)|Cubic Foot (ft³)", 1 },
            { "Cubic Foot (ft³)|Cubic Yard (yd³)", 0.037037037 },

            // Conversion factors relative to cubic yards (yd³)
            { "Cubic Yard (yd³)|Cubic Meter (m³)", 0.764554858 },
            { "Cubic Yard (yd³)|Liter (L)", 764.554858 },
            { "Cubic Yard (yd³)|Milliliter (mL)", 764554.858 },
            { "Cubic Yard (yd³)|Cubic Centimeter (cm³)", 764554.858 },
            { "Cubic Yard (yd³)|Cubic Inch (in³)", 46656 },
            { "Cubic Yard (yd³)|Cubic Foot (ft³)", 27 },
            { "Cubic Yard (yd³)|Cubic Yard (yd³)", 1 }
        };

        public Volume_Converter_Menu()
        {
            InitializeComponent();
            input_value.KeyPress += NumericTextBox_KeyPress;
            this.Paint += new PaintEventHandler(this.Volume_Converter_Menu_Paint);

            cubeDrawer = new CubeDrawer(1000000);
            cylinderDrawer = new CylinderDrawer(1000000);
            pyramidDrawer = new PyramidDrawer(600000);
            sphereDrawer = new SphereDrawer(1000000);

            typeShape = -1;
            DoubleBuffered = true;


        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Volume_Converter_Menu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

            PointF origin;
            switch (typeShape)
            {
                case 0: // Cube
                    origin = new PointF(40, 365);
                    cubeDrawer.DrawCube(e.Graphics, origin);
                    break;
                case 1: // Cylinder
                    origin = new PointF(120, 400);
                    cylinderDrawer.DrawCylinder(e.Graphics, origin);
                    break;
                case 2: // Sphere
                    origin = new PointF(120, 400);
                    sphereDrawer.DrawSphere(e.Graphics, origin);
                    break;
                case 3: // Pyramid
                    origin = new PointF(120, 400);
                    pyramidDrawer.DrawPyramid(e.Graphics, origin);
                    break;
                default:
                    return;
            }
        }

        private void input_value_ValueChanged(object sender, EventArgs e)
        {

        }

        private void input_value_TextChanged(object sender, EventArgs e)
        {
            if (input_value.Text == "")
            {
                return;
            }

            if (volume_unit.SelectedIndex == -1 || type_conversion.SelectedIndex == -1)
            {
                input_value.Clear();
                MessageBox.Show("Please select volume units!");
                return;
            }

            if (double.TryParse(input_value.Text, out double value_input))
            {
                string unit_from = volume_unit.SelectedItem.ToString();
                string unit_to = type_conversion.SelectedItem.ToString();

                double factor = conversionFactors[$"{unit_from}|{unit_to}"];
                result_output.Text = (factor * value_input).ToString();
            }
            else
            {
                throw new Exception();
            }
        }

        private void type_conversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_value.Clear();
        }

        private void volume_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_value.Clear();
        }

        private void cube_button_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void cube_button_Click_2(object sender, EventArgs e)
        {
            typeShape = 0;
            volume_formula.Text = "V = s³";
            area_formula.Text = "A = 6s²";
            Invalidate(true);
        }

        private void cylinder_button_Click_1(object sender, EventArgs e)
        {
            typeShape = 1;
            volume_formula.Text = "V = π x r² x h";
            area_formula.Text = "A = 2 x π x r x (h + r)";
            Invalidate(true);
        }

        private void pyramid_button_Click_1(object sender, EventArgs e)
        {
            typeShape = 3;
            volume_formula.Text = "V = 1/3 x B x H";
            area_formula.Text = "A = B + L";
            Invalidate(true);
        }

        private void sphere_button_Click_1(object sender, EventArgs e)
        {
            typeShape = 2;
            volume_formula.Text = "V = 4/3 × π × r³";
            area_formula.Text = "A = 4 × π × r²";
            Invalidate(true);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            typeShape = -1;
            volume_formula.Text = "/";
            area_formula.Text = "/";
            Invalidate(true);
        }
    }
}
