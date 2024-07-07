namespace UnitConversionApp
{
    partial class Currency_Menu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.from_currency = new System.Windows.Forms.ComboBox();
            this.to_currency = new System.Windows.Forms.ComboBox();
            this.from_currency_value = new System.Windows.Forms.TextBox();
            this.to_currency_value = new System.Windows.Forms.TextBox();
            this.from_currency_label = new System.Windows.Forms.Label();
            this.to_currency_label = new System.Windows.Forms.Label();
            this.save_exchange = new System.Windows.Forms.Button();
            this.panel_wrapper1 = new System.Windows.Forms.Panel();
            this.show_graph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_wrapper2 = new System.Windows.Forms.Panel();
            this.use_exchange_again = new System.Windows.Forms.Button();
            this.exchanges_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartExchangeRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.from_to_currency_label = new System.Windows.Forms.Label();
            this.panel_hide_chart = new System.Windows.Forms.Panel();
            this.label_temp_hide = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_wrapper1.SuspendLayout();
            this.panel_wrapper2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExchangeRateData)).BeginInit();
            this.panel_hide_chart.SuspendLayout();
            this.SuspendLayout();
            // 
            // from_currency
            // 
            this.from_currency.FormattingEnabled = true;
            this.from_currency.Location = new System.Drawing.Point(10, 75);
            this.from_currency.Name = "from_currency";
            this.from_currency.Size = new System.Drawing.Size(139, 21);
            this.from_currency.TabIndex = 0;
            this.from_currency.SelectedIndexChanged += new System.EventHandler(this.from_currency_SelectedIndexChanged);
            // 
            // to_currency
            // 
            this.to_currency.FormattingEnabled = true;
            this.to_currency.Location = new System.Drawing.Point(493, 75);
            this.to_currency.Name = "to_currency";
            this.to_currency.Size = new System.Drawing.Size(115, 21);
            this.to_currency.TabIndex = 1;
            this.to_currency.SelectedIndexChanged += new System.EventHandler(this.to_currency_SelectedIndexChanged);
            // 
            // from_currency_value
            // 
            this.from_currency_value.Enabled = false;
            this.from_currency_value.Location = new System.Drawing.Point(10, 26);
            this.from_currency_value.Name = "from_currency_value";
            this.from_currency_value.Size = new System.Drawing.Size(220, 20);
            this.from_currency_value.TabIndex = 6;
            this.from_currency_value.TextChanged += new System.EventHandler(this.from_currency_value_TextChanged);
            // 
            // to_currency_value
            // 
            this.to_currency_value.Enabled = false;
            this.to_currency_value.Location = new System.Drawing.Point(388, 26);
            this.to_currency_value.Name = "to_currency_value";
            this.to_currency_value.Size = new System.Drawing.Size(220, 20);
            this.to_currency_value.TabIndex = 7;
            this.to_currency_value.TextChanged += new System.EventHandler(this.to_currency_value_TextChanged);
            // 
            // from_currency_label
            // 
            this.from_currency_label.AutoSize = true;
            this.from_currency_label.Location = new System.Drawing.Point(7, 10);
            this.from_currency_label.Name = "from_currency_label";
            this.from_currency_label.Size = new System.Drawing.Size(10, 13);
            this.from_currency_label.TabIndex = 8;
            this.from_currency_label.Text = "-";
            // 
            // to_currency_label
            // 
            this.to_currency_label.AutoSize = true;
            this.to_currency_label.Location = new System.Drawing.Point(385, 10);
            this.to_currency_label.Name = "to_currency_label";
            this.to_currency_label.Size = new System.Drawing.Size(10, 13);
            this.to_currency_label.TabIndex = 9;
            this.to_currency_label.Text = "-";
            // 
            // save_exchange
            // 
            this.save_exchange.Location = new System.Drawing.Point(245, 54);
            this.save_exchange.Name = "save_exchange";
            this.save_exchange.Size = new System.Drawing.Size(121, 23);
            this.save_exchange.TabIndex = 10;
            this.save_exchange.Text = "Save Exchange";
            this.save_exchange.UseVisualStyleBackColor = true;
            this.save_exchange.Click += new System.EventHandler(this.save_exchange_Click);
            // 
            // panel_wrapper1
            // 
            this.panel_wrapper1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_wrapper1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_wrapper1.Controls.Add(this.label5);
            this.panel_wrapper1.Controls.Add(this.label3);
            this.panel_wrapper1.Controls.Add(this.show_graph);
            this.panel_wrapper1.Controls.Add(this.label1);
            this.panel_wrapper1.Controls.Add(this.from_currency_value);
            this.panel_wrapper1.Controls.Add(this.save_exchange);
            this.panel_wrapper1.Controls.Add(this.from_currency);
            this.panel_wrapper1.Controls.Add(this.from_currency_label);
            this.panel_wrapper1.Controls.Add(this.to_currency_label);
            this.panel_wrapper1.Controls.Add(this.to_currency);
            this.panel_wrapper1.Controls.Add(this.to_currency_value);
            this.panel_wrapper1.Location = new System.Drawing.Point(17, 13);
            this.panel_wrapper1.Name = "panel_wrapper1";
            this.panel_wrapper1.Size = new System.Drawing.Size(622, 117);
            this.panel_wrapper1.TabIndex = 11;
            // 
            // show_graph
            // 
            this.show_graph.Location = new System.Drawing.Point(227, 83);
            this.show_graph.Name = "show_graph";
            this.show_graph.Size = new System.Drawing.Size(158, 23);
            this.show_graph.TabIndex = 11;
            this.show_graph.Text = "Show Exchange Chart";
            this.show_graph.UseVisualStyleBackColor = true;
            this.show_graph.Click += new System.EventHandler(this.show_graph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(269, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Currency Rates";
            // 
            // panel_wrapper2
            // 
            this.panel_wrapper2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_wrapper2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_wrapper2.Controls.Add(this.use_exchange_again);
            this.panel_wrapper2.Controls.Add(this.exchanges_list);
            this.panel_wrapper2.Controls.Add(this.label2);
            this.panel_wrapper2.Location = new System.Drawing.Point(17, 144);
            this.panel_wrapper2.Name = "panel_wrapper2";
            this.panel_wrapper2.Size = new System.Drawing.Size(231, 340);
            this.panel_wrapper2.TabIndex = 12;
            // 
            // use_exchange_again
            // 
            this.use_exchange_again.BackColor = System.Drawing.SystemColors.Control;
            this.use_exchange_again.Location = new System.Drawing.Point(10, 297);
            this.use_exchange_again.Name = "use_exchange_again";
            this.use_exchange_again.Size = new System.Drawing.Size(206, 23);
            this.use_exchange_again.TabIndex = 14;
            this.use_exchange_again.Text = "Use This Exchange Again";
            this.use_exchange_again.UseVisualStyleBackColor = false;
            this.use_exchange_again.Click += new System.EventHandler(this.use_exchange_again_Click);
            // 
            // exchanges_list
            // 
            this.exchanges_list.FormattingEnabled = true;
            this.exchanges_list.Location = new System.Drawing.Point(10, 27);
            this.exchanges_list.Name = "exchanges_list";
            this.exchanges_list.Size = new System.Drawing.Size(206, 264);
            this.exchanges_list.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Saved Exchages";
            // 
            // chartExchangeRateData
            // 
            this.chartExchangeRateData.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea9.Name = "ChartArea1";
            this.chartExchangeRateData.ChartAreas.Add(chartArea9);
            legend9.Alignment = System.Drawing.StringAlignment.Center;
            legend9.AutoFitMinFontSize = 5;
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend9.ItemColumnSpacing = 20;
            legend9.Name = "Legend1";
            this.chartExchangeRateData.Legends.Add(legend9);
            this.chartExchangeRateData.Location = new System.Drawing.Point(260, 160);
            this.chartExchangeRateData.Name = "chartExchangeRateData";
            this.chartExchangeRateData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.IsXValueIndexed = true;
            series9.Legend = "Legend1";
            series9.Name = "Exchage Rate Graph";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartExchangeRateData.Series.Add(series9);
            this.chartExchangeRateData.Size = new System.Drawing.Size(379, 324);
            this.chartExchangeRateData.TabIndex = 14;
            this.chartExchangeRateData.Text = "chart1";
            this.chartExchangeRateData.Visible = false;
            // 
            // from_to_currency_label
            // 
            this.from_to_currency_label.AutoSize = true;
            this.from_to_currency_label.Location = new System.Drawing.Point(260, 144);
            this.from_to_currency_label.Name = "from_to_currency_label";
            this.from_to_currency_label.Size = new System.Drawing.Size(153, 13);
            this.from_to_currency_label.TabIndex = 15;
            this.from_to_currency_label.Text = "Exchange Rates in Last Month";
            this.from_to_currency_label.Visible = false;
            // 
            // panel_hide_chart
            // 
            this.panel_hide_chart.Controls.Add(this.label_temp_hide);
            this.panel_hide_chart.Location = new System.Drawing.Point(263, 144);
            this.panel_hide_chart.Name = "panel_hide_chart";
            this.panel_hide_chart.Size = new System.Drawing.Size(383, 342);
            this.panel_hide_chart.TabIndex = 17;
            // 
            // label_temp_hide
            // 
            this.label_temp_hide.AutoSize = true;
            this.label_temp_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label_temp_hide.Location = new System.Drawing.Point(13, 16);
            this.label_temp_hide.Name = "label_temp_hide";
            this.label_temp_hide.Size = new System.Drawing.Size(363, 17);
            this.label_temp_hide.TabIndex = 0;
            this.label_temp_hide.Text = "Select the button above to Display Exchange Chart Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Currency to Convert from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Currency to Convert to";
            // 
            // Currency_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_hide_chart);
            this.Controls.Add(this.from_to_currency_label);
            this.Controls.Add(this.chartExchangeRateData);
            this.Controls.Add(this.panel_wrapper2);
            this.Controls.Add(this.panel_wrapper1);
            this.Name = "Currency_Menu";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(661, 498);
            this.panel_wrapper1.ResumeLayout(false);
            this.panel_wrapper1.PerformLayout();
            this.panel_wrapper2.ResumeLayout(false);
            this.panel_wrapper2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExchangeRateData)).EndInit();
            this.panel_hide_chart.ResumeLayout(false);
            this.panel_hide_chart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox from_currency;
        private System.Windows.Forms.ComboBox to_currency;
        private System.Windows.Forms.TextBox from_currency_value;
        private System.Windows.Forms.TextBox to_currency_value;
        private System.Windows.Forms.Label from_currency_label;
        private System.Windows.Forms.Label to_currency_label;
        private System.Windows.Forms.Button save_exchange;
        private System.Windows.Forms.Panel panel_wrapper1;
        private System.Windows.Forms.Panel panel_wrapper2;
        private System.Windows.Forms.ListBox exchanges_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExchangeRateData;
        private System.Windows.Forms.Button show_graph;
        private System.Windows.Forms.Button use_exchange_again;
        private System.Windows.Forms.Label from_to_currency_label;
        private System.Windows.Forms.Panel panel_hide_chart;
        private System.Windows.Forms.Label label_temp_hide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
