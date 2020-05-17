using ASP_OneLove.Models.Products.Enums;

namespace ASP_OneLove.Models.Products
{
    public class Clothes : Product
    {
        public Sex Sex { get; set; }
        
        public ClothesSize Size { get; set; }

        public ClothesCategory Category { get; set; }
    }
    
}
