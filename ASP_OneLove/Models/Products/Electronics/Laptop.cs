namespace ASP_OneLove.Models.Products.Electronics
{
    public class Laptop : Product
    {
        public string Model { get; set; }

        public Volume Volume { get; set; }

        public int WeightInKg { get; set; }

        public double ScreenDiagonal { get; set; }

        public TypeOfMatrix Matrix { get; set; }

        public byte ScreenUpdateRate { get; set; }

        public Proccesor Proccesor { get; set; }

        public GraphicCard GraphicCard { get; set; }

        public RAM TypeOfRAM { get; set; }

        public byte AmountOfRAM { get; set; } // In GB

        public int BatterySize { get; set; } // in Watt/hour

        public OperatingSystem OperatingSystem { get; set; }

        public int DriveSize { get; set; }
    }

    public class GraphicCard
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public Brand Brand { get; set; }

        public byte MemorySizeInGB { get; set; }

        public GraphicMemoryType MemoryType { get; set; }

        public double RateInMGC { get; set; }

        public Volume Volume { get; set; }
    }

    public class RAM // Probably should add timings 
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public Brand Brand { get; set; }

        public RAMGeneration Generation { get; set; }

        public int Speed { get; set; }

        public byte CapacityInGB { get; set; }
    }

    public class Proccesor
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public Brand BrandName { get; set; }

        public Socket Socket { get; set; } // Empty

        public double RateInGGC { get; set; }

        public byte AmountOfCores { get; set; }

        public byte AmountOdThreads { get; set; }

        public byte TecknologyInNM { get; set; } // Nanometres

        public int PowerInWatts { get; set; }
    }

    public enum GraphicMemoryType
    {
        GDDR3,
        GDDR4,
        GDDR5
    }
    public enum TypeOfMatrix
    {
        IPS,
        TFT,
        VA,
        TN
    }    
    public enum RAMGeneration
    {
        DDR3,
        DDR4
    }
    public enum OperatingSystem
    {
        Windows,
        MacOS,
        DOS
    }    
    public enum Socket // TODO: set types of sockets!
    {

    }
}
