using ASP_OneLove.Models.Products.Enums;

namespace ASP_OneLove.Models.Products.Electronics
{
    public class SlowCooker : Product // Мультиварка
    {
        public string Model { get; set; }

        public Volume Volume { get; set; }

        public int WeightInKg { get; set; }

        public int PowerInWatt { get; set; }

        public Language Language { get; set; }

        public byte AmountOfPrograms { get; set; }

        public Programs Programs { get; set; } // Empty

        public bool ExistenceOfDisplay { get; set; }
    }

    public enum Programs // TODO: set names of programs
    {

    }
    
}

