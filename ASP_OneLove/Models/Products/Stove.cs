using ASP_OneLove.Models.Products.Enums;

namespace ASP_OneLove.Models.Products
{
    public class Stove : Product
    {
        public string Model { get; set; }

        public Volume Volume { get; set; }

        public double WeightInKg { get; set; }

        public StoveType Type { get; set; }

        public int PowerConsumptionInWatts { get; set; }

        public int PowerInWatts { get; set; }

        public byte AmountOfBurners { get; set; }

        public bool ExistenceOfDisplay { get; set; }

        public bool ExistenceOfOven { get; set; }
    }
    
}

