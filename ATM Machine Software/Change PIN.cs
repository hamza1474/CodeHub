using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine_Software
{
    public partial class Change_PIN : Form
    {
        public Change_PIN()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string oldPIN = txt_oldPin.Text;
            string newPIN = txt_newPin.Text;
            if (int.Parse(oldPIN) == EnterPin.PIN)
            {
                try
                {
                    if (oldPIN != newPIN)
                    {
                        Form1.dataSetSource.ChangePin(newPIN);
                        MessageBox.Show("PIN Changed Successfully", "Success");
                        
                    }

                    else MessageBox.Show("Old PIN and New PIN cannot be same");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            else MessageBox.Show("Old PIN does not match ", "Error");

        }
    }
}
