namespace ABC_Company
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
            this.txtbox_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtbox_output
            // 
            this.txtbox_output.BackColor = System.Drawing.Color.PeachPuff;
            this.txtbox_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_output.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_output.ForeColor = System.Drawing.Color.Black;
            this.txtbox_output.Location = new System.Drawing.Point(0, 0);
            this.txtbox_output.Name = "txtbox_output";
            this.txtbox_output.Size = new System.Drawing.Size(469, 295);
            this.txtbox_output.TabIndex = 0;
            this.txtbox_output.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(469, 295);
            this.Controls.Add(this.txtbox_output);
            this.Name = "Form2";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox txtbox_output;
    }
}