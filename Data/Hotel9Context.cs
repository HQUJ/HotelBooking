//using System.Data.Entity;
using Hotel9.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel9.Data
{
    public class Hotel9Context : DbContext
    {
        public Hotel9Context(DbContextOptions<Hotel9Context> options) : base(options)
        {
        }
        //public DbSet<Client> CLients { get; set; } = default!;
        public DbSet<Room> Rooms { get; set; } = default!;
        public DbSet<Booking> Bookings { get; set; } = default!;
        public DbSet<Booking2> Bookings2 { get; set; } = default!;
    }
}
