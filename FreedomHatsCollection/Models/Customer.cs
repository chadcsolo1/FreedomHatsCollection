using System.ComponentModel.DataAnnotations;

namespace FreedomHatsCollection.Models
{
    public class Customer
    {
        public int CustomerId
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        } = string.Empty;

        public string LastName
        {
            get;
            set;
        } = string.Empty;
        public string Email
        {
            get;
            set;
        } = string.Empty;
        public string Password
        {
            get;
            set;
        } = string.Empty;
        public string Address
        {
            get;
            set;
        } = string.Empty;
        public DateOnly DateOfBirth
        {
            get;
            set;
        }
        public DateOnly AccountCreationDate
        {
            get;
            set;
        }
        [Required]
        public List<Orders> OrderHistory
        {
            get;
            set;
        } = new List<Orders>();
        public List<PaymentMethod> PaymentMethods
        {
            get;
            set;
        } = new List<PaymentMethod>();
        public DateTime AccountUpdatedDate
        {
            get;
            set;
        }
        public string AccountStatus
        {
            get;
            set;
        } = string.Empty;


    }
}
