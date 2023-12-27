using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AYAlab12.Pages.MenuList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db) { _db = db; }
        public List<MenuWithRestaurant> MenuWithRestaurantsList { get; set; }
        public void OnGet()
        {
            MenuWithRestaurantsList = _db.Menu.Select(menu => new MenuWithRestaurant
            {
                Menu = menu,
                Restaurant = _db.Restaurant.FirstOrDefault(r => r.Id == menu.RestarauntId)
            }).ToList();
        }
    }

    public class MenuWithRestaurant
    {
        public Menu Menu { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}