namespace CoinTerminal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownD = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThickness = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMass = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMass)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPut
            // 
            this.buttonPut.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPut.Location = new System.Drawing.Point(12, 130);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(97, 23);
            this.buttonPut.TabIndex = 0;
            this.buttonPut.Text = "Put";
            this.buttonPut.UseVisualStyleBackColor = false;
            this.buttonPut.Click += new System.EventHandler(this.buttonPut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Put the coin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diameter:";
            // 
            // numericUpDownD
            // 
            this.numericUpDownD.DecimalPlaces = 2;
            this.numericUpDownD.Location = new System.Drawing.Point(92, 29);
            this.numericUpDownD.Maximum = new decimal(new int[] {
            235,
            0,
            0,
            65536});
            this.numericUpDownD.Minimum = new decimal(new int[] {
            189,
            0,
            0,
            65536});
            this.numericUpDownD.Name = "numericUpDownD";
            this.numericUpDownD.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownD.TabIndex = 3;
            this.numericUpDownD.Value = new decimal(new int[] {
            189,
            0,
            0,
            65536});
            // 
            // numericUpDownThickness
            // 
            this.numericUpDownThickness.DecimalPlaces = 2;
            this.numericUpDownThickness.Location = new System.Drawing.Point(92, 58);
            this.numericUpDownThickness.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            65536});
            this.numericUpDownThickness.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            65536});
            this.numericUpDownThickness.Name = "numericUpDownThickness";
            this.numericUpDownThickness.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownThickness.TabIndex = 4;
            this.numericUpDownThickness.Value = new decimal(new int[] {
            18,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thickness:";
            // 
            // numericUpDownMass
            // 
            this.numericUpDownMass.DecimalPlaces = 1;
            this.numericUpDownMass.Location = new System.Drawing.Point(92, 87);
            this.numericUpDownMass.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            this.numericUpDownMass.Minimum = new decimal(new int[] {
            31,
            0,
            0,
            65536});
            this.numericUpDownMass.Name = "numericUpDownMass";
            this.numericUpDownMass.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMass.TabIndex = 6;
            this.numericUpDownMass.Value = new decimal(new int[] {
            31,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Display";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(242, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(201, 83);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sum:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Salmon;
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(242, 131);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(201, 36);
            this.textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(467, 188);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownThickness);
            this.Controls.Add(this.numericUpDownD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPut);
            this.Name = "Form1";
            this.Text = "Coin Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPut;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownD;
        private NumericUpDown numericUpDownThickness;
        private Label label3;
        private NumericUpDown numericUpDownMass;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
    }
}