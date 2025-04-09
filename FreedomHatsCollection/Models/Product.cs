using System.ComponentModel.DataAnnotations;

namespace FreedomHatsCollection.Models
{
    public class Product
    {
        [Key]
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
        [Required]
        public int StockQuantity
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
        } = DateOnly.FromDateTime(DateTime.Now);

        public Style Styles
        {
            get;
            set;
        }
        public Size Sizes
        {
            get;
            set;
        }
        public Color Colors
        {
            get;
            set;
        }


    }

            public enum Style
        {
            BaseballCap,
            Beanie,
            BucketHat,
            Snapback,
            DadHat,
            TruckerHat,
            Visor,
            Fedora,
            NewsboyCap,
            SunHat
        }
        public enum Size
        {
            Small,
            Medium,
            Large,
            ExtraLarge
        }
        public enum Color
        {
            Red,
            Blue,
            Green,
            Yellow,
            Black,
            White,
            Gray,
            Pink,
            Purple,
            Orange
        }
}
