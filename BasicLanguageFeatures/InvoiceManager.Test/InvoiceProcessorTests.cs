using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using InvoiceManager.Service;
using Moq;
using Xunit;

namespace InvoiceManager.Test
{
    public class InvoiceProcessorTests
    {
        [Fact]
        public void Test1()
        {
            var lineProviderMock = new Mock<IInvoiceLineProvider>();
            lineProviderMock
                .Setup(x => x.GetLines())
                .Returns(lines);

            var processor = new InvoiceProcessor(lineProviderMock.Object);

            var invoices = processor.GetInvoices();
            invoices.Should().HaveCount(2);
            invoices.First().Name.Should().Be("Marcin");
        }

        List<string> lines = new List<string>
        {
            "Marcin\t2020-12-16\t12",
            "John\t2020-12-17\t100",
        };
    }
}
