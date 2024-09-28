using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models.Emissions;

public record MassEmission : AbstractEmission
{
    [Required]
    public decimal EmissionPerKilo { get; init; } 
}