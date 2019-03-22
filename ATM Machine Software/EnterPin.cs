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
    public partial class EnterPin : Form
    {
        internal static DataSet newDS;
        internal static int PIN;
        internal static string accountNumber;
        public EnterPin()
        {
            string strExpr = $"FirstName = '{Form1.firstName}' AND LastName = '{Form1.lastName}'";
            var dv = Form1.dataSetSource.dataSet.Tables[0].DefaultView;
            dv.RowFilter = strExpr;
            newDS = new DataSet();
            var newDT = dv.ToTable();
            newDS.Tables.Add(newDT);
            accountNumber = newDS.Tables[0].Rows[0]["ATMDataID"].ToString();
            InitializeComponent();
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            
            PIN = int.Parse(newDS.Tables[0].Rows[0]["PIN"].ToString());
            try
            {
                if (PIN == int.Parse(enterPinTextBox.Text))
                {
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
                else MessageBox.Show("Wrong PIN", "Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
