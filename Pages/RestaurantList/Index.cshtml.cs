using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.Intrinsics.Arm;

namespace AYAlab12.Pages.RestaurantList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db) { _db = db; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public void OnGet()
        {
            Restaurants = _db.Restaurant.ToList();
        }
    }
}
