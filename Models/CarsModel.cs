using CarShop.Pages.Forms;

namespace CarShop.Models
{
    public class CarsModel
    {
        public string ImageTitle { get; set; } = "customCar";
        public string CarName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool Spoiler { get; set; }
        public bool FurSeats { get; set; }
        public bool PinkSeatBelts { get; set; }
        public bool NeonHeadlights { get; set; }
        public bool MilkEngine { get; set; }
        public bool LittleSunflower { get; set; }
        public int FinalPrice { get; set; }
        public int Style { get; set; } = 1;
        public int Speed { get; set; } = 1;
        public int Comfort { get; set; } = 1;
        public string Features { get; set; }
        public int Points { get; set; } = 3;

    }
}
