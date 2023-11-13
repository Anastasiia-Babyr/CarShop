using CarShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarShop.Pages
{
    public class RaceModel : PageModel
    {
        public int CarPoints { get; set; }
        public int CarStyle { get; set; }
        public int CarSpeed { get; set; }
        public int CarComfort { get; set; }
        public string carName { get; set; }


        private readonly ApplicationDbContext _context;
        public RaceModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(string CarName)
        {
            carName = CarName;

            var lastCarOrder = _context.CarOrders.OrderByDescending(order => order.Id).FirstOrDefault();
            if (lastCarOrder != null)
            {
                CarPoints = lastCarOrder.Points;
                CarSpeed = lastCarOrder.Speed;
                CarStyle = lastCarOrder.Style;
                CarComfort = lastCarOrder.Comfort;
            }
        }
    }
}
