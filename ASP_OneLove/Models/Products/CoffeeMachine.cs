namespace ASP_OneLove.Models
{
    public class CoffeeMachine : Product
    {
        public string Model { get; set; }

        public Size Size { get; set; }

        public int WeightInKg { get; set; }

        public int VolumeForWaterInL { get; set; } // Litres

        public int VolumeForGrain { get; set; } // Зерна

        public int PowerInWatt { get; set; }

        public byte Pressure { get; set; } // В барах

        public bool ExistenceOfDisplay { get; set; }    
    }
}

