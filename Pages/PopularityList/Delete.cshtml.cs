using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.PopularityList
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public int Id { get; set; }

        public IActionResult OnGet(int id)
        {
            var itemToDelete = _db.Popularity.Find(id);
            _db.Popularity.Remove(itemToDelete);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
