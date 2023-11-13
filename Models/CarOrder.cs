namespace CarShop.Models
{
    public class CarOrder
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public float BasePrice { get; set; }
        public int Points { get; set; }
        public int Style { get; set; }
        public int Comfort { get; set; }
        public int Speed { get; set; }
    }
}
