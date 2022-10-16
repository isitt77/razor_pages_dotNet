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
        //public IEnumerable<Category> Categories { get; set; }

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            IEnumerable<Category> Categories = _db.Categories;
        }
    }
}
