namespace ASP_OneLove.Models
{
    public abstract class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Brand BrandName { get; set; }

        public string Description { get; set; }

        public byte? GuaranteeInMonth { get; set; } // Be careful with this. in Controllers use methods that can return default value!

        public double Price { get; set; }

    }
    public enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White
    }

    public enum Material
    {
        Cotton,
        Polyester,
        Leather,
        Wood,
        Plastic,
        Metal
    }

    public enum Country
    {
        China,
        Italy,
        USA,
        Germany,
    }
}
