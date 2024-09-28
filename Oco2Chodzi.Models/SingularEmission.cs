using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models;

public record SingularEmission
{
    public int Id { get; init; }

    [Required]
    [StringLength(100)]
    public string Type { get; init; }

    public decimal Emission { get; init; }
}
