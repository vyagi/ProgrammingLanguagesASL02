using System;
using System.Collections.Generic;
using System.Globalization;
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

            var invoices = new List<Invoice>();
            foreach (var line in lines)
            {
                var split = line.Split('\t');
                var name = split[0];
                var date = DateTime.ParseExact(split[1], "yyyy-MM-dd", null);
                var amount = Convert.ToDecimal(split[2].Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)); // 120.21

                var invoice = new Invoice(name, date, amount);
                invoices.Add(invoice);
            }
            //Old school way
            var result = new Dictionary<string, decimal>();

            foreach (var invoice in invoices)
            {
                if (!result.ContainsKey(invoice.Name))
                {
                    result[invoice.Name] = invoice.Amount;
                }
                else
                {
                    result[invoice.Name] += invoice.Amount;
                }
            }

            resultTextBox.Text = "";
            foreach (var entry in result.OrderBy(x=>x.Key))
            {
                resultTextBox.Text += $"{entry.Key}: {entry.Value}\r\n";
            }

            
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