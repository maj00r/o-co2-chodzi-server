using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models.Emissions;

public record SingularEmission : AbstractEmission
{

    [Required]
    public decimal Emission { get; init; }

}
