namespace PCS2_windowsFormApp
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
            this.ValA = new System.Windows.Forms.TextBox();
            this.aDividedB = new System.Windows.Forms.TextBox();
            this.ValB = new System.Windows.Forms.TextBox();
            this.AModuloB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValA
            // 
            this.ValA.Location = new System.Drawing.Point(71, 85);
            this.ValA.Name = "ValA";
            this.ValA.Size = new System.Drawing.Size(100, 22);
            this.ValA.TabIndex = 0;
            this.ValA.TextChanged += new System.EventHandler(this.ValA_TextChanged);
            // 
            // aDividedB
            // 
            this.aDividedB.Location = new System.Drawing.Point(71, 163);
            this.aDividedB.Name = "aDividedB";
            this.aDividedB.Size = new System.Drawing.Size(100, 22);
            this.aDividedB.TabIndex = 1;
            this.aDividedB.TextChanged += new System.EventHandler(this.aDividedB_TextChanged);
            // 
            // ValB
            // 
            this.ValB.Location = new System.Drawing.Point(272, 85);
            this.ValB.Name = "ValB";
            this.ValB.Size = new System.Drawing.Size(100, 22);
            this.ValB.TabIndex = 2;
            this.ValB.TextChanged += new System.EventHandler(this.ValB_TextChanged);
            // 
            // AModuloB
            // 
            this.AModuloB.Location = new System.Drawing.Point(272, 165);
            this.AModuloB.Name = "AModuloB";
            this.AModuloB.Size = new System.Drawing.Size(100, 22);
            this.AModuloB.TabIndex = 3;
            this.AModuloB.TextChanged += new System.EventHandler(this.AModuloB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "A / B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "A % B";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(71, 220);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(301, 60);
            this.buttonResult.TabIndex = 8;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 292);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AModuloB);
            this.Controls.Add(this.ValB);
            this.Controls.Add(this.aDividedB);
            this.Controls.Add(this.ValA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValA;
        private System.Windows.Forms.TextBox aDividedB;
        private System.Windows.Forms.TextBox ValB;
        private System.Windows.Forms.TextBox AModuloB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonResult;
    }
}

