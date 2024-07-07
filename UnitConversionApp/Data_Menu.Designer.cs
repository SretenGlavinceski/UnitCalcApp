namespace UnitConversionApp
{
    partial class Data_Menu
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
            this.cbDataFrom = new System.Windows.Forms.ComboBox();
            this.Bit = new System.Windows.Forms.TextBox();
            this.Byte = new System.Windows.Forms.TextBox();
            this.Kilobyte = new System.Windows.Forms.TextBox();
            this.Megabyte = new System.Windows.Forms.TextBox();
            this.Gigabyte = new System.Windows.Forms.TextBox();
            this.Terabyte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.input_value_num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wrapper = new System.Windows.Forms.GroupBox();
            this.Gigabit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Megabit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.noname = new System.Windows.Forms.Label();
            this.Kilobit = new System.Windows.Forms.TextBox();
            this.data_transfer_text = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visualization_data = new System.Windows.Forms.GroupBox();
            this.pb_data = new System.Windows.Forms.ProgressBar();
            this.view_data_viz = new FontAwesome.Sharp.IconButton();
            this.wrapper.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.visualization_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDataFrom
            // 
            this.cbDataFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataFrom.FormattingEnabled = true;
            this.cbDataFrom.Items.AddRange(new object[] {
            "Bit (b)",
            "Byte (B)",
            "Kilobit (Kb)",
            "Kilobyte (KB)",
            "Megabit (Mb)",
            "Megabyte (MB)",
            "Gigabit (Gb)",
            "Gigabyte (GB)",
            "Terabyte (TB)"});
            this.cbDataFrom.Location = new System.Drawing.Point(15, 117);
            this.cbDataFrom.Name = "cbDataFrom";
            this.cbDataFrom.Size = new System.Drawing.Size(221, 24);
            this.cbDataFrom.TabIndex = 14;
            this.cbDataFrom.SelectedIndexChanged += new System.EventHandler(this.cbDataFrom_SelectedIndexChanged);
            // 
            // Bit
            // 
            this.Bit.Enabled = false;
            this.Bit.Location = new System.Drawing.Point(137, 38);
            this.Bit.Name = "Bit";
            this.Bit.Size = new System.Drawing.Size(164, 22);
            this.Bit.TabIndex = 15;
            // 
            // Byte
            // 
            this.Byte.Enabled = false;
            this.Byte.Location = new System.Drawing.Point(137, 70);
            this.Byte.Name = "Byte";
            this.Byte.Size = new System.Drawing.Size(164, 22);
            this.Byte.TabIndex = 16;
            // 
            // Kilobyte
            // 
            this.Kilobyte.Enabled = false;
            this.Kilobyte.Location = new System.Drawing.Point(137, 142);
            this.Kilobyte.Name = "Kilobyte";
            this.Kilobyte.Size = new System.Drawing.Size(164, 22);
            this.Kilobyte.TabIndex = 17;
            // 
            // Megabyte
            // 
            this.Megabyte.Enabled = false;
            this.Megabyte.Location = new System.Drawing.Point(137, 215);
            this.Megabyte.Name = "Megabyte";
            this.Megabyte.Size = new System.Drawing.Size(164, 22);
            this.Megabyte.TabIndex = 18;
            // 
            // Gigabyte
            // 
            this.Gigabyte.Enabled = false;
            this.Gigabyte.Location = new System.Drawing.Point(137, 289);
            this.Gigabyte.Name = "Gigabyte";
            this.Gigabyte.Size = new System.Drawing.Size(164, 22);
            this.Gigabyte.TabIndex = 21;
            // 
            // Terabyte
            // 
            this.Terabyte.Enabled = false;
            this.Terabyte.Location = new System.Drawing.Point(137, 325);
            this.Terabyte.Name = "Terabyte";
            this.Terabyte.Size = new System.Drawing.Size(164, 22);
            this.Terabyte.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bit (b)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Byte (B)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Gigabyte (GB)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Megabyte (MB)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Terabyte (TB)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kilobyte (KB)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Choose Data Unit";
            // 
            // input_value_num
            // 
            this.input_value_num.Location = new System.Drawing.Point(15, 54);
            this.input_value_num.Name = "input_value_num";
            this.input_value_num.Size = new System.Drawing.Size(221, 22);
            this.input_value_num.TabIndex = 32;
            this.input_value_num.TextChanged += new System.EventHandler(this.input_value_num_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Enter value";
            // 
            // wrapper
            // 
            this.wrapper.Controls.Add(this.Kilobit);
            this.wrapper.Controls.Add(this.noname);
            this.wrapper.Controls.Add(this.Megabit);
            this.wrapper.Controls.Add(this.label8);
            this.wrapper.Controls.Add(this.label5);
            this.wrapper.Controls.Add(this.Gigabit);
            this.wrapper.Controls.Add(this.label2);
            this.wrapper.Controls.Add(this.Bit);
            this.wrapper.Controls.Add(this.Byte);
            this.wrapper.Controls.Add(this.Kilobyte);
            this.wrapper.Controls.Add(this.Megabyte);
            this.wrapper.Controls.Add(this.label7);
            this.wrapper.Controls.Add(this.label6);
            this.wrapper.Controls.Add(this.Gigabyte);
            this.wrapper.Controls.Add(this.Terabyte);
            this.wrapper.Controls.Add(this.label4);
            this.wrapper.Controls.Add(this.label1);
            this.wrapper.Controls.Add(this.label3);
            this.wrapper.Location = new System.Drawing.Point(325, 40);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(321, 423);
            this.wrapper.TabIndex = 35;
            this.wrapper.TabStop = false;
            this.wrapper.Text = "Different conversions";
            // 
            // Gigabit
            // 
            this.Gigabit.Enabled = false;
            this.Gigabit.Location = new System.Drawing.Point(137, 253);
            this.Gigabit.Name = "Gigabit";
            this.Gigabit.Size = new System.Drawing.Size(164, 22);
            this.Gigabit.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Gigabit (Gb)";
            // 
            // Megabit
            // 
            this.Megabit.Enabled = false;
            this.Megabit.Location = new System.Drawing.Point(137, 177);
            this.Megabit.Name = "Megabit";
            this.Megabit.Size = new System.Drawing.Size(164, 22);
            this.Megabit.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Megabit (Mb)";
            // 
            // noname
            // 
            this.noname.AutoSize = true;
            this.noname.Location = new System.Drawing.Point(17, 111);
            this.noname.Name = "noname";
            this.noname.Size = new System.Drawing.Size(70, 16);
            this.noname.TabIndex = 35;
            this.noname.Text = "Kilobit (Kb)";
            // 
            // Kilobit
            // 
            this.Kilobit.AcceptsReturn = true;
            this.Kilobit.Enabled = false;
            this.Kilobit.Location = new System.Drawing.Point(137, 108);
            this.Kilobit.Name = "Kilobit";
            this.Kilobit.Size = new System.Drawing.Size(164, 22);
            this.Kilobit.TabIndex = 36;
            // 
            // data_transfer_text
            // 
            this.data_transfer_text.AutoSize = true;
            this.data_transfer_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.data_transfer_text.Location = new System.Drawing.Point(6, 41);
            this.data_transfer_text.Name = "data_transfer_text";
            this.data_transfer_text.Size = new System.Drawing.Size(12, 13);
            this.data_transfer_text.TabIndex = 37;
            this.data_transfer_text.Text = "/";
            this.data_transfer_text.Click += new System.EventHandler(this.data_transfer_text_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_value_num);
            this.groupBox1.Controls.Add(this.cbDataFrom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 164);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input value";
            // 
            // visualization_data
            // 
            this.visualization_data.Controls.Add(this.pb_data);
            this.visualization_data.Controls.Add(this.data_transfer_text);
            this.visualization_data.Location = new System.Drawing.Point(23, 293);
            this.visualization_data.Name = "visualization_data";
            this.visualization_data.Size = new System.Drawing.Size(296, 170);
            this.visualization_data.TabIndex = 39;
            this.visualization_data.TabStop = false;
            this.visualization_data.Text = "Visualization";
            this.visualization_data.Visible = false;
            // 
            // pb_data
            // 
            this.pb_data.Location = new System.Drawing.Point(6, 78);
            this.pb_data.Maximum = 1000;
            this.pb_data.Name = "pb_data";
            this.pb_data.Size = new System.Drawing.Size(284, 63);
            this.pb_data.TabIndex = 36;
            // 
            // view_data_viz
            // 
            this.view_data_viz.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.view_data_viz.IconColor = System.Drawing.Color.Black;
            this.view_data_viz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.view_data_viz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_data_viz.Location = new System.Drawing.Point(23, 238);
            this.view_data_viz.Name = "view_data_viz";
            this.view_data_viz.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.view_data_viz.Size = new System.Drawing.Size(250, 45);
            this.view_data_viz.TabIndex = 40;
            this.view_data_viz.Text = "Data Visualization";
            this.view_data_viz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.view_data_viz.UseVisualStyleBackColor = true;
            this.view_data_viz.Click += new System.EventHandler(this.view_data_viz_Click);
            // 
            // Data_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.view_data_viz);
            this.Controls.Add(this.visualization_data);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wrapper);
            this.Name = "Data_Menu";
            this.Size = new System.Drawing.Size(661, 498);
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.visualization_data.ResumeLayout(false);
            this.visualization_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDataFrom;
        private System.Windows.Forms.TextBox Bit;
        private System.Windows.Forms.TextBox Byte;
        private System.Windows.Forms.TextBox Kilobyte;
        private System.Windows.Forms.TextBox Megabyte;
        private System.Windows.Forms.TextBox Gigabyte;
        private System.Windows.Forms.TextBox Terabyte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox input_value_num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox wrapper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Gigabit;
        private System.Windows.Forms.TextBox Megabit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label noname;
        private System.Windows.Forms.TextBox Kilobit;
        private System.Windows.Forms.Label data_transfer_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox visualization_data;
        private System.Windows.Forms.ProgressBar pb_data;
        private FontAwesome.Sharp.IconButton view_data_viz;
    }
}
