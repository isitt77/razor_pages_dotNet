using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorAppWeb.Data;
using RazorAppWeb.Model;

namespace RazorAppWeb.Pages.Categories
{
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Category category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public void OnGet(int id)
        {
            category = _db.Categories.Find(id);
        }


        public async Task<IActionResult> OnPost()
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "Name and " +
                    "Display Order cannot be the same.");
            }
            // ModelState is only hit when there are no client side validations.
            Console.WriteLine("isValidModelState: " + ModelState.IsValid);
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "You've successfully edited a category.";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
