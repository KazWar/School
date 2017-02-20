namespace PCS2_Excercise1._4
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.convertFrom = new System.Windows.Forms.Button();
            this.ConvertTo = new System.Windows.Forms.Button();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.textBoxEuro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.currencyDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion Rate for :\r\n";
            // 
            // convertFrom
            // 
            this.convertFrom.Location = new System.Drawing.Point(413, 73);
            this.convertFrom.Name = "convertFrom";
            this.convertFrom.Size = new System.Drawing.Size(93, 32);
            this.convertFrom.TabIndex = 2;
            this.convertFrom.Text = ">";
            this.convertFrom.UseVisualStyleBackColor = true;
            this.convertFrom.Click += new System.EventHandler(this.convertFrom_Click);
            // 
            // ConvertTo
            // 
            this.ConvertTo.Location = new System.Drawing.Point(314, 73);
            this.ConvertTo.Name = "ConvertTo";
            this.ConvertTo.Size = new System.Drawing.Size(93, 32);
            this.ConvertTo.TabIndex = 3;
            this.ConvertTo.Text = "<";
            this.ConvertTo.UseVisualStyleBackColor = true;
            this.ConvertTo.Click += new System.EventHandler(this.ConvertTo_Click);
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Location = new System.Drawing.Point(512, 78);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(181, 22);
            this.textBoxValue2.TabIndex = 5;
            // 
            // textBoxEuro
            // 
            this.textBoxEuro.Location = new System.Drawing.Point(127, 78);
            this.textBoxEuro.Name = "textBoxEuro";
            this.textBoxEuro.Size = new System.Drawing.Size(181, 22);
            this.textBoxEuro.TabIndex = 6;
            this.textBoxEuro.TextChanged += new System.EventHandler(this.textBoxValue1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Euro\'s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dollars";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PCS2_Excercise1._4.Properties.Resources.Euro_sign_svg;
            this.pictureBox2.Location = new System.Drawing.Point(57, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCS2_Excercise1._4.Properties.Resources.dollar_sign_clipart_black_and_white_clipart_panda_free_clipart_X7hqyM_clipart;
            this.pictureBox1.Location = new System.Drawing.Point(699, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(449, 148);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // currencyDropdown
            // 
            this.currencyDropdown.FormattingEnabled = true;
            this.currencyDropdown.Items.AddRange(new object[] {
            "Dollar",
            "Yuan",
            "Pound",
            "Złoty"});
            this.currencyDropdown.Location = new System.Drawing.Point(322, 147);
            this.currencyDropdown.Name = "currencyDropdown";
            this.currencyDropdown.Size = new System.Drawing.Size(121, 24);
            this.currencyDropdown.TabIndex = 12;
            this.currencyDropdown.SelectedIndexChanged += new System.EventHandler(this.currencyDropdown_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 193);
            this.Controls.Add(this.currencyDropdown);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxEuro);
            this.Controls.Add(this.textBoxValue2);
            this.Controls.Add(this.ConvertTo);
            this.Controls.Add(this.convertFrom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertFrom;
        private System.Windows.Forms.Button ConvertTo;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.TextBox textBoxEuro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox currencyDropdown;
    }
}

