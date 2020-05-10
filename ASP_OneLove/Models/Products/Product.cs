namespace ASP_OneLove.Models
{   
    public abstract class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Brand BrandName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

    }
    public enum Color
    {
        red,
        green,
        blue,
        yellow,
        black,
        white
    }

    public enum Country
    {
        China,
        Italy,
        USA,
        Germany,
    }
}
