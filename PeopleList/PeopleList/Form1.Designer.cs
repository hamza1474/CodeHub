namespace PeopleList
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
            this.lbl_city = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.InfoBox = new System.Windows.Forms.ListBox();
            this.Info = new System.Windows.Forms.ListBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(46, 62);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(49, 25);
            this.lbl_city.TabIndex = 0;
            this.lbl_city.Text = "City";
            this.lbl_city.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(101, 67);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(189, 20);
            this.txtCity.TabIndex = 1;
            // 
            // InfoBox
            // 
            this.InfoBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.ItemHeight = 16;
            this.InfoBox.Location = new System.Drawing.Point(28, 144);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(558, 180);
            this.InfoBox.TabIndex = 2;
            this.InfoBox.SelectedIndexChanged += new System.EventHandler(this.InfoBox_SelectedIndexChanged);
            // 
            // Info
            // 
            this.Info.FormattingEnabled = true;
            this.Info.Location = new System.Drawing.Point(28, 144);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(370, 186);
            this.Info.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(101, 93);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(189, 45);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbl_city);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox InfoBox;
        private System.Windows.Forms.ListBox Info;
        private System.Windows.Forms.Button btn_search;
    }
}

