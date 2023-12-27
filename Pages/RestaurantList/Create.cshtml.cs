using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.RestaurantList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db) { _db = db; }
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public void OnGet() { }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid) {
                _db.Restaurant.AddAsync(Restaurant);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            } else {
                Console.WriteLine("Non valid");
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                return Page(); }
        }
    }
}
