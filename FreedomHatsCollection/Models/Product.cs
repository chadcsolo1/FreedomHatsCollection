using System.ComponentModel.DataAnnotations;

namespace FreedomHatsCollection.Models
{
    public class Product
    {
        public int Id
        {
            get;
            set;
        }
        [Required]
        public string Name
        {
            get;
            set;
        } = string.Empty;

        public string ProductDescription
        {
            get;
            set;
        } = string.Empty;
        [Range(1, 1000)]
        public double Price
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public bool ShowProperties
        {
            get;
            set;
        }
        public DateOnly AvailableAfter
        {
            get;
            set;
        }

        public IEnumerable<Product_Properties> Style
        {
            get;
            set;
        }

        public IEnumerable<Product_Properties> Size
        {
            get;
            set;
        }

        public IEnumerable<Product_Properties> Color
        {
            get;
            set;
        }


    }
}
