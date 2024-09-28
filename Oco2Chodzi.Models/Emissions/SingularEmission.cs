using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Oco2Chodzi.Models.Emissions;

public record SingularEmission : BaseEntity
{

    [Required]
    public decimal Emission { get; init; }
    [JsonIgnore]
    public EmissionGroup Group { get; set; }
    [Required]
    public int GroupId { get; init; }
}
