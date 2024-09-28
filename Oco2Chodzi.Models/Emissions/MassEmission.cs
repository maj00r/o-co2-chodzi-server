using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oco2Chodzi.Models.Emissions;

public record MassEmission : BaseEntity
{
    [Required]
    public decimal EmissionPerKilo { get; init; }   
    [Required]
    public required EmissionGroup Group { get; init; }
    [Required]
    public int GroupId { get; init; }
}