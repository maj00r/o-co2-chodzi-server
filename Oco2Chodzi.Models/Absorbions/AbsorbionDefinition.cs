using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oco2Chodzi.Models.Absorbions;

public record AbsorbionDefinition : BaseEntity
{
    public int AgeYears { get; init; }
    public int HeightMeters { get; init; }
    public int GrowingSeasonWeeks { get; init; }
    public decimal AbsorbionKilogramsPerGrowingSeason { get; init; }

}