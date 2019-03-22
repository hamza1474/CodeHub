using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emily_s_Magic_Box
{
    public partial class Form1 : Form
    {
        Stack<string> fruits = new Stack<string>();
        Stack<string> checkArray = new Stack<string>();
        Dictionary<string, int> ht = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Txt_fruit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_addFruit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ht.ContainsKey(txt_fruit.Text))
                {

                    foreach (string k in ht.Keys.ToList())
                    {
                        if (txt_fruit.Text == k)
                        {
                            ht[k] += 1;
                        }

                    }
                }
                else ht.Add(txt_fruit.Text, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_fruit.Clear();
        }

        private void Btn_showResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newInstance = new Form2();
            newInstance.txt_Result.Text = "You Have \n";
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SpeakAsync("You Have ");
            foreach (string k in ht.Keys.ToList())
            {
                newInstance.txt_Result.AppendText(Convert.ToString(ht[k]) + " " + k + "\n");
                newInstance.Show();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = 0;     // -10...10

                // Synchronous
                synthesizer.Speak(Convert.ToString(ht[k]) + " " + k + "\n");
                Close();

            }


        }
    }
}
