using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.RestaurantList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IActionResult OnGet(int id)
        {
            Restaurant = _db.Restaurant.Find(id);
            if (Restaurant == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }
            _db.Restaurant.Update(Restaurant);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
