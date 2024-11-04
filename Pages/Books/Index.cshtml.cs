using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catinas_Darius_Lab2.Data;
using Catinas_Darius_Lab2.Models;

namespace Catinas_Darius_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Catinas_Darius_Lab2.Data.Catinas_Darius_Lab2Context _context;

        public IndexModel(Catinas_Darius_Lab2.Data.Catinas_Darius_Lab2Context context)
        {
            _context = context;
        }
        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Author) // Include relația cu Author
                .Include(b => b.Publisher) // Include și Publisher, dacă e necesar
                .ToListAsync();
        }
    }
}
