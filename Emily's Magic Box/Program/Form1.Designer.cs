namespace Emily_s_Magic_Box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_fruit = new System.Windows.Forms.TextBox();
            this.btn_showResult = new System.Windows.Forms.Button();
            this.btn_addFruit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_fruit
            // 
            this.txt_fruit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_fruit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fruit.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fruit.ForeColor = System.Drawing.Color.Purple;
            this.txt_fruit.Location = new System.Drawing.Point(78, 62);
            this.txt_fruit.Name = "txt_fruit";
            this.txt_fruit.Size = new System.Drawing.Size(140, 29);
            this.txt_fruit.TabIndex = 0;
            this.txt_fruit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fruit.TextChanged += new System.EventHandler(this.Txt_fruit_TextChanged);
            // 
            // btn_showResult
            // 
            this.btn_showResult.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_showResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showResult.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showResult.ForeColor = System.Drawing.Color.Purple;
            this.btn_showResult.Location = new System.Drawing.Point(78, 150);
            this.btn_showResult.Name = "btn_showResult";
            this.btn_showResult.Size = new System.Drawing.Size(140, 62);
            this.btn_showResult.TabIndex = 1;
            this.btn_showResult.Text = "What\'s In My Magic Box";
            this.btn_showResult.UseVisualStyleBackColor = false;
            this.btn_showResult.Click += new System.EventHandler(this.Btn_showResult_Click);
            // 
            // btn_addFruit
            // 
            this.btn_addFruit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addFruit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addFruit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFruit.ForeColor = System.Drawing.Color.Purple;
            this.btn_addFruit.Location = new System.Drawing.Point(78, 97);
            this.btn_addFruit.Name = "btn_addFruit";
            this.btn_addFruit.Size = new System.Drawing.Size(140, 29);
            this.btn_addFruit.TabIndex = 3;
            this.btn_addFruit.Text = "Add Fruit";
            this.btn_addFruit.UseVisualStyleBackColor = false;
            this.btn_addFruit.Click += new System.EventHandler(this.Btn_addFruit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 276);
            this.Controls.Add(this.btn_addFruit);
            this.Controls.Add(this.btn_showResult);
            this.Controls.Add(this.txt_fruit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fruit;
        private System.Windows.Forms.Button btn_showResult;
        private System.Windows.Forms.Button btn_addFruit;
    }
}

