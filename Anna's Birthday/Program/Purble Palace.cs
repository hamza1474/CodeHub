using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anna_s_Birthday
{
    public partial class PurblePalace : Form
    {
        int noOfChocolateCakes = 0;
        int noOfIceCakes = 0;
        
        Stack<string> cake = new Stack<string>();
        string[] cakeArray;
        IceCakes iceCakesObject = new IceCakes();
        ChocolateCakes chocolateCakesObject = new ChocolateCakes();

        public PurblePalace()
        {
            InitializeComponent();

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (txt_typeOfCake.Text.ToLower() == "icecake")
            {
                cake.Push(txt_typeOfCake.Text);
                noOfIceCakes += 1;

            }
            else if (txt_typeOfCake.Text.ToLower() == "chocolatecake")
            {
                cake.Push(txt_typeOfCake.Text);
                noOfChocolateCakes += 1;
            }
            else MessageBox.Show("Invalid Type Of Cake", "Error");
            txt_typeOfCake.Clear();
            lbl_chcount.Text = Convert.ToString(noOfChocolateCakes);
            lbl_icecount.Text = Convert.ToString(noOfIceCakes);
            cakeArray = cake.ToArray();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Cake.totalPerson!=0)
            {
                Cake.totalPerson = 0;
            }
            if (cakeArray != null)
            {
                getCount(cakeArray);
                lbl_result.Text = Convert.ToString(Cake.totalPerson) + " people can be served";
            }
            else MessageBox.Show("No Cakes Added", "Error");
            }
        private void getCount(String[] cakeArray)
        {
            try
            {
                for (int i = 0; i < cakeArray.Length; i++)
                {
                    if (cakeArray[i] == "icecake")
                    {
                        iceCakesObject.addPeople();
                    }
                    else if (cakeArray[i] == "chocolatecake")
                    {
                        chocolateCakesObject.addPeople();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
