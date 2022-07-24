using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, toplam = 0, kdvharic;
            fiyat = Convert.ToSingle(textBox1.Text);
            label5.Text = fiyat.ToString();

            if (radioButton1.Checked == true)
            {
                toplam = fiyat * 1.18;
                kdvharic = fiyat * 0.18;
                label8.Text = kdvharic.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                toplam = fiyat * 1.08;
                kdvharic = fiyat * 0.08;
                label8.Text = kdvharic.ToString();
            }
            else if (radioButton3.Checked == true)
            {
                toplam = fiyat * 1.01;
                kdvharic = fiyat * 0.01;
                label8.Text = kdvharic.ToString();
            }
            label6.Text = toplam.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
