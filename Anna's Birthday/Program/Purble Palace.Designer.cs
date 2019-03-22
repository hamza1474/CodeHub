namespace Anna_s_Birthday
{
    partial class PurblePalace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurblePalace));
            this.txt_typeOfCake = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addCake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_icecount = new System.Windows.Forms.Label();
            this.lbl_chcount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_typeOfCake
            // 
            this.txt_typeOfCake.BackColor = System.Drawing.Color.MediumVioletRed;
            this.txt_typeOfCake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_typeOfCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_typeOfCake.ForeColor = System.Drawing.Color.White;
            this.txt_typeOfCake.Location = new System.Drawing.Point(176, 124);
            this.txt_typeOfCake.Name = "txt_typeOfCake";
            this.txt_typeOfCake.Size = new System.Drawing.Size(131, 20);
            this.txt_typeOfCake.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(66, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type of cake";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // btn_addCake
            // 
            this.btn_addCake.BackColor = System.Drawing.Color.Maroon;
            this.btn_addCake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addCake.BackgroundImage")));
            this.btn_addCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addCake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCake.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_addCake.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCake.Image")));
            this.btn_addCake.Location = new System.Drawing.Point(176, 150);
            this.btn_addCake.Name = "btn_addCake";
            this.btn_addCake.Size = new System.Drawing.Size(131, 23);
            this.btn_addCake.TabIndex = 7;
            this.btn_addCake.Text = "Add Cake";
            this.btn_addCake.UseVisualStyleBackColor = false;
            this.btn_addCake.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(67, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ice Cakes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(43, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chocolate Cakes";
            // 
            // lbl_icecount
            // 
            this.lbl_icecount.AutoSize = true;
            this.lbl_icecount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_icecount.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_icecount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_icecount.Location = new System.Drawing.Point(173, 212);
            this.lbl_icecount.Name = "lbl_icecount";
            this.lbl_icecount.Size = new System.Drawing.Size(0, 17);
            this.lbl_icecount.TabIndex = 10;
            // 
            // lbl_chcount
            // 
            this.lbl_chcount.AutoSize = true;
            this.lbl_chcount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chcount.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chcount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_chcount.Location = new System.Drawing.Point(173, 195);
            this.lbl_chcount.Name = "lbl_chcount";
            this.lbl_chcount.Size = new System.Drawing.Size(0, 17);
            this.lbl_chcount.TabIndex = 11;
            this.lbl_chcount.Click += new System.EventHandler(this.Label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(209, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_result.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_result.Location = new System.Drawing.Point(55, 260);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 22);
            this.lbl_result.TabIndex = 13;
            // 
            // PurblePalace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 395);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_chcount);
            this.Controls.Add(this.lbl_icecount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addCake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_typeOfCake);
            this.Name = "PurblePalace";
            this.Text = "Purble Palace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_typeOfCake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addCake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_icecount;
        private System.Windows.Forms.Label lbl_chcount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_result;
    }
}

