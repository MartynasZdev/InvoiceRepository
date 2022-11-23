using InvoiceingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceingSystem.Repositories
{
    internal class InvoiceRepository
    {
        public List<Invoice> Invoices { get; set; }
        public InvoiceRepository()
        {
            if (Invoices == null)
            {
                Invoices = new List<Invoice>();

                for (int i = 1; i <= 5; i++)
                {
                    Invoices.Add(new Invoice(i, GenerateInvoiceItems()));
                }
            }
        }
        public static List<int> GenerateInvoiceItems()
        {
            List<int> listRange = new();
            Random rd = new();
            for (int i = 0; i < rd.Next(1, 5); i++)
            {
                listRange.Add(rd.Next(1, 5));
            }

            return listRange;
        }

        public List<Invoice> Retrieve()
        {
            return Invoices;
        }
    }
}
