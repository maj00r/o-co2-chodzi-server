using System.ComponentModel.DataAnnotations;
using OCo2Chodzi.Model;

namespace Oco2Chodzi.Models.Emissions;


public record AbstractEmission : BaseEntity
{
    [Required]
    public required string BusinessType { get; init; }
    [Required]
    public required string Unit { get; init; }
} 