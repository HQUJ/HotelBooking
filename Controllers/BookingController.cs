using Hotel9.Data;
using Hotel9.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel9.Controllers
{
    public class BookingController : Controller
    {
        private readonly Hotel9Context _context;
        public List<Room> AvailableRooms;

        public BookingController(Hotel9Context context)
        {
            _context = context;
        }

        
    }
}
