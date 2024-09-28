using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models.Absorbions;

public enum AbsorbionType
{
    OldTreeKilogramsPerYear,
    MediumTreeKilogramsPerGrowingSeason,
    TreeSaplingKilogramsPerYear,
    ParkKilogramsPerYear
}

public record Absorbion : BaseEntity
{
    [Required]
    public AbsorbionType AbsorbionType { get; init; }

    public decimal Value { get; init; }
}