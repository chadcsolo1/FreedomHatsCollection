using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreedomHatsCollection.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        [ForeignKey("Order")] // Specify the related navigation property or table name
        public int OrderId
        {
            get;
            set;
        }
        [ForeignKey("Product")] // Specify the related navigation property or table name
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
    }
}
