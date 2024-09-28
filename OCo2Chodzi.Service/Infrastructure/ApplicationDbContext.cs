using Microsoft.EntityFrameworkCore;
using Oco2Chodzi.Models.Absorbions;
using Oco2Chodzi.Models.Emissions;
using NetTopologySuite.Geometries;
using NetTopologySuite;


namespace OCo2Chodzi.Service.Infrastructure;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<PredefinedAbsorbionRate> Absorbions { get; set; }
    public DbSet<LinearEmission> LinearEmissions { get; set; }
    public DbSet<MassEmission> MassEmissions { get; set; }
    public DbSet<SingularEmission> SingularEmissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);


        modelBuilder.Entity<AbsorbionArea>()
            .HasOne(o => o.AbsorbionGroup)
            .WithMany(c => c.AbsorbionAreas)
            .HasForeignKey(o => o.AbsorbionGroupId)
            .OnDelete(DeleteBehavior.NoAction); 


        base.OnModelCreating(modelBuilder);
    }

}