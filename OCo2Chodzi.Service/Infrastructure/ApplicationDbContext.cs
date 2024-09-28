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

}