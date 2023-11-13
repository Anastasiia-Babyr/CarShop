using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarShop.Models;

namespace CarShop.Pages.Forms
{
    public class CustomCarModel : PageModel
    {
        [BindProperty]
        public CarsModel Car { get; set; }
        public float CarPrice { get; set; }
        public int CarPoints { get; set; }
        public int CarStyle { get; set; }
        public int CarComfort { get; set; }
        public int CarSpeed { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            CarPrice = Car.BasePrice;
            CarPoints = Car.Points;
            CarStyle = Car.Style;
            CarComfort = Car.Comfort;
            CarSpeed = Car.Speed;


            if (Car.FurSeats) CarPrice += 1;
            if (Car.Spoiler) CarPrice += 2;
            if (Car.PinkSeatBelts) CarPrice += 3;
            if (Car.NeonHeadlights) CarPrice += 4;
            if (Car.MilkEngine) CarPrice += 5;
            if (Car.LittleSunflower) CarPrice += 6;
            if (Car.FurSeats) CarStyle += 2;
            if (Car.FurSeats) CarComfort += 1;
            if (Car.Spoiler) CarStyle += 1;
            if (Car.PinkSeatBelts) CarStyle += 1;
            if (Car.PinkSeatBelts) CarComfort += 1;
            if (Car.NeonHeadlights) CarStyle += 1;
            if (Car.MilkEngine) CarSpeed += 3;
            if (Car.LittleSunflower) CarStyle += 1;
            if (Car.LittleSunflower) CarComfort += 1;
            CarPoints = CarStyle + CarComfort + CarSpeed;

            return RedirectToPage("/Checkout/Checkout", new {Car.CarName, CarPrice, CarPoints, CarStyle, CarComfort, CarSpeed });
        }
    }
}
