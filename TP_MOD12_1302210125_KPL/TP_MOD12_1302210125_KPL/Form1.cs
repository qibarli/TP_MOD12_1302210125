using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MOD12_1302210125_KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            string ouput = CariTandaBilangan(input);
            label1.Text = ouput;
        }

        public string CariTandaBilangan(int a)
        {
            if (a == 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else if (a == 0)
            {
                return "Nol";
            }
            return "Input Tidak Valid";
        }
    }
}
