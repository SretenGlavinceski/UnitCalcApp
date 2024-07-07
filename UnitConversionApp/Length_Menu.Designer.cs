namespace UnitConversionApp
{
    partial class Length_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValueFrom = new System.Windows.Forms.TextBox();
            this.tbValueTo = new System.Windows.Forms.TextBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbUsedConversions = new System.Windows.Forms.ListBox();
            this.btnUseConversion = new System.Windows.Forms.Button();
            this.lblConversionExplanation = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Converted Result";
            // 
            // tbValueFrom
            // 
            this.tbValueFrom.Location = new System.Drawing.Point(14, 49);
            this.tbValueFrom.Multiline = true;
            this.tbValueFrom.Name = "tbValueFrom";
            this.tbValueFrom.Size = new System.Drawing.Size(276, 28);
            this.tbValueFrom.TabIndex = 2;
            // 
            // tbValueTo
            // 
            this.tbValueTo.Enabled = false;
            this.tbValueTo.Location = new System.Drawing.Point(340, 49);
            this.tbValueTo.Multiline = true;
            this.tbValueTo.Name = "tbValueTo";
            this.tbValueTo.Size = new System.Drawing.Size(276, 28);
            this.tbValueTo.TabIndex = 3;
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Millimeter (mm)",
            "Centimeter (cm)",
            "Decimeter (dm)",
            "Meter (m)",
            "Dekameter (dam)",
            "Hectometer (hm)",
            "Kilometer (km)",
            "Inch (in)",
            "Foot (ft)",
            "Yard (yd)",
            "Mile (mi)",
            "Micrometer (µm)",
            "Nanometer (nm)"});
            this.cbTo.Location = new System.Drawing.Point(386, 92);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(230, 24);
            this.cbTo.TabIndex = 5;
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "Millimeter (mm)",
            "Centimeter (cm)",
            "Decimeter (dm)",
            "Meter (m)",
            "Dekameter (dam)",
            "Hectometer (hm)",
            "Kilometer (km)",
            "Inch (in)",
            "Foot (ft)",
            "Yard (yd)",
            "Mile (mi)",
            "Micrometer (µm)",
            "Nanometer (nm)"});
            this.cbFrom.Location = new System.Drawing.Point(60, 92);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(230, 24);
            this.cbFrom.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(13, 134);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(147, 33);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(340, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbUsedConversions
            // 
            this.lbUsedConversions.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsedConversions.FormattingEnabled = true;
            this.lbUsedConversions.ItemHeight = 19;
            this.lbUsedConversions.Location = new System.Drawing.Point(14, 23);
            this.lbUsedConversions.Name = "lbUsedConversions";
            this.lbUsedConversions.Size = new System.Drawing.Size(602, 118);
            this.lbUsedConversions.TabIndex = 11;
            // 
            // btnUseConversion
            // 
            this.btnUseConversion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUseConversion.Location = new System.Drawing.Point(19, 449);
            this.btnUseConversion.Name = "btnUseConversion";
            this.btnUseConversion.Size = new System.Drawing.Size(254, 29);
            this.btnUseConversion.TabIndex = 13;
            this.btnUseConversion.Text = "Use conversion";
            this.btnUseConversion.UseVisualStyleBackColor = false;
            this.btnUseConversion.Click += new System.EventHandler(this.btnUseConversion_Click);
            // 
            // lblConversionExplanation
            // 
            this.lblConversionExplanation.AutoSize = true;
            this.lblConversionExplanation.Enabled = false;
            this.lblConversionExplanation.Location = new System.Drawing.Point(316, 204);
            this.lblConversionExplanation.Name = "lblConversionExplanation";
            this.lblConversionExplanation.Size = new System.Drawing.Size(0, 16);
            this.lblConversionExplanation.TabIndex = 14;
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Enabled = false;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblExplanation.Location = new System.Drawing.Point(16, 251);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(12, 17);
            this.lblExplanation.TabIndex = 16;
            this.lblExplanation.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Unit ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Unit ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbValueFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbValueTo);
            this.groupBox1.Controls.Add(this.cbTo);
            this.groupBox1.Controls.Add(this.cbFrom);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 189);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measurement Units";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbUsedConversions);
            this.groupBox2.Location = new System.Drawing.Point(19, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 151);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recently used conversions";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(19, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Conversion Formula";
            // 
            // Length_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblConversionExplanation);
            this.Controls.Add(this.btnUseConversion);
            this.Name = "Length_Menu";
            this.Size = new System.Drawing.Size(661, 498);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValueFrom;
        private System.Windows.Forms.TextBox tbValueTo;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbUsedConversions;
        private System.Windows.Forms.Button btnUseConversion;
        private System.Windows.Forms.Label lblConversionExplanation;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
