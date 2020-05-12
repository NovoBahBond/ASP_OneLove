namespace ASP_OneLove.Models
{
    public class WashingMachine : Product
    {
        public string Model { get; set; }

        public Size Size { get; set; }

        public double WeightInKg { get; set; }

        public int SpeedOFPressInMin { get; set; }

        public int AmountOfPrograms { get; set; } // Usually washing machines have different programs for different materials

        public bool ExistenceOfDisplay { get; set; }
    }
}

