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
    public partial class Form1 : Form
    {
        internal static int balance;
        internal static DataSetSource dataSetSource;
        internal static string firstName;
        internal static string lastName;
        public Form1()
        {

            dataSetSource = new DataSetSource();
            InitializeComponent();

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            firstName = txtbox_firstName.Text;
            lastName = txtbox_lastName.Text;
            try
            {
                if (firstName != "" && lastName != "")
                {
                    this.Hide();
                    EnterPin enterPin = new EnterPin();
                    enterPin.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
