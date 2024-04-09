﻿using Hotel9.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel9.Models
{
    public class Booking2
    {
        [Key]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public string? ClientUsername { get; set; }
        [ScaffoldColumn(false)]
        public int? RoomId { get; set; }
        [Required]
        public string RoomType { get; set; }
        
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public int StayDuration { get; set; }

        public Booking2() { }
        public Booking2(Object b)
        {
            if(b is Booking2)
            {
                Booking2 c = (Booking2)b;
                this.Id = c.Id;
                this.ClientUsername = c.ClientUsername;
                this.RoomId = c.RoomId;
                this.RoomType = c.RoomType;
                this.CheckIn = c.CheckIn;
                this.StayDuration = c.StayDuration;
            }
            
        }
        
    }
}
