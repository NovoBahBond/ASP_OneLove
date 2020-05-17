namespace ASP_OneLove.Models.Products.Electronics
{
    public class CoffeeMachine : Product
    {
        public string Model { get; set; }

        public Volume Volume { get; set; }

        public int WeightInKg { get; set; }

        public int WaterVolumeL { get; set; } // Litres

        public int GrainVolume { get; set; } // Зерна

        public int PowerInWatt { get; set; }

        public byte Pressure { get; set; } // В барах

        public bool ExistenceOfDisplay { get; set; }
    }
}

