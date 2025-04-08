using System.ComponentModel.DataAnnotations;

namespace FreedomHatsCollection.Models
{
    public class Orders
    {
        [Key]
        public int OrderId
        {
            get;
            set;
        }

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
        }

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

    }
}
