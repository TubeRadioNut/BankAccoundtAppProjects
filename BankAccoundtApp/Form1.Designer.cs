namespace BankAccoundtApp
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
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lstCehckingAccount = new System.Windows.Forms.ListBox();
            this.lsvCheckingAccount = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(315, 100);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(216, 26);
            this.txtBankName.TabIndex = 1;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(315, 178);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(216, 26);
            this.txtAccountNumber.TabIndex = 2;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(315, 262);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(216, 26);
            this.txtBalance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(234, 315);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(149, 57);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lstCehckingAccount
            // 
            this.lstCehckingAccount.FormattingEnabled = true;
            this.lstCehckingAccount.ItemHeight = 20;
            this.lstCehckingAccount.Location = new System.Drawing.Point(555, 61);
            this.lstCehckingAccount.Name = "lstCehckingAccount";
            this.lstCehckingAccount.Size = new System.Drawing.Size(762, 264);
            this.lstCehckingAccount.TabIndex = 7;
            // 
            // lsvCheckingAccount
            // 
            this.lsvCheckingAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvCheckingAccount.FullRowSelect = true;
            this.lsvCheckingAccount.GridLines = true;
            this.lsvCheckingAccount.HideSelection = false;
            this.lsvCheckingAccount.Location = new System.Drawing.Point(565, 390);
            this.lsvCheckingAccount.MultiSelect = false;
            this.lsvCheckingAccount.Name = "lsvCheckingAccount";
            this.lsvCheckingAccount.Size = new System.Drawing.Size(752, 397);
            this.lsvCheckingAccount.TabIndex = 8;
            this.lsvCheckingAccount.UseCompatibleStateImageBehavior = false;
            this.lsvCheckingAccount.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bank Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Account Number";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Balance";
            this.columnHeader3.Width = 180;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btndeposit);
            this.panel1.Controls.Add(this.btnWithdraw);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(101, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 397);
            this.panel1.TabIndex = 9;
            // 
            // btndeposit
            // 
            this.btndeposit.Location = new System.Drawing.Point(26, 297);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(133, 60);
            this.btndeposit.TabIndex = 3;
            this.btndeposit.Text = "Deposit";
            this.btndeposit.UseVisualStyleBackColor = true;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(233, 297);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(139, 60);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(42, 83);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(107, 29);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "$Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(175, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(178, 35);
            this.txtAmount.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 853);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvCheckingAccount);
            this.Controls.Add(this.lstCehckingAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bank Account App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ListBox lstCehckingAccount;
        private System.Windows.Forms.ListView lsvCheckingAccount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

