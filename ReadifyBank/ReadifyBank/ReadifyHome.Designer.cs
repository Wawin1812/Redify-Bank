namespace ReadifyBank
{
    partial class ReadifyHome
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
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_CreateAC = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_CloseAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Account
            // 
            this.btn_Account.Location = new System.Drawing.Point(18, 44);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(171, 42);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "Account Summary";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.OpenSummary);
            // 
            // btn_CreateAC
            // 
            this.btn_CreateAC.Location = new System.Drawing.Point(18, 237);
            this.btn_CreateAC.Name = "btn_CreateAC";
            this.btn_CreateAC.Size = new System.Drawing.Size(171, 45);
            this.btn_CreateAC.TabIndex = 1;
            this.btn_CreateAC.Text = "Create Account";
            this.btn_CreateAC.UseVisualStyleBackColor = true;
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(18, 92);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(171, 42);
            this.btn_Deposit.TabIndex = 2;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(18, 140);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(171, 44);
            this.btn_Withdraw.TabIndex = 3;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(18, 190);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(171, 41);
            this.btn_Transfer.TabIndex = 4;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            // 
            // btn_CloseAC
            // 
            this.btn_CloseAC.Location = new System.Drawing.Point(18, 288);
            this.btn_CloseAC.Name = "btn_CloseAC";
            this.btn_CloseAC.Size = new System.Drawing.Size(171, 43);
            this.btn_CloseAC.TabIndex = 5;
            this.btn_CloseAC.Text = "Close Account";
            this.btn_CloseAC.UseVisualStyleBackColor = true;
            // 
            // ReadifyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 461);
            this.Controls.Add(this.btn_CloseAC);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_CreateAC);
            this.Controls.Add(this.btn_Account);
            this.Name = "ReadifyHome";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_CreateAC;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Button btn_CloseAC;
    }
}

