using System.ComponentModel.DataAnnotations;

namespace FreedomHatsCollection.Models
{
    public class Customer
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        [Required]
        public string FirstName
        {
            get;
            set;
        } = string.Empty;
        [Required]
        public string LastName
        {
            get;
            set;
        } = string.Empty;
        [Required]
        public string Email
        {
            get;
            set;
        } = string.Empty;
        [Required]
        public string Password
        {
            get;
            set;
        } = string.Empty;
        [Required]
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
        [Required]
        public DateOnly AccountCreationDate
        {
            get;
            set;
        } = DateOnly.FromDateTime(DateTime.Now);
        [Required]
        public List<Order> OrderHistory
        {
            get;
            set;
        } = new List<Order>();

        public List<PaymentMethod> PaymentMethods
        {
            get;
            set;
        } = new List<PaymentMethod>();
        public DateTime? AccountUpdatedDate
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
