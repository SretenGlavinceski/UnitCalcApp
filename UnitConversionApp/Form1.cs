using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UnitConversionApp
{
    public partial class Form1 : Form
    {
        Dictionary<Button, bool> isHovered;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        Currency_Menu currency_Menu;
        Length_Menu length_menu;
        //Data_Converter_Menu data_converter_menu;
        Date_Time_Converter_Menu date_time_converter_menu;
        Volume_Converter_Menu volume_converter_menu;
        Data_Menu data_menu;
        Dashboard_Menu start_menu;
        public Form1()
        {
            InitializeComponent();
            initialize_buttons();
            title_bar_init();
            InitializeAdditionalForms();

            content_panel.Controls.Clear();
            content_panel.Controls.Add(start_menu);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void title_bar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void title_bar_init()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void initialize_buttons()
        {
            isHovered = new Dictionary<Button, bool>();
            isHovered.Add(btn_currency, false);
            isHovered.Add(btn_length, false);
            isHovered.Add(btn_data, false);
            isHovered.Add(btn_date_time, false);
            isHovered.Add(btn_volume, false);

           // dashboard_btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void myButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !isHovered[btn])
            {
                Pen pen = new Pen(Color.FromArgb(80, 85, 100), 20);
                e.Graphics.DrawLine(pen, 0, 0, 0, btn.Height);
                pen.Dispose();
            }
        }

        private void btn_currency_MouseHover(object sender, EventArgs e)
        {
            isHovered[btn_currency] = false;
            btn_currency.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_currency_MouseEnter(object sender, EventArgs e)
        {
            isHovered[btn_currency] = false;
            btn_currency.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_currency_MouseLeave(object sender, EventArgs e)
        {
            isHovered[btn_currency] = true;
            btn_currency.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_length_MouseEnter(object sender, EventArgs e)
        {
            isHovered[btn_length] = false;
            btn_length.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_length_MouseLeave(object sender, EventArgs e)
        {
            isHovered[btn_length] = true;
            btn_length.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_data_MouseEnter(object sender, EventArgs e)
        {
            isHovered[btn_data] = false;
            btn_data.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_data_MouseLeave(object sender, EventArgs e)
        {
            isHovered[btn_data] = true;
            btn_data.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_date_time_MouseEnter(object sender, EventArgs e)
        {
            isHovered[btn_date_time] = false;
            btn_date_time.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_date_time_MouseLeave(object sender, EventArgs e)
        {
            isHovered[btn_date_time] = true;
            btn_date_time.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_volume_MouseEnter(object sender, EventArgs e)
        {
            isHovered[btn_volume] = false;
            btn_volume.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_volume_MouseLeave(object sender, EventArgs e)
        {
            isHovered[btn_volume] = true;
            btn_volume.Paint += new PaintEventHandler(myButton_Paint);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.IconColor = Color.FromArgb(30, 188, 251);
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.IconColor = Color.White;
        }

        private void btn_resize_MouseEnter(object sender, EventArgs e)
        {
            btn_resize.IconColor = Color.FromArgb(70, 251, 30);
        }

        private void btn_resize_MouseLeave(object sender, EventArgs e)
        {
            btn_resize.IconColor = Color.White;
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.IconColor = Color.FromArgb(251, 30, 30);
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.IconColor = Color.White;
        }

        private void title_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1165, 720);
            content_panel.Controls.Clear();
            content_panel.Controls.Add(start_menu);
            caption_panel.BackColor = Color.LightSkyBlue;
            lb_menu_title.Text = "Dashboard Menu";
        }

        private void InitializeAdditionalForms()
        {

            start_menu = new Dashboard_Menu();
            start_menu.Dock = DockStyle.Fill;

            currency_Menu = new Currency_Menu();
            currency_Menu.Dock = DockStyle.Fill;

            length_menu = new Length_Menu();
            length_menu.Dock = DockStyle.Fill;

            //data_converter_menu = new Data_Converter_Menu();
            //data_converter_menu.Dock = DockStyle.Fill;

            date_time_converter_menu = new Date_Time_Converter_Menu();
            date_time_converter_menu.Dock = DockStyle.Fill;

            data_menu = new Data_Menu();
            dashboard_btn.Dock = DockStyle.Fill;

            volume_converter_menu = new Volume_Converter_Menu();
            volume_converter_menu.Dock = DockStyle.Fill;
        }

        private void btn_currency_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 750);
            content_panel.Controls.Clear();
            content_panel.Controls.Add(currency_Menu);
            caption_panel.BackColor = Color.BlueViolet;
            lb_menu_title.Text = "Currency Exchange Menu";
        }

        private void btn_length_Click(object sender, EventArgs e)
        {
            this.Size = new Size(940, 646);
            content_panel.Controls.Clear();
            content_panel.Controls.Add(length_menu);
            caption_panel.BackColor = Color.Coral;
            lb_menu_title.Text = "Length Measurement Menu";
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            this.Size = new Size(940, 646);
            content_panel.Controls.Clear();
            content_panel.Controls.Add(data_menu);
            caption_panel.BackColor = Color.LightGreen;
            lb_menu_title.Text = "Data Transfer Menu";
        }

        private void btn_date_time_Click(object sender, EventArgs e)
        {
            this.Size = new Size(650, 646);
            content_panel.Controls.Clear();
            content_panel.Controls.Add(date_time_converter_menu);
            caption_panel.BackColor = Color.LightSteelBlue;
            lb_menu_title.Text = "Date-Time Conversion Menu";
        }

        private void btn_volume_Click(object sender, EventArgs e)
        {
            this.Size = new Size(940, 646);
            content_panel.Controls.Clear();
            content_panel.Controls.Add(volume_converter_menu);
            caption_panel.BackColor = Color.GreenYellow;
            lb_menu_title.Text = "Valume Calculation and Representation Menu";
        }
    }

}
