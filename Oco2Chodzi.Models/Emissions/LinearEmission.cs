using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models.Emissions;

public record LinearEmission : AbstractEmission
{
    [Required]
    public decimal EmissionPerKm { get; init; }
} 