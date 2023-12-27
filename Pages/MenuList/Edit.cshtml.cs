using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.MenuList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Menu Menu { get; set; }
        public IActionResult OnGet(int id)
        {
            Menu = _db.Menu.Find(id);
            if (Menu == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }
            _db.Menu.Update(Menu);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
