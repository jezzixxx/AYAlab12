using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.PopularityList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db) { _db = db; }
        public List<PopularityWithRestaurant> PopularityWithRestaurantsList { get; set; }
        public void OnGet()
        {
            PopularityWithRestaurantsList = _db.Popularity.Select(popularity => new PopularityWithRestaurant
            {
                Popularity = popularity,
                Restaurant = _db.Restaurant.FirstOrDefault(r => r.Id == popularity.RestaurantId)
            }).ToList();
        }
    }
    public class PopularityWithRestaurant
    {
        public Popularity Popularity { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
