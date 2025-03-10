﻿namespace BankAccountApp2
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
            label1 = new Label();
            OwnerTxt = new TextBox();
            AccountsGrid = new DataGridView();
            CreateAccountBtn = new Button();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            label2 = new Label();
            NumAmount = new NumericUpDown();
            label3 = new Label();
            InterestNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Owner :";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(69, 25);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(169, 23);
            OwnerTxt.TabIndex = 1;
            // 
            // AccountsGrid
            // 
            AccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountsGrid.Location = new Point(244, 25);
            AccountsGrid.Name = "AccountsGrid";
            AccountsGrid.Size = new Size(403, 225);
            AccountsGrid.TabIndex = 2;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(69, 98);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(169, 34);
            CreateAccountBtn.TabIndex = 3;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(244, 256);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(191, 34);
            DepositBtn.TabIndex = 4;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(441, 256);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(206, 34);
            WithdrawBtn.TabIndex = 5;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 267);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Amount :";
            // 
            // NumAmount
            // 
            NumAmount.Location = new Point(78, 265);
            NumAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            NumAmount.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            NumAmount.Name = "NumAmount";
            NumAmount.Size = new Size(120, 23);
            NumAmount.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 61);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 8;
            label3.Text = "Inter. Rate :";
            // 
            // InterestNum
            // 
            InterestNum.Location = new Point(78, 59);
            InterestNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            InterestNum.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            InterestNum.Name = "InterestNum";
            InterestNum.Size = new Size(71, 23);
            InterestNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 294);
            Controls.Add(InterestNum);
            Controls.Add(label3);
            Controls.Add(NumAmount);
            Controls.Add(label2);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(AccountsGrid);
            Controls.Add(OwnerTxt);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Accounts Manager";
            ((System.ComponentModel.ISupportInitialize)AccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox OwnerTxt;
        private DataGridView AccountsGrid;
        private Button CreateAccountBtn;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Label label2;
        private NumericUpDown NumAmount;
        private Label label3;
        private NumericUpDown InterestNum;
    }
}
