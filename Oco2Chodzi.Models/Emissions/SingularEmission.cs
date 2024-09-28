using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models.Emissions;

public record SingularEmission : BaseEntity
{

    [Required]
    public decimal Emission { get; init; }
}
