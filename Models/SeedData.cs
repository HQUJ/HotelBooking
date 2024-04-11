
using Hotel9.Data;
using Hotel9.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel9.Models
{
    public class SeedData
    {
        //Добавя стаи в списъка със стаи, с които разполага хотела
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Hotel9Context(
            serviceProvider.GetRequiredService<
                    DbContextOptions<Hotel9Context>>()))
            {
                // Проверява за стаи
                if (context.Rooms.Any())
                {
                    return;   // Списъкът със стаи вече е запълнен
                }
                context.Rooms.AddRange(
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Single",
                        Price = 50M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Double",
                        Price = 60M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    },
                    new Room
                    {
                        Type = "Apartment",
                        Price = 75M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
