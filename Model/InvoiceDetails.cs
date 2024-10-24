using System.ComponentModel.DataAnnotations;

namespace task.Model
{
    public class InvoiceDetails
    {

        public int id { get; set; }

        public InvoiceDetails(int lineNo, string productName, int unitNo, decimal price, decimal quantity, decimal total, DateTime expiryDate)
        {
            this.lineNo = lineNo;
            this.productName = productName;
            this.unitNo = unitNo;
            this.price = price;
            this.quantity = quantity;
            this.total = total;
            this.expiryDate = expiryDate;
        }

        public int lineNo { get; set; }
        [MaxLength(100)]
        public string productName { get; set; }
        public int unitNo { get; set; }
        public decimal price { get; set; }  
        public decimal quantity { get; set; }
        public decimal total { get; set; }
        public DateTime expiryDate { get; set; }
    }
}
