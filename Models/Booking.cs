using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using Hotel9.Data;
namespace Hotel9.Models
{
    [PrimaryKey(nameof(ClientId), nameof(RoomId), nameof(CheckIn))]
    public class Booking
    {        
        public int ClientId { get; set; }
        
        public int RoomId { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }
        
        public int StayDuration { get; set; }
        
    }
}
