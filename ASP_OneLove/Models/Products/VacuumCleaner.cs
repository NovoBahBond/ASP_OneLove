namespace ASP_OneLove.Models
{        
    public class VacuumCleaner : Product
    {
        public string Model { get; set; }

        public Size Size { get; set; }

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

