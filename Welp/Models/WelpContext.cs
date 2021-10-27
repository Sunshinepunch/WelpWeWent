using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Welp.Models
{
  public class WelpContext : IdentityDbContext<ApplicationUser>
  {

    public DbSet<Review> Reviews { get; set; }

    public WelpContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}