using ASP_OneLove.Models.Products;
using ASP_OneLove.Models.Products.Enums;

namespace ASP_OneLove.Models
{
    public abstract class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Brand Brand { get; set; }

        public string Description { get; set; }

        public byte? GuaranteeInMonth { get; set; } // Be careful with this. in Controllers use methods that can return default value!

        public Material Material { get; set; }

        public Color Color { get; set; }

        public Country Country { get; set; }

        public double Price { get; set; }

        public bool IsAvailable => AmountInStock > 0;

        public int AmountInStock { get; set; }
    }
    
}
