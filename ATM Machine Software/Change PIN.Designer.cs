namespace ATM_Machine_Software
{
    partial class Change_PIN
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_oldPin = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newPin = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "ENTER YOUR OLD PIN";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(63, 263);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(129, 47);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Change";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // txt_oldPin
            // 
            this.txt_oldPin.BackColor = System.Drawing.Color.Pink;
            this.txt_oldPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oldPin.ForeColor = System.Drawing.Color.Purple;
            this.txt_oldPin.Location = new System.Drawing.Point(63, 69);
            this.txt_oldPin.Mask = "0000";
            this.txt_oldPin.Name = "txt_oldPin";
            this.txt_oldPin.PasswordChar = '*';
            this.txt_oldPin.Size = new System.Drawing.Size(129, 47);
            this.txt_oldPin.TabIndex = 6;
            this.txt_oldPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_oldPin.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ENTER YOUR NEW PIN";
            // 
            // txt_newPin
            // 
            this.txt_newPin.BackColor = System.Drawing.Color.Pink;
            this.txt_newPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPin.ForeColor = System.Drawing.Color.Purple;
            this.txt_newPin.Location = new System.Drawing.Point(63, 187);
            this.txt_newPin.Mask = "0000";
            this.txt_newPin.Name = "txt_newPin";
            this.txt_newPin.PasswordChar = '*';
            this.txt_newPin.Size = new System.Drawing.Size(129, 47);
            this.txt_newPin.TabIndex = 10;
            this.txt_newPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_newPin.ValidatingType = typeof(int);
            // 
            // Change_PIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(264, 335);
            this.Controls.Add(this.txt_newPin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_oldPin);
            this.Name = "Change_PIN";
            this.Text = "Change PIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.MaskedTextBox txt_oldPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_newPin;
    }
}