using Microsoft.EntityFrameworkCore;
using TravelAppAPI.Models;

namespace TravelAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-BQCVFF2\\JPMARINT; Database=TravelAppDb; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<RoleType> RoleType { get; set; }

    }
}
