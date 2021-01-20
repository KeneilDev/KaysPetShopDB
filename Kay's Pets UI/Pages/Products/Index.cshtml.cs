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
    public class IndexModel : PageModel
    {
        private readonly Kays_Pets_UI.Data.KaysPetsContext _context;

        public IndexModel(Kays_Pets_UI.Data.KaysPetsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
