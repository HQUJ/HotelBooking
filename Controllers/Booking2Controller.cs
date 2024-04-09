﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel9.Data;
using Hotel9.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace Hotel9.Controllers
{
    [Authorize]
    public class Booking2Controller : Controller
    {
        private readonly Hotel9Context _context;
        private readonly UserManager<Client> _userManager;

        public Booking2Controller(Hotel9Context context, UserManager<Client> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        

        // GET: Booking2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bookings2.Where(x => x.ClientUsername == User.Identity.Name).ToListAsync());
        }
        public async Task<IActionResult> Sorry()
        {
            return View();
        }
        public async Task<IActionResult> AvailableRooms()
        {
            List<Room> rooms = new List<Room>(_context.Rooms);
            List<Booking2> bookings = new List<Booking2>(_context.Bookings2);
            Booking2 CustomerBooking = new Booking2(bookings.Last());
            bookings.RemoveAt(bookings.Count - 1);
            foreach(var el in bookings)
            {
                if((CustomerBooking.CheckIn >= el.CheckIn && CustomerBooking.CheckIn <= el.CheckIn.AddDays(el.StayDuration))||
                    (CustomerBooking.CheckIn.AddDays(CustomerBooking.StayDuration) <= el.CheckIn.AddDays(el.StayDuration) && CustomerBooking.CheckIn.AddDays(CustomerBooking.StayDuration) >= el.CheckIn))
                {
                    rooms.RemoveAt(rooms.FindIndex( m => m.Id == el.RoomId));
                }
            }
            if (rooms.Where(x => x.Type == CustomerBooking.RoomType).ToList().Count != 0)
                return View( rooms.Where(x => x.Type == CustomerBooking.RoomType).ToList());
            else
            {
                var booking2 = await _context.Bookings2.FindAsync(CustomerBooking.Id);
                if (booking2 != null)
                {
                    _context.Bookings2.Remove(booking2);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Sorry));
            }
            
        }

        public async Task<IActionResult> Book(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking2 booking2 = _context.Bookings2.OrderByDescending(x => x.Id).FirstOrDefault();
            if (booking2 == null)
            {
                return NotFound();
            }
            booking2.RoomId = id;
            _context.SaveChanges();
            return View(booking2);
        }

        public async Task<IActionResult> Thanks()
        {
            return View();
        }


        // GET: Booking2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking2 = await _context.Bookings2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking2 == null)
            {
                return NotFound();
            }

            return View(booking2);
        }

        // GET: Booking2/Create
        public IActionResult Create()
        {
            
            return View();
        }
        
        

        // POST: Booking2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoomType,CheckIn,StayDuration")] Booking2 booking2)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);
                //if (currentUser == null) return Challenge();
                booking2.ClientUsername = User.Identity.Name;
                _context.Add(booking2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AvailableRooms));
            }
            return View(booking2);
        }

        // GET: Booking2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking2 = await _context.Bookings2.FindAsync(id);
            if (booking2 == null)
            {
                return NotFound();
            }
            return View(booking2);
        }

        // POST: Booking2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoomType,CheckIn,StayDuration")] Booking2 booking2)
        {
            if (id != booking2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Booking2Exists(booking2.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(booking2);
        }

        // GET: Booking2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking2 = await _context.Bookings2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking2 == null)
            {
                return NotFound();
            }

            return View(booking2);
        }

        // POST: Booking2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking2 = await _context.Bookings2.FindAsync(id);
            if (booking2 != null)
            {
                _context.Bookings2.Remove(booking2);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Booking2Exists(int id)
        {
            return _context.Bookings2.Any(e => e.Id == id);
        }
    }
}