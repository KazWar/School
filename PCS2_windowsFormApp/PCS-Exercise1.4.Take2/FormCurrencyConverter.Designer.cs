namespace PCS_Exercise1._4.Take2
{
    partial class FormCurrencyConverter
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
            this.currLabel1 = new System.Windows.Forms.Label();
            this.currLabel2 = new System.Windows.Forms.Label();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnFrom = new System.Windows.Forms.Button();
            this.listFromCurrency = new System.Windows.Forms.ComboBox();
            this.listToCurrency = new System.Windows.Forms.ComboBox();
            this.textConversionToRatio = new System.Windows.Forms.NumericUpDown();
            this.infLabel = new System.Windows.Forms.Label();
            this.btnDesigner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textToAmount = new System.Windows.Forms.NumericUpDown();
            this.textFromAmount = new System.Windows.Forms.NumericUpDown();
            this.textConversionFromRatio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textConversionToRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFromAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textConversionFromRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // currLabel1
            // 
            this.currLabel1.AutoSize = true;
            this.currLabel1.Location = new System.Drawing.Point(48, 33);
            this.currLabel1.Name = "currLabel1";
            this.currLabel1.Size = new System.Drawing.Size(40, 17);
            this.currLabel1.TabIndex = 1;
            this.currLabel1.Text = "From";
            // 
            // currLabel2
            // 
            this.currLabel2.AutoSize = true;
            this.currLabel2.Location = new System.Drawing.Point(546, 33);
            this.currLabel2.Name = "currLabel2";
            this.currLabel2.Size = new System.Drawing.Size(25, 17);
            this.currLabel2.TabIndex = 2;
            this.currLabel2.Text = "To";
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(335, 49);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(84, 35);
            this.btnTo.TabIndex = 3;
            this.btnTo.Text = ">";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(245, 49);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(84, 35);
            this.btnFrom.TabIndex = 6;
            this.btnFrom.Text = "<";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // listFromCurrency
            // 
            this.listFromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listFromCurrency.FormattingEnabled = true;
            this.listFromCurrency.Location = new System.Drawing.Point(51, 54);
            this.listFromCurrency.Name = "listFromCurrency";
            this.listFromCurrency.Size = new System.Drawing.Size(82, 24);
            this.listFromCurrency.TabIndex = 7;
            this.listFromCurrency.SelectedValueChanged += new System.EventHandler(this.listCurrencyFrom_SelectedValueChanged);
            // 
            // listToCurrency
            // 
            this.listToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listToCurrency.FormattingEnabled = true;
            this.listToCurrency.Location = new System.Drawing.Point(531, 54);
            this.listToCurrency.Name = "listToCurrency";
            this.listToCurrency.Size = new System.Drawing.Size(76, 24);
            this.listToCurrency.TabIndex = 8;
            this.listToCurrency.SelectedValueChanged += new System.EventHandler(this.listCurrencyFrom_SelectedValueChanged);
            // 
            // textConversionToRatio
            // 
            this.textConversionToRatio.DecimalPlaces = 2;
            this.textConversionToRatio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.textConversionToRatio.Location = new System.Drawing.Point(335, 107);
            this.textConversionToRatio.Name = "textConversionToRatio";
            this.textConversionToRatio.Size = new System.Drawing.Size(84, 22);
            this.textConversionToRatio.TabIndex = 9;
            // 
            // infLabel
            // 
            this.infLabel.AutoSize = true;
            this.infLabel.Location = new System.Drawing.Point(272, 87);
            this.infLabel.Name = "infLabel";
            this.infLabel.Size = new System.Drawing.Size(111, 17);
            this.infLabel.TabIndex = 10;
            this.infLabel.Text = "Conversion ratio";
            // 
            // btnDesigner
            // 
            this.btnDesigner.Location = new System.Drawing.Point(570, 137);
            this.btnDesigner.Name = "btnDesigner";
            this.btnDesigner.Size = new System.Drawing.Size(84, 35);
            this.btnDesigner.TabIndex = 11;
            this.btnDesigner.Text = "About ...";
            this.btnDesigner.UseVisualStyleBackColor = true;
            this.btnDesigner.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount";
            // 
            // textToAmount
            // 
            this.textToAmount.DecimalPlaces = 2;
            this.textToAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.textToAmount.Location = new System.Drawing.Point(425, 56);
            this.textToAmount.Name = "textToAmount";
            this.textToAmount.Size = new System.Drawing.Size(97, 22);
            this.textToAmount.TabIndex = 14;
            // 
            // textFromAmount
            // 
            this.textFromAmount.DecimalPlaces = 2;
            this.textFromAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.textFromAmount.Location = new System.Drawing.Point(142, 53);
            this.textFromAmount.Name = "textFromAmount";
            this.textFromAmount.Size = new System.Drawing.Size(97, 22);
            this.textFromAmount.TabIndex = 15;
            // 
            // textConversionFromRatio
            // 
            this.textConversionFromRatio.DecimalPlaces = 2;
            this.textConversionFromRatio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.textConversionFromRatio.Location = new System.Drawing.Point(245, 107);
            this.textConversionFromRatio.Name = "textConversionFromRatio";
            this.textConversionFromRatio.Size = new System.Drawing.Size(84, 22);
            this.textConversionFromRatio.TabIndex = 16;
            // 
            // FormCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 184);
            this.Controls.Add(this.textConversionFromRatio);
            this.Controls.Add(this.textFromAmount);
            this.Controls.Add(this.textToAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesigner);
            this.Controls.Add(this.infLabel);
            this.Controls.Add(this.textConversionToRatio);
            this.Controls.Add(this.listToCurrency);
            this.Controls.Add(this.listFromCurrency);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.currLabel2);
            this.Controls.Add(this.currLabel1);
            this.Name = "FormCurrencyConverter";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textConversionToRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFromAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textConversionFromRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currLabel1;
        private System.Windows.Forms.Label currLabel2;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.ComboBox listFromCurrency;
        private System.Windows.Forms.ComboBox listToCurrency;
        private System.Windows.Forms.NumericUpDown textConversionToRatio;
        private System.Windows.Forms.Label infLabel;
        private System.Windows.Forms.Button btnDesigner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown textToAmount;
        private System.Windows.Forms.NumericUpDown textFromAmount;
        private System.Windows.Forms.NumericUpDown textConversionFromRatio;
    }
}

