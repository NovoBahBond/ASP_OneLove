namespace ASP_OneLove.Models
{
    public class ClothesStats
    {
        public Size Size { get; set; }

        public Color Color { get; set; }

        public Material Material { get; set; }

        public Country Country { get; set; }
    }

    public enum Size
    {
        xs,
        s,
        m,
        l,
        xl,
        xxl
    }
    
}
