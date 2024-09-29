using Microsoft.EntityFrameworkCore;
using Oco2Chodzi.Models.Absorbions;
using Oco2Chodzi.Models.Emissions;
using NetTopologySuite.Geometries;
using NetTopologySuite;


namespace OCo2Chodzi.Service.Infrastructure;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<PredefinedAbsorbionRate> PredefinedAbsorbionRates { get; set; }
    public DbSet<LinearEmission> LinearEmissions { get; set; }
    public DbSet<MassEmission> MassEmissions { get; set; }
    public DbSet<SingularEmission> SingularEmissions { get; set; }
    public DbSet<AbsorbionGroup> AbsorbionGroups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);


        modelBuilder.Entity<AbsorbionArea>()
            .HasOne(o => o.AbsorbionGroup)
            .WithMany(c => c.AbsorbionAreas)
            .HasForeignKey(o => o.AbsorbionGroupId)
            .OnDelete(DeleteBehavior.NoAction); 

        
        modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?))
            .ToList()
            .ForEach(p => p.SetColumnType("decimal(18,6)"));

        modelBuilder.Entity<AbsorbionArea>()
                .Property(o => o.AreaInAres)
                .HasComputedColumnSql("Area.STArea() / 100");


        base.OnModelCreating(modelBuilder);
    }

}