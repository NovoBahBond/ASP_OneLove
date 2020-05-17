namespace ASP_OneLove.Models.Products.Electronics
{        
    public class VacuumCleaner : Product
    {
        public string Model { get; set; }

        public Volume Volume { get; set; }

        public double WeightInKg { get; set; }

        public TypeOfCleaning TypeOfCleaning { get; set; }

        public int SuckingPower { get; set; }

        public int PowerConsumptionInWatts { get; set; }

        public int LengthOfCordInMetres { get; set; }

        public int LevelOfNoiseInDb { get; set; } // decibels

        public int RadiusOfCleaningInMetres { get; set; }
    }

    public enum TypeOfCleaning
    {
        Dry,
        Wet
    }
}

