using System.Text.Json.Serialization;

namespace Oco2Chodzi.Models.Emissions;

public record class EmissionGroup : BaseEntity
{
    [JsonIgnore]
    public ICollection<MassEmission> MassEmissions { get; } = [];
    [JsonIgnore]
    public ICollection<SingularEmission> SingularEmissions { get; } = [];
}