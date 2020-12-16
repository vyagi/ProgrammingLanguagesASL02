using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace InvoiceManager.Service
{
    public class FileInvoiceProcessorFactory
    {
        public InvoiceProcessor Create(string path) => 
            new InvoiceProcessor(new FileInvoiceLineProvider(path));
    }
    
    public interface IInvoiceLineProvider
    {
        IEnumerable<string> GetLines();
    }

    public class FileInvoiceLineProvider: IInvoiceLineProvider
    {
        private readonly string _path;

        public FileInvoiceLineProvider(string path)
        {
            if (!File.Exists(path))
                throw new ArgumentException("File not found");

            _path = path;
        }
        public IEnumerable<string> GetLines() => File.ReadLines(_path).Skip(1);
    }

    public class InvoiceProcessor
    {
        private readonly IList<Invoice> _invoices = new List<Invoice>(); 
        
        public InvoiceProcessor(IInvoiceLineProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            foreach (var line in provider.GetLines())
            {
                var split = line.Split('\t');

                var date = DateTime.ParseExact(split[1], "yyyy-MM-dd", null);
                var amount = Convert.ToDecimal(split[2].Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));

                _invoices.Add(new Invoice(split[0], date, amount));
            }
        }

        public IEnumerable<Invoice> GetInvoices() => _invoices;

        public IEnumerable<(string Name, decimal Amount)> GetInvoicesGroupedByNames() =>
            _invoices
                .GroupBy(x => x.Name)
                .Select(x => (x.Key, x.Sum(y => y.Amount)));
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
