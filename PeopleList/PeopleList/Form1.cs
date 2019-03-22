using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleList
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();

            InfoBox.DataSource = customers;
            InfoBox.DisplayMember = "FullInfo";
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            customers = db.GetCustomers(txtCity.Text);
            InfoBox.DataSource = customers;
            InfoBox.DisplayMember = "FullInfo";
        }

        private void InfoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
