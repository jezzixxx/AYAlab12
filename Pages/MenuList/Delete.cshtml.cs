using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.MenuList
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
            var itemToDelete = _db.Menu.Find(id);
            _db.Menu.Remove(itemToDelete);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
