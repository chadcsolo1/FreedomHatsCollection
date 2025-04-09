using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreedomHatsCollection.Models
{
    public class Order
    {
        [Key]
        public int Id
        {
            get;
            set;
        }

        [ForeignKey("Customer")] // Specify the related navigation property or table name  
        public int CustomerId
        {
            get;
            set;
        }

        public DateTime OrderDateCreated
        {
            get;
            set;
        }

        public string OrderStatus
        {
            get;
            set;
        } = string.Empty;

        public decimal TotalAmount
        {
            get;
            set;
        }

        public string PaymentStatus
        {
            get;
            set;
        } = string.Empty;

        public string PaymentMethod
        {
            get;
            set;
        } = string.Empty;

        public DateTime PaymentDate
        {
            get;
            set;
        }

        public int ProductId
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public decimal PricePerUnit
        {
            get;
            set;
        }

        public decimal Subtotal
        {
            get;
            set;
        }

        public List<Product> LineItems
        {
            get;
            set;
        } = new List<Product>();

        public OrderDetails? OrderDetails
        {
            get;
            set;
        }
    }
}
