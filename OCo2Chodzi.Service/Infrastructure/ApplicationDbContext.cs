using Microsoft.EntityFrameworkCore;
using Oco2Chodzi.Models.Absorbions;
using Oco2Chodzi.Models.Emissions;

namespace OCo2Chodzi.Service.Infrastructure;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Absorbion> Absorbions { get; set; }
    public DbSet<LinearEmission> LinearEmissions { get; set; }
    public DbSet<MassEmission> MassEmissions { get; set; }
    public DbSet<SingularEmission> SingularEmissions { get; set; }
    public DbSet<EmissionGroup> EmissionGroups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MassEmission>()
            .HasOne(o => o.Group)
            .WithMany(c => c.MassEmissions)
            .HasForeignKey(o => o.GroupId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SingularEmission>()
            .HasOne(o => o.Group)
            .WithMany(c => c.SingularEmissions)
            .HasForeignKey(o => o.GroupId)
            .OnDelete(DeleteBehavior.NoAction); 


        base.OnModelCreating(modelBuilder);
    }

}