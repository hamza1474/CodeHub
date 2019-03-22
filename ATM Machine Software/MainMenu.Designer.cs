namespace ATM_Machine_Software
{
    partial class MainMenu
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
            this.btn_balance = new System.Windows.Forms.Button();
            this.lbl_mainmenu = new System.Windows.Forms.Label();
            this.link_recentTransactions = new System.Windows.Forms.LinkLabel();
            this.btn_changePin = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_balance
            // 
            this.btn_balance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_balance.ForeColor = System.Drawing.Color.Purple;
            this.btn_balance.Location = new System.Drawing.Point(12, 72);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(143, 62);
            this.btn_balance.TabIndex = 0;
            this.btn_balance.Text = "Check Balance";
            this.btn_balance.UseVisualStyleBackColor = true;
            this.btn_balance.Click += new System.EventHandler(this.Btn_balance_Click);
            // 
            // lbl_mainmenu
            // 
            this.lbl_mainmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mainmenu.AutoSize = true;
            this.lbl_mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainmenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_mainmenu.Location = new System.Drawing.Point(103, 9);
            this.lbl_mainmenu.Name = "lbl_mainmenu";
            this.lbl_mainmenu.Size = new System.Drawing.Size(119, 25);
            this.lbl_mainmenu.TabIndex = 4;
            this.lbl_mainmenu.Text = "Main Menu";
            // 
            // link_recentTransactions
            // 
            this.link_recentTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link_recentTransactions.AutoSize = true;
            this.link_recentTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_recentTransactions.Location = new System.Drawing.Point(8, 264);
            this.link_recentTransactions.Name = "link_recentTransactions";
            this.link_recentTransactions.Size = new System.Drawing.Size(189, 20);
            this.link_recentTransactions.TabIndex = 5;
            this.link_recentTransactions.TabStop = true;
            this.link_recentTransactions.Text = "Show recent transactions";
            this.link_recentTransactions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_recentTransactions_LinkClicked);
            // 
            // btn_changePin
            // 
            this.btn_changePin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_changePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePin.ForeColor = System.Drawing.Color.Purple;
            this.btn_changePin.Location = new System.Drawing.Point(176, 155);
            this.btn_changePin.Name = "btn_changePin";
            this.btn_changePin.Size = new System.Drawing.Size(143, 62);
            this.btn_changePin.TabIndex = 6;
            this.btn_changePin.Text = "Change PIN";
            this.btn_changePin.UseVisualStyleBackColor = true;
            this.btn_changePin.Click += new System.EventHandler(this.Btn_changePin_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.ForeColor = System.Drawing.Color.Purple;
            this.btn_deposit.Location = new System.Drawing.Point(12, 155);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(143, 62);
            this.btn_deposit.TabIndex = 7;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.Btn_deposit_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.ForeColor = System.Drawing.Color.Purple;
            this.btn_withdraw.Location = new System.Drawing.Point(176, 72);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(143, 62);
            this.btn_withdraw.TabIndex = 8;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.Btn_withdraw_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(333, 293);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.btn_changePin);
            this.Controls.Add(this.link_recentTransactions);
            this.Controls.Add(this.lbl_mainmenu);
            this.Controls.Add(this.btn_balance);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_balance;
        private System.Windows.Forms.Label lbl_mainmenu;
        private System.Windows.Forms.LinkLabel link_recentTransactions;
        private System.Windows.Forms.Button btn_changePin;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_withdraw;
    }
}