using System;
using System.IO;
using System.Linq;
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

        private void totalByNamesButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot proceed");
                return;
            }

            var lines = File.ReadAllLines(path).Skip(1);

        }
    }

    public class Invoice
    {
        public string Name { get; }
        public DateTime DateTime { get; }
        public decimal Amount { get; }

        public Invoice(string name, DateTime dateTime, decimal amount)
        {
            Name = name;
            DateTime = dateTime;
            Amount = amount;
        }
    }
}