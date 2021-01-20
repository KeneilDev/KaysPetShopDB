using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kays_Pets_UI.Data;
using Kays_Pets_UI.Models;

namespace Kays_Pets_UI.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Kays_Pets_UI.Data.KaysPetsContext _context;

        public DetailsModel(Kays_Pets_UI.Data.KaysPetsContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
