using CampingMaasvallei_v2.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CampingMaasvallei_v2.Context
{
    public class CampingMaasvalleiContext : DbContext
    {
        public CampingMaasvalleiContext([NotNull] DbContextOptions options) : base(options) { }

        DbSet<User> User { get; set; }
        DbSet<Reservation> Reservation { get; set; }
        DbSet<CampingSpot> CampingSpot { get; set; }
    }
}