using CarShop.Data;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarShop.Pages
{
    public class CarModel : PageModel
    {

        public List<CarsModel> fakeCarDB = new List<CarsModel>()
        {
            new CarsModel(){
                ImageTitle = "coolCar",
                CarName = "Cool",
                BasePrice = 2,
                NeonHeadlights = true,
                Spoiler = true,
                MilkEngine = true,
                FinalPrice = 4,
                Speed = 4,
                Style = 3,
                Comfort = 1,
                Points = 8,
                Features = "neon Headlights, spoiler and milk engine"},
            new CarsModel(){
                ImageTitle = "fancyCar",
                CarName = "Fancy",
                BasePrice = 2,
                PinkSeatBelts = true,
                FurSeats = true,
                LittleSunflower = true,
                FinalPrice = 4,
                Speed = 1,
                Style = 5,
                Comfort = 4,
                Points = 10,
                Features = "pink Seatbelts, fur seats and little sunflower"},
            new CarsModel(){
                ImageTitle = "niceBalanceCar",
                CarName = "Nice Balance",
                BasePrice = 2,
                PinkSeatBelts = true,
                NeonHeadlights = true,
                LittleSunflower = true,
                MilkEngine = true,
                FinalPrice = 6,
                Speed = 4,
                Style = 4,
                Comfort = 3,
                Points = 11,
                Features = "pink Seatbelts, neon headlights, milk engine and little sunflower"},
            new CarsModel(){
                ImageTitle = "allCar",
                CarName = "Everything-in",
                BasePrice = 2,
                PinkSeatBelts = true,
                NeonHeadlights = true,
                MilkEngine = true,
                Spoiler = true,
                FurSeats = true,
                LittleSunflower = true,
                FinalPrice = 8,
                Speed = 4,
                Style = 6,
                Comfort = 6,
                Points = 16,
                Features = "pink Seatbelts, neon headlights, milk engine, spoiler, fur seats and little sunflower"}
        };

        public void OnGet()
        {

        }
    }
}
