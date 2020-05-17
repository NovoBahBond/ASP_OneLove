namespace ASP_OneLove.Models.Products.Electronics
{
    public class WashingMachine : Product
    {
        public string Model { get; set; }

        public Volume Volume { get; set; }

        public double WeightInKg { get; set; }

        public int SpeedOfPressInMin { get; set; }

        public int AmountOfPrograms { get; set; } // Usually washing machines have different programs for different materials

        public bool ExistenceOfDisplay { get; set; }
    }
}

