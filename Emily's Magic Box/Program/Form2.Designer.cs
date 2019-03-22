namespace Emily_s_Magic_Box
{
    partial class Form2
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
            this.txt_Result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Result.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.ForeColor = System.Drawing.Color.Purple;
            this.txt_Result.Location = new System.Drawing.Point(0, 0);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(406, 326);
            this.txt_Result.TabIndex = 0;
            this.txt_Result.Text = "";
            this.txt_Result.TextChanged += new System.EventHandler(this.Txt_Result_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 326);
            this.Controls.Add(this.txt_Result);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txt_Result;
    }
}