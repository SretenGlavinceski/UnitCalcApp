using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace UnitConversionApp
{
    public partial class Data_Menu : UserControl
    {
        List<string> typeOfDataUnits = new List<string>
        {
            "Bit (b)", "Byte (B)", "Kilobit (Kb)","Kilobyte (KB)", "Megabit (Mb)", "Megabyte (MB)",
            "Gigabit (Gb)", "Gigabyte (GB)", "Terabyte (TB)"
        };

        Dictionary<string, string> progress_bar_mapping = new Dictionary<string, string>
        {
            { "Bit (b)", "Byte (B)" },
            { "Byte (B)", "Kilobyte (KB)" },
            { "Kilobit (Kb)", "Kilobyte (KB)" },
            { "Kilobyte (KB)", "Megabyte (MB)" },
            { "Megabit (Mb)", "Megabyte (MB)" },
            { "Megabyte (MB)", "Gigabyte (GB)" },
            { "Gigabit (Gb)", "Gigabyte (GB)" },
            { "Gigabyte (GB)", "Terabyte (TB)" },
            { "Terabyte (TB)", "Terabyte (TB)" }
        };

        Dictionary<string, double> conversionFactors = new Dictionary<string, double>
            {
                // Conversion factors from Bit (b)
                { "Bit (b)|Bit (b)", 1 },
                { "Bit (b)|Byte (B)", 1.0 / 8 },
                { "Bit (b)|Kilobyte (KB)", 1.0 / 8000 },
                { "Bit (b)|Megabyte (MB)", 1.0 / 8000000 },
                { "Bit (b)|Gigabyte (GB)", 1.0 / 8.0E+9 },
                { "Bit (b)|Terabyte (TB)", 1.0 / 8.0E+12 },
                { "Bit (b)|Kilobit (Kb)", 1.0 / 1000 },
                { "Bit (b)|Megabit (Mb)", 1.0 / 1.0E+6 },
                { "Bit (b)|Gigabit (Gb)", 1.0 / 1.0E+9 },

                // Conversion factors from Byte (B)
                { "Byte (B)|Bit (b)", 8 },
                { "Byte (B)|Byte (B)", 1 },
                { "Byte (B)|Kilobyte (KB)", 1.0 / 1000 },
                { "Byte (B)|Megabyte (MB)", 1.0 / 1000000 },
                { "Byte (B)|Gigabyte (GB)", 1.0 / 1.0E+9 },
                { "Byte (B)|Terabyte (TB)", 1.0 / 1.0E+12 },
                { "Byte (B)|Kilobit (Kb)", 8.0 / 1000 },
                { "Byte (B)|Megabit (Mb)", 8.0 / 1.0E+6 },
                { "Byte (B)|Gigabit (Gb)", 8.0 / 1.0E+9 },

                // Conversion factors from Kilobyte (KB)
                { "Kilobyte (KB)|Bit (b)", 8000 },
                { "Kilobyte (KB)|Byte (B)", 1000 },
                { "Kilobyte (KB)|Kilobyte (KB)", 1 },
                { "Kilobyte (KB)|Megabyte (MB)", 1.0 / 1000 },
                { "Kilobyte (KB)|Gigabyte (GB)", 1.0 / 1.0E+6 },
                { "Kilobyte (KB)|Terabyte (TB)", 1.0 / 1.0E+9 },
                { "Kilobyte (KB)|Kilobit (Kb)", 8 },
                { "Kilobyte (KB)|Megabit (Mb)", 8.0 / 1000 },
                { "Kilobyte (KB)|Gigabit (Gb)", 8.0 / 1.0E+6 },

                // Conversion factors from Megabyte (MB)
                { "Megabyte (MB)|Bit (b)", 8000000 },
                { "Megabyte (MB)|Byte (B)", 1000000 },
                { "Megabyte (MB)|Kilobyte (KB)", 1000 },
                { "Megabyte (MB)|Megabyte (MB)", 1 },
                { "Megabyte (MB)|Gigabyte (GB)", 1.0 / 1000 },
                { "Megabyte (MB)|Terabyte (TB)", 1.0 / 1.0E+6 },
                { "Megabyte (MB)|Kilobit (Kb)", 8000 },
                { "Megabyte (MB)|Megabit (Mb)", 8 },
                { "Megabyte (MB)|Gigabit (Gb)", 8.0 / 1000 },

                // Conversion factors from Gigabyte (GB)
                { "Gigabyte (GB)|Bit (b)", 8.0E+9 },
                { "Gigabyte (GB)|Byte (B)", 1.0E+9 },
                { "Gigabyte (GB)|Kilobyte (KB)", 1.0E+6 },
                { "Gigabyte (GB)|Megabyte (MB)", 1000 },
                { "Gigabyte (GB)|Gigabyte (GB)", 1 },
                { "Gigabyte (GB)|Terabyte (TB)", 1.0 / 1000 },
                { "Gigabyte (GB)|Kilobit (Kb)", 8.0E+6 },
                { "Gigabyte (GB)|Megabit (Mb)", 8000 },
                { "Gigabyte (GB)|Gigabit (Gb)", 8 },

                // Conversion factors from Terabyte (TB)
                { "Terabyte (TB)|Bit (b)", 8.0E+12 },
                { "Terabyte (TB)|Byte (B)", 1.0E+12 },
                { "Terabyte (TB)|Kilobyte (KB)", 1.0E+9 },
                { "Terabyte (TB)|Megabyte (MB)", 1.0E+6 },
                { "Terabyte (TB)|Gigabyte (GB)", 1000 },
                { "Terabyte (TB)|Terabyte (TB)", 1 },
                { "Terabyte (TB)|Kilobit (Kb)", 8.0E+9 },
                { "Terabyte (TB)|Megabit (Mb)", 8.0E+6 },
                { "Terabyte (TB)|Gigabit (Gb)", 8000 },

                // Conversion factors from Kilobit (Kb)
                { "Kilobit (Kb)|Bit (b)", 1000 },
                { "Kilobit (Kb)|Byte (B)", 125 },
                { "Kilobit (Kb)|Kilobyte (KB)", 0.125 },
                { "Kilobit (Kb)|Megabyte (MB)", 0.000125 },
                { "Kilobit (Kb)|Gigabyte (GB)", 1.25E-7 },
                { "Kilobit (Kb)|Terabyte (TB)", 1.25E-10 },
                { "Kilobit (Kb)|Kilobit (Kb)", 1 },
                { "Kilobit (Kb)|Megabit (Mb)", 0.001 },
                { "Kilobit (Kb)|Gigabit (Gb)", 1.0E-6 },

                // Conversion factors from Megabit (Mb)
                { "Megabit (Mb)|Bit (b)", 1.0E+6 },
                { "Megabit (Mb)|Byte (B)", 125000 },
                { "Megabit (Mb)|Kilobyte (KB)", 125 },
                { "Megabit (Mb)|Megabyte (MB)", 0.125 },
                { "Megabit (Mb)|Gigabyte (GB)", 0.000125 },
                { "Megabit (Mb)|Terabyte (TB)", 1.25E-7 },
                { "Megabit (Mb)|Kilobit (Kb)", 1000 },
                { "Megabit (Mb)|Megabit (Mb)", 1 },
                { "Megabit (Mb)|Gigabit (Gb)", 0.001 },

                // Conversion factors from Gigabit (Gb)
                { "Gigabit (Gb)|Bit (b)", 1.0E+9 },
                { "Gigabit (Gb)|Byte (B)", 1.25E+8 },
                { "Gigabit (Gb)|Kilobyte (KB)", 125000 },
                { "Gigabit (Gb)|Megabyte (MB)", 125 },
                { "Gigabit (Gb)|Gigabyte (GB)", 0.125 },
                { "Gigabit (Gb)|Terabyte (TB)", 1.25E-4 },
                { "Gigabit (Gb)|Kilobit (Kb)", 1.0E+6 },
                { "Gigabit (Gb)|Megabit (Mb)", 1000 },
                { "Gigabit (Gb)|Gigabit (Gb)", 1 }
            };



        public Data_Menu()
        {
            InitializeComponent();
        }

        private int FindLargestDivisibleBy(int n, int m)
        {
            if (n == 0)
            {
                throw new ArgumentException("n cannot be zero.");
            }

            int maxValue = int.MaxValue;
            if (m > maxValue)
            {
                throw new ArgumentException("m cannot be greater than Int32.MaxValue.");
            }

            int largestDivisible = m + (n - (m % n)) % n;

            if (largestDivisible > maxValue)
            {
                throw new InvalidOperationException("Cannot find a divisible number within the range of Int32.");
            }

            return largestDivisible;
        }
        private void input_value_num_TextChanged(object sender, EventArgs e)
        {
            if (cbDataFrom.SelectedIndex == -1)
            {
                MessageBox.Show("Select Data Unit!");
                return;
            }

            if (input_value_num.Text == "")
            {
                input_value_num.Text = "0";
                return;
            }

            int result;

            if (int.TryParse(input_value_num.Text, out result))
            {
                string typeUnit = cbDataFrom.SelectedItem.ToString();

                foreach(string unit in typeOfDataUnits)
                {
                    double value = conversionFactors[$"{typeUnit}|{unit}"];
                    string [] parts = unit.Split(' ');
                    Control[] foundControls = this.Controls.Find(parts[0], true);

                    if (foundControls.Length > 0 && foundControls[0] is TextBox)
                    {
                        TextBox textBox = (TextBox)foundControls[0];
                        textBox.Text = (value * result).ToString();
                    }
                }

                if (typeUnit.Equals("Bit (b)") || typeUnit.Equals("Kilobit (Kb)") || 
                    typeUnit.Equals("Megabit (Mb)") || typeUnit.Equals("Gigabit (Gb)"))
                {
                    int n = FindLargestDivisibleBy(8, result);
                    pb_data.Maximum = n;
                    pb_data.Value = result;

                    data_transfer_text.Text = String.Format("{0} {1} in {2} {3}",
                        result,
                        typeUnit,
                        n / 8,
                        progress_bar_mapping[typeUnit]);

                } else
                {
                    int n = FindLargestDivisibleBy(1000, result);
                    pb_data.Maximum = n;
                    pb_data.Value = result;

                    data_transfer_text.Text = String.Format("{0} {1} in {2} {3}",
                        result,
                        typeUnit,
                        n / 1000,
                        progress_bar_mapping[typeUnit]);
                }

            } else
            {
                MessageBox.Show("Invalid Input, only numbers!");
                input_value_num.Text = "";
                return;
            }

        }

        private void cbDataFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_value_num.Clear();
            foreach (string unit in typeOfDataUnits)
            {
                string[] parts = unit.Split(' ');
                Control[] foundControls = this.Controls.Find(parts[0], true);

                if (foundControls.Length > 0 && foundControls[0] is TextBox)
                {
                    TextBox textBox = (TextBox)foundControls[0];
                    textBox.Clear();
                }
            }
        }

        private void view_data_viz_Click(object sender, EventArgs e)
        {
            visualization_data.Visible = !visualization_data.Visible;
        }

        private void data_transfer_text_Click(object sender, EventArgs e)
        {

        }
    }
}
