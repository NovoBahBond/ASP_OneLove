namespace ASP_OneLove.Models.Products.Electronics
{
    public class Fridge : Product
    {
        public string Model { get; set; }

        public Volume Volume { get; set; }

        public double WeightInKg { get; set; }

        public double Noise { get; set; }
    }

}

