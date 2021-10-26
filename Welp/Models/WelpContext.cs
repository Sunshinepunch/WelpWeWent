using Microsoft.EntityFrameworkCore;



namespace Welp.Models
{
  public class WelpContext : DbContext
  {

    public DbSet<Review> Reviews { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}