using Microsoft.EntityFrameworkCore;

public sealed class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions options) : base(options)
  {    
  }

  public DbSet<UserPermission> UserPermissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserPermission>()
            .HasKey(t => new { t.UserId, t.Permission });
    }
}
public sealed class UserPermission
{
    public int UserId { get; set; }
    public Permissions Permission { get; set; }
}