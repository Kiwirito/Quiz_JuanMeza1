using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_JuanMeza
{
    public partial class Home : Form
    {
        private string boxer1 = string.Empty;
  
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(box1.Text))
            {
                MessageBox.Show("Primero debes poner un producto");
            }
            else
            {
               
                if (Depar.Checked == true)
                {
                    boxer1 = boxer1 + " - " + Depar.Text;
                }
                if (Inter.Checked == true)
                {
                    boxer1 = boxer1 + " - " + Inter.Text;
                }
                if (Regi.Checked == true)
                {
                    boxer1 = boxer1 + " - " + Regi.Text;
                }
                if (Naci.Checked == true)
                {
                    boxer1 = boxer1 + " - " + Naci.Text;
                }
                rtxtResults.Text = rtxtResults.Text + "\n" + "---------------------------------------------" + "\n" + box1.Text + "\n" + dateTimePicker1.Value + "\n" + comboBox1.SelectedItem + "\n" + listBox1.SelectedItem + "\n" + boxer1 + "\n" + "---------------------------------------------";
                boxer1 = string.Empty;
                box1.Clear();
                comboBox1.Text = string.Empty;
                listBox1.ClearSelected();
                Depar.Checked = false;
                Inter.Checked = false;
                Regi.Checked = false;
                Naci.Checked = false;
            }
















        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form2 sf = new Form2())
            {
                sf.InfoReporte = rtxtResults.Text;
                sf.ShowDialog();
            }
        }
    }
}
