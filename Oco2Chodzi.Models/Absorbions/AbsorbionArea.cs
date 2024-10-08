using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;

namespace Oco2Chodzi.Models.Absorbions;

public record AbsorbionGroup : BaseEntity
{
    public ICollection<AbsorbionArea> AbsorbionAreas { get; } = [];
}

public record AbsorbionArea : BaseEntity
{
    public required Polygon Area { get; init; }

    public required double AreaInAres { get; init; }

    public required AbsorbionDefinition AbsorbionDefinition { get; init; }
    public required AbsorbionGroup AbsorbionGroup { get; init; }

    public int AbsorbionGroupId { get; init; }

    public decimal AverageDensityPerAre { get; init; }

    public long ItemsCount
    {
        get
        {
            return Convert.ToInt64(Math.Ceiling(AreaInAres * Convert.ToDouble(AverageDensityPerAre)));
        }
    }
}