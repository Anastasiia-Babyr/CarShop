using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarShop.Models;
using CarShop.Data;

namespace CarShop.Pages
{
    public class OrdersModel : PageModel
    {
        public List<CarOrder> CarOrders = new List<CarOrder>();

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            CarOrders = _context.CarOrders.ToList();
        }
    }
}
