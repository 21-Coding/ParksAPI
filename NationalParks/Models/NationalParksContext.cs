
using Microsoft.EntityFrameworkCore;

namespace NationalParks.Models
{
  public class NationalParksContext : DbContext
  {
    public NationalParksContext(DbContextOptions<NationalParksContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
            new Park { ParkId = 2, Name = "Sequoia National Park", City = "Three Rivers", State = "CA", Description = "It's ancient", ClimbingRoutes = 1, Campgrounds = 3, GeneralStores = 4 },
            new Park { ParkId = 3, Name = "Yosemite National Park", City = "Yosemite National Park", State = "CA", Description = "I met my friend Sam here", ClimbingRoutes = 1348, Campgrounds = 9, GeneralStores = 8 }
          );
    }
  }
}