using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models.Emissions;

public record LinearEmission : BaseEntity
{
    [Required]
    public decimal EmissionPerKm { get; init; }
}