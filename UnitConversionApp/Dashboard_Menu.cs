using System;
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
    public partial class Dashboard_Menu : UserControl
    {
        public Dashboard_Menu()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void currency_panel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void currency_panel_MouseEnter(object sender, EventArgs e)
        {
            currency_panel.BackColor = Color.LightGray;
        }

        private void currency_panel_MouseLeave(object sender, EventArgs e)
        {
            currency_panel.BackColor = Color.White;
        }

        private void length_panel_MouseEnter(object sender, EventArgs e)
        {
            length_panel.BackColor = Color.LightGray;
        }

        private void length_panel_MouseLeave(object sender, EventArgs e)
        {
            length_panel.BackColor = Color.White;
        }

        private void data_panel_MouseEnter(object sender, EventArgs e)
        {
            data_panel.BackColor = Color.LightGray;
        }

        private void data_panel_MouseLeave(object sender, EventArgs e)
        {
            data_panel.BackColor = Color.White;
        }

        private void volume_panel_MouseEnter(object sender, EventArgs e)
        {
            volume_panel.BackColor = Color.LightGray;
        }

        private void volume_panel_MouseLeave(object sender, EventArgs e)
        {
            volume_panel.BackColor = Color.White;
        }
    }
}
