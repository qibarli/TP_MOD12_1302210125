using System.Xml;

namespace TP_MOD12_1302210125
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
            string ouput = CTB.CariTandaBilangan(input);
            label1.Text = ouput;
        }
    }
}