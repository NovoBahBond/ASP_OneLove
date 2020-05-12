namespace ASP_OneLove.Models
{
    public class Clothes : Product
    {
        public ClothesSize Size { get; set; }

        public ClothesCategory Category { get; set; }
    }

    public enum ClothesCategory
    {
        Pants,
        Coat,
        Suit,
        Shirt,
        Jeans,
        Dress,
        Underwear,
        Nightdress
    }

    public enum ClothesSize
    {
        xs,
        s,
        m,
        l,
        xl,
        xxl
    }
}
