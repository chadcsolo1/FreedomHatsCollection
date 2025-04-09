using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreedomHatsCollection.Models
{
    public class PaymentMethod
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
        [Required]
        public string BillingAddress
        {
            get;
            set;
        } = string.Empty;
        [Required]
        public int CardNumber
        {
            get;
            set;
        }
        [Required]
        public DateOnly ExpirationDate
        {
            get;
            set;
        }
        [Required]
        public int CSV
        {
            get;
            set;
        }
        [Required]
        public Provider PaymentProvider
        {
            get;
            set;
        } = Provider.Visa;
        [Required]
        public PaymentMethodType PaymentMethod_Type
        {
            get;
            set;
        } = PaymentMethodType.CreditCard;


    }

        public enum PaymentMethodType
        {
            CreditCard,
            DebitCard,
            PayPal,
            BankAccount

        }
        public enum Provider
        {
            Visa,
            MasterCard,
            AmericanExpress,
            Discover,
            PayPal,
            BankTransfer
        }
}
