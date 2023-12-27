using AYAlab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AYAlab12.Pages.MenuList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db) { _db = db; }
        [BindProperty]
        public Menu Menu { get; set; }
        public void OnGet() { }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Menu.AddAsync(Menu);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                Console.WriteLine("Non valid");
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                return Page();
            }
        }
    }
}
