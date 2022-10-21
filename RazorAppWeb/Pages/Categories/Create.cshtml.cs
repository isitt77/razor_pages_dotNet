using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorAppWeb.Model;

namespace RazorAppWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category category { get; set; }

        public void OnGet()
        {
        }
    }
}
