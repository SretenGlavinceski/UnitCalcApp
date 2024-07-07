namespace UnitConversionApp
{
    partial class Volume_Converter_Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volume_unit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.type_conversion = new System.Windows.Forms.ComboBox();
            this.result_output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_value = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sphere_button = new System.Windows.Forms.Button();
            this.pyramid_button = new System.Windows.Forms.Button();
            this.cylinder_button = new System.Windows.Forms.Button();
            this.cube_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.volume_formula = new System.Windows.Forms.Label();
            this.area_formula = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_value);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.result_output);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.type_conversion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.volume_unit);
            this.groupBox1.Location = new System.Drawing.Point(22, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume Conversions";
            // 
            // volume_unit
            // 
            this.volume_unit.FormattingEnabled = true;
            this.volume_unit.Items.AddRange(new object[] {
            "Cubic Meter (m³)",
            "Liter (L)",
            "Milliliter (mL)",
            "Cubic Centimeter (cm³)",
            "Cubic Inch (in³)",
            "Cubic Foot (ft³)",
            "Cubic Yard (yd³)"});
            this.volume_unit.Location = new System.Drawing.Point(6, 122);
            this.volume_unit.Name = "volume_unit";
            this.volume_unit.Size = new System.Drawing.Size(238, 24);
            this.volume_unit.TabIndex = 1;
            this.volume_unit.SelectedIndexChanged += new System.EventHandler(this.volume_unit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(355, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type conversion";
            // 
            // type_conversion
            // 
            this.type_conversion.FormattingEnabled = true;
            this.type_conversion.Items.AddRange(new object[] {
            "Cubic Meter (m³)",
            "Liter (L)",
            "Milliliter (mL)",
            "Cubic Centimeter (cm³)",
            "Cubic Inch (in³)",
            "Cubic Foot (ft³)",
            "Cubic Yard (yd³)"});
            this.type_conversion.Location = new System.Drawing.Point(358, 122);
            this.type_conversion.Name = "type_conversion";
            this.type_conversion.Size = new System.Drawing.Size(256, 24);
            this.type_conversion.TabIndex = 5;
            this.type_conversion.SelectedIndexChanged += new System.EventHandler(this.type_conversion_SelectedIndexChanged);
            // 
            // result_output
            // 
            this.result_output.Enabled = false;
            this.result_output.Location = new System.Drawing.Point(358, 62);
            this.result_output.Name = "result_output";
            this.result_output.Size = new System.Drawing.Size(256, 22);
            this.result_output.TabIndex = 7;
            this.result_output.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result";
            // 
            // input_value
            // 
            this.input_value.Location = new System.Drawing.Point(9, 62);
            this.input_value.Name = "input_value";
            this.input_value.Size = new System.Drawing.Size(238, 22);
            this.input_value.TabIndex = 9;
            this.input_value.TextChanged += new System.EventHandler(this.input_value_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clear_button);
            this.groupBox2.Controls.Add(this.sphere_button);
            this.groupBox2.Controls.Add(this.pyramid_button);
            this.groupBox2.Controls.Add(this.cylinder_button);
            this.groupBox2.Controls.Add(this.cube_button);
            this.groupBox2.Location = new System.Drawing.Point(22, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape Visualization";
            // 
            // sphere_button
            // 
            this.sphere_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.sphere_button.Location = new System.Drawing.Point(372, 34);
            this.sphere_button.Name = "sphere_button";
            this.sphere_button.Size = new System.Drawing.Size(115, 34);
            this.sphere_button.TabIndex = 11;
            this.sphere_button.Text = "Sphere";
            this.sphere_button.UseVisualStyleBackColor = true;
            this.sphere_button.Click += new System.EventHandler(this.sphere_button_Click_1);
            // 
            // pyramid_button
            // 
            this.pyramid_button.Location = new System.Drawing.Point(251, 34);
            this.pyramid_button.Name = "pyramid_button";
            this.pyramid_button.Size = new System.Drawing.Size(115, 34);
            this.pyramid_button.TabIndex = 10;
            this.pyramid_button.Text = "Pyramid";
            this.pyramid_button.UseVisualStyleBackColor = true;
            this.pyramid_button.Click += new System.EventHandler(this.pyramid_button_Click_1);
            // 
            // cylinder_button
            // 
            this.cylinder_button.Location = new System.Drawing.Point(130, 34);
            this.cylinder_button.Name = "cylinder_button";
            this.cylinder_button.Size = new System.Drawing.Size(115, 34);
            this.cylinder_button.TabIndex = 9;
            this.cylinder_button.Text = "Cylinder";
            this.cylinder_button.UseVisualStyleBackColor = true;
            this.cylinder_button.Click += new System.EventHandler(this.cylinder_button_Click_1);
            // 
            // cube_button
            // 
            this.cube_button.Location = new System.Drawing.Point(9, 34);
            this.cube_button.Name = "cube_button";
            this.cube_button.Size = new System.Drawing.Size(115, 34);
            this.cube_button.TabIndex = 8;
            this.cube_button.Text = "Cube";
            this.cube_button.UseVisualStyleBackColor = true;
            this.cube_button.ClientSizeChanged += new System.EventHandler(this.cube_button_ClientSizeChanged);
            this.cube_button.Click += new System.EventHandler(this.cube_button_Click_2);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.area_formula);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.volume_formula);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(310, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Common formulas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(14, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Volume";
            // 
            // volume_formula
            // 
            this.volume_formula.AutoSize = true;
            this.volume_formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.volume_formula.Location = new System.Drawing.Point(14, 59);
            this.volume_formula.Name = "volume_formula";
            this.volume_formula.Size = new System.Drawing.Size(18, 25);
            this.volume_formula.TabIndex = 1;
            this.volume_formula.Text = "/";
            // 
            // area_formula
            // 
            this.area_formula.AutoSize = true;
            this.area_formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.area_formula.Location = new System.Drawing.Point(13, 150);
            this.area_formula.Name = "area_formula";
            this.area_formula.Size = new System.Drawing.Size(18, 25);
            this.area_formula.TabIndex = 3;
            this.area_formula.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(13, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Area";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(544, 34);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(70, 34);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Volume_Converter_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Volume_Converter_Menu";
            this.Size = new System.Drawing.Size(661, 498);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Volume_Converter_Menu_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox volume_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type_conversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result_output;
        private System.Windows.Forms.TextBox input_value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sphere_button;
        private System.Windows.Forms.Button pyramid_button;
        private System.Windows.Forms.Button cylinder_button;
        private System.Windows.Forms.Button cube_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label area_formula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label volume_formula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_button;
    }
}
