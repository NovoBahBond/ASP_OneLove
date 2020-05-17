using ASP_OneLove.Models.Products.Enums;

namespace ASP_OneLove.Models.Products
{
    public class Furniture : Product
    {
        public FurnitureStats Stats { get; set; }

        public FurnitureCategory Category { get; set; }
    }
    
    
}

