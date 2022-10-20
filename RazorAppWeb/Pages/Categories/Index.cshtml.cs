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
    public class IndexModel : PageModel
    {
        // Declared outside OnGet() because there is no
        // return View() to pass the object nto the page
        // template like we did in the MVC version.
        public IEnumerable<Category> Categories { get; set; }

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}
