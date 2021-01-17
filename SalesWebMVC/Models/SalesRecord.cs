using SalesWebMVC.Models.Enums;
using System;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int SalesRecordId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int salesRecordId, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            SalesRecordId = salesRecordId;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
