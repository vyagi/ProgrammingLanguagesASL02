using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using InvoiceManager.Service;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        private readonly FileInvoiceProcessorFactory _factory;

        public Form1(FileInvoiceProcessorFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var invoiceProcessor = _factory.Create(pathTextBox.Text);

                resultTextBox.Text = string.Join("\r\n", invoiceProcessor.GetInvoices().Select(x => $"{x.Name}\t{x.DateTime}\t{x.Amount}"));
            }
            catch (Exception)
            {
                MessageBox.Show("Error ocurred", "Error");
            }
        }

        private void totalByNamesButton_Click(object sender, EventArgs e)
        {
            try
            {
                var invoiceProcessor = _factory.Create(pathTextBox.Text);

                var result = invoiceProcessor.GetInvoicesGroupedByNames();

                resultTextBox.Text = string.Join("\r\n", result.Select(x => $"{x.Name}: {x.Amount}"));
            }
            catch (Exception)
            {
                MessageBox.Show("Error ocurred", "Error");

            }
        }
    }
}