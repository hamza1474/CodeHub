using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Company
{
    public partial class Form1 : Form
    {
        
        List<String> res = new List<string>();
        static int payrollCount;
        static string instanceName;
        static int instanceAge;
        static int instanceSalary;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
         
            

            Employee.success = false;
            

            switch (combo_designation.SelectedIndex)
            {
                

                case 0:
                    {

                        Manager manager = new Manager(txt_name.Text, int.Parse(txt_sal.Text));
                        instanceName = manager.name;
                        manager.SetSalary = int.Parse(txt_sal.Text);
                        instanceSalary = manager.GetSalary();
                       
                        break;
                    }
                case 1:
                    {

                        Worker worker = new Worker(txt_name.Text, int.Parse(txt_age.Text), int.Parse(txt_sal.Text));
                        instanceName = worker.name;
                        instanceAge = worker.age;
                        worker.SetSalary = int.Parse(txt_sal.Text);
                        instanceSalary = worker.GetSalary();
                       
                        break;
                    }


                case 2:
                    {

                        Sweeper sweeper = new Sweeper(txt_name.Text, int.Parse(txt_sal.Text));
                        instanceName = sweeper.name;
                        instanceSalary = sweeper.GetSalary();
                        
                        break;
                    }
            }
            if (Employee.success == true)
            {
                payrollCount++;

            }

            string payroll = ($"Name : {instanceName}   Designation : {combo_designation.Text}   Salary : {instanceSalary} ");
            res.Add(payroll + "\n");


            lbl_payrollCount.Text = Convert.ToString(payrollCount);

            if (payrollCount == 10)
            {
               Form2 output = new Form2();
                output.txtbox_output.Lines = res.ToArray();
                output.Show();
                payrollCount = 0;
                res.Clear();
            }

        }


        private void ClearTextboxes()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void Combo_designation_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClearTextboxes();
            switch (combo_designation.SelectedIndex)
            {
                case 0:
                    {
                        ClearTextboxes();
                        txt_name.Enabled = true;
                        txt_age.Enabled = false;
                        txt_age.Text = "[not required]";
                        txt_sal.Enabled = true;

                        break;
                    }
                case 1:
                    {
                        txt_name.Enabled = true;
                        txt_age.Enabled = true;
                        txt_sal.Enabled = true;

                        break;
                    }
                case 2:
                    {
                        txt_name.Enabled = true;
                        txt_age.Enabled = false;
                        txt_age.Text = "[not required]";
                        txt_sal.Enabled = false;
                        txt_sal.Text = "10000";

                        break;
                    }
                default:
                    break;
            }
        }
    }
}

