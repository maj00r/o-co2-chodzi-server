namespace Oco2Chodzi.Models.Emissions;

public record class EmissionGroup : BaseEntity
{
    public ICollection<MassEmission> MassEmissions { get; } = [];
    public ICollection<SingularEmission> SingularEmissions { get; } = [];
}