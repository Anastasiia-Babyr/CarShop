using CarShop.Data;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarShop.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        
        public string CarName { get; set; }
        public float CarPrice { get; set; }
        public string ImageTitle { get; set; }
        public int CarPoints { get; set; }
        public int CarStyle { get; set; }
        public int CarSpeed { get; set; }
        public int CarComfort { get; set; }


        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
               _context = context;
        }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(CarName))
            {
                CarName = "Custom";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "customCar";
            }

            CarOrder carOrder = new CarOrder();
            carOrder.CarName = CarName;
            carOrder.BasePrice = CarPrice;
            carOrder.Points = CarPoints;
            carOrder.Style = CarStyle;
            carOrder.Speed = CarSpeed;
            carOrder.Comfort = CarComfort;


            _context.CarOrders.Add(carOrder);
            _context.SaveChanges();
        }
    }
}
