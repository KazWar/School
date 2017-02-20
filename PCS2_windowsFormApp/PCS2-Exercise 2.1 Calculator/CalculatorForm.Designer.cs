namespace PCS2_Exercise_2._1_Calculator
{
    partial class CalculatorForm
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
            this.tbValue1 = new System.Windows.Forms.NumericUpDown();
            this.tbValue2 = new System.Windows.Forms.NumericUpDown();
            this.cbOperators = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbValue1
            // 
            this.tbValue1.Location = new System.Drawing.Point(87, 30);
            this.tbValue1.Name = "tbValue1";
            this.tbValue1.Size = new System.Drawing.Size(75, 22);
            this.tbValue1.TabIndex = 0;
            // 
            // tbValue2
            // 
            this.tbValue2.Location = new System.Drawing.Point(217, 30);
            this.tbValue2.Name = "tbValue2";
            this.tbValue2.Size = new System.Drawing.Size(77, 22);
            this.tbValue2.TabIndex = 1;
            // 
            // cbOperators
            // 
            this.cbOperators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperators.FormattingEnabled = true;
            this.cbOperators.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperators.Location = new System.Drawing.Point(168, 29);
            this.cbOperators.Name = "cbOperators";
            this.cbOperators.Size = new System.Drawing.Size(43, 24);
            this.cbOperators.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(208, 73);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(108, 44);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(322, 30);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 22);
            this.resultBox.TabIndex = 5;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 157);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.cbOperators);
            this.Controls.Add(this.tbValue2);
            this.Controls.Add(this.tbValue1);
            this.Name = "Calculator";
            this.Text = "HAL-9000";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tbValue1;
        private System.Windows.Forms.NumericUpDown tbValue2;
        private System.Windows.Forms.ComboBox cbOperators;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox;
    }
}

