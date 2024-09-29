using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oco2Chodzi.Models;

public abstract record BaseEntity
{

    [Key]
    public int Id { get; init; }

    [Required]
    [StringLength(maximumLength: 150)]
    public required string Caption { get; init; }
}