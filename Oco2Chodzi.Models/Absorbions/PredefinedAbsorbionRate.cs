using System.ComponentModel.DataAnnotations;

namespace Oco2Chodzi.Models.Absorbions;

public static class AbsorbionType
{
    public static readonly string OldTreeKilogramsPerYear = "100yo-tree";
    public static readonly string TreeSaplingKilogramsPerYear = "sapling-tree";
    public static readonly string MediumTreeKilogramsPerGrowingSeason = "30yo-tree";
}

public record PredefinedAbsorbionRate : BaseEntity
{
    [Required]
    public required string AbsorbionType { get; init; }

    public decimal Value { get; init; }
}