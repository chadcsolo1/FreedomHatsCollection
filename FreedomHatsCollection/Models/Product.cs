namespace FreedomHatsCollection.Models
{
    public class Product
    {
        public int Id
        {
            get;
            set;
        }

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
    }
}
