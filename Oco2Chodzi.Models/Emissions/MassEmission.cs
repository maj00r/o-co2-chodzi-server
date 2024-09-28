using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Oco2Chodzi.Models.Emissions;

public record MassEmission : BaseEntity
{
    [Required]
    public decimal EmissionPerKilo { get; init; }   
    [JsonIgnore]
    public EmissionGroup Group { get; set; }
    [Required]
    public int GroupId { get; init; }
}