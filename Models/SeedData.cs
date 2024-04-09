
using Hotel9.Data;
using Hotel9.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel9.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Hotel9Context(
            serviceProvider.GetRequiredService<
                    DbContextOptions<Hotel9Context>>()))
            {
                // Look for any movies.
                if (context.Rooms.Any())
                {
                    return;   // DB has been seeded
                }
                context.Rooms.AddRange(
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "единична",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "двойна",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "апартамент",
                        Price = 75M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
