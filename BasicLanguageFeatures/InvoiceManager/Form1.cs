using System;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e) => 
            checkBox1.Checked = textBox1.Text.Contains(" ");
    }
}