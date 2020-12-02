using System;
using System.IO;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot proceed");
                return;
            }

            resultTextBox.Text = File.ReadAllText(path);
        }
    }
}