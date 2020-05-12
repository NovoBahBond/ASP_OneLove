namespace ASP_OneLove.Models
{
    public class Furniture : Product
    {
        public FurnitureStats Stats { get; set; }

        public FurnitureCategory Category { get; set; }
    }
    
    public enum FurnitureCategory
    {
        Chair,
        Armchair,
        Table,
        Desk,
        Sofa,
        Closet 
    }
}

