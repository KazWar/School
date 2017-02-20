namespace Week6BankAcc
{
    partial class FormBank
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
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDeposito = new System.Windows.Forms.RadioButton();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.rbChecking = new System.Windows.Forms.RadioButton();
            this.Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bInterest = new System.Windows.Forms.Button();
            this.bWithdraw = new System.Windows.Forms.Button();
            this.bDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 16;
            this.lbAccounts.Location = new System.Drawing.Point(35, 33);
            this.lbAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(276, 420);
            this.lbAccounts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbDeposito);
            this.panel1.Controls.Add(this.rbSavings);
            this.panel1.Controls.Add(this.rbChecking);
            this.panel1.Controls.Add(this.Create);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(337, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 198);
            this.panel1.TabIndex = 1;
            // 
            // rbDeposito
            // 
            this.rbDeposito.AutoSize = true;
            this.rbDeposito.Location = new System.Drawing.Point(129, 116);
            this.rbDeposito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDeposito.Name = "rbDeposito";
            this.rbDeposito.Size = new System.Drawing.Size(85, 21);
            this.rbDeposito.TabIndex = 5;
            this.rbDeposito.TabStop = true;
            this.rbDeposito.Text = "Deposito";
            this.rbDeposito.UseVisualStyleBackColor = true;
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Location = new System.Drawing.Point(129, 87);
            this.rbSavings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(79, 21);
            this.rbSavings.TabIndex = 4;
            this.rbSavings.TabStop = true;
            this.rbSavings.Text = "Savings";
            this.rbSavings.UseVisualStyleBackColor = true;
            // 
            // rbChecking
            // 
            this.rbChecking.AutoSize = true;
            this.rbChecking.Location = new System.Drawing.Point(129, 59);
            this.rbChecking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbChecking.Name = "rbChecking";
            this.rbChecking.Size = new System.Drawing.Size(87, 21);
            this.rbChecking.TabIndex = 3;
            this.rbChecking.TabStop = true;
            this.rbChecking.Text = "Checking";
            this.rbChecking.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(129, 151);
            this.Create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(133, 28);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 27);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(132, 22);
            this.tbName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bInterest);
            this.panel2.Controls.Add(this.bWithdraw);
            this.panel2.Controls.Add(this.bDeposit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbAmount);
            this.panel2.Location = new System.Drawing.Point(337, 239);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 215);
            this.panel2.TabIndex = 2;
            // 
            // bInterest
            // 
            this.bInterest.Location = new System.Drawing.Point(129, 169);
            this.bInterest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bInterest.Name = "bInterest";
            this.bInterest.Size = new System.Drawing.Size(133, 28);
            this.bInterest.TabIndex = 4;
            this.bInterest.Text = "Interest";
            this.bInterest.UseVisualStyleBackColor = true;
            this.bInterest.Click += new System.EventHandler(this.bInterest_Click);
            // 
            // bWithdraw
            // 
            this.bWithdraw.Location = new System.Drawing.Point(129, 119);
            this.bWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bWithdraw.Name = "bWithdraw";
            this.bWithdraw.Size = new System.Drawing.Size(133, 28);
            this.bWithdraw.TabIndex = 3;
            this.bWithdraw.Text = "Withdraw";
            this.bWithdraw.UseVisualStyleBackColor = true;
            this.bWithdraw.Click += new System.EventHandler(this.bWithdraw_Click);
            // 
            // bDeposit
            // 
            this.bDeposit.Location = new System.Drawing.Point(129, 71);
            this.bDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDeposit.Name = "bDeposit";
            this.bDeposit.Size = new System.Drawing.Size(133, 28);
            this.bDeposit.TabIndex = 2;
            this.bDeposit.Text = "Deposit";
            this.bDeposit.UseVisualStyleBackColor = true;
            this.bDeposit.Click += new System.EventHandler(this.bDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(129, 31);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(132, 22);
            this.tbAmount.TabIndex = 0;
            // 
            // FormBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAccounts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBank";
            this.Text = "My Bank";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bWithdraw;
        private System.Windows.Forms.Button bDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button bInterest;
        private System.Windows.Forms.RadioButton rbDeposito;
        private System.Windows.Forms.RadioButton rbSavings;
        private System.Windows.Forms.RadioButton rbChecking;
    }
}

