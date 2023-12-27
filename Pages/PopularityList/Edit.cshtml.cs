using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.PopularityList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Popularity Popularity { get; set; }
        public IActionResult OnGet(int id)
        {
            Popularity = _db.Popularity.Find(id);
            if (Popularity == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }
            _db.Popularity.Update(Popularity);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
