namespace ASP_OneLove.Models
{
    public class Clothes : Product
    {
        public ClothesStats Stats { get; set; }

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
}
