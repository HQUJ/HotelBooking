using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel9.Data;
using Hotel9.Models;

namespace Hotel9.Controllers
{
    public class IndexModel : PageModel
    {
        private readonly Hotel9.Data.Hotel9Context _context;

        public IndexModel(Hotel9.Data.Hotel9Context context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Booking = await _context.Bookings.ToListAsync();
        }
    }
}
