using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oco2Chodzi.Models.Absorbions;
using OCo2Chodzi.Service.Infrastructure;
using OCo2Chodzi.Service.Ports;

namespace OCo2Chodzi.Service.Adapters;

public class AbsorbionCalculator(ApplicationDbContext dbContext) : IAbsorbionCalculator
{
    public async Task<IEnumerable<AbsorbionResult>> Compute(decimal absorbionMassKilo)
    {
        if (absorbionMassKilo <= 0)
        {
            throw new InvalidDataException("absorbion mass should be greater than 0");
        }
        List<AbsorbionResult> result = [];

        var predefinedAbsorbions = await dbContext.PredefinedAbsorbionRates.ToListAsync();

        result.Add(For100YearsOldTree(predefinedAbsorbions));
        result.Add(For30YearsOldTree(predefinedAbsorbions, absorbionMassKilo));
        result.Add(ForSaplingTree(predefinedAbsorbions, absorbionMassKilo));
        result.Add(await ForAbsorbionArea(absorbionMassKilo));

        return result;
    }

    private AbsorbionResult For100YearsOldTree(IEnumerable<PredefinedAbsorbionRate> rates)
    {
        var key = AbsorbionType.OldTreeKilogramsPerYear;
        var rate = rates.FirstOrDefault(x => x.AbsorbionType == key)!;
        return new AbsorbionResult(rate.Caption, key, rate.Value);
    }

    private AbsorbionResult For30YearsOldTree(IEnumerable<PredefinedAbsorbionRate> rates, decimal absorbionMassKilo)
    {
        var key = AbsorbionType.MediumTreeKilogramsPerGrowingSeason;
        var rate = rates.FirstOrDefault(x => x.AbsorbionType == key)!;

        var treesCount = Math.Ceiling(absorbionMassKilo / rate.Value);
        return new AbsorbionResult(rate.Caption, 
            key, treesCount);
    }

    private AbsorbionResult ForSaplingTree(IEnumerable<PredefinedAbsorbionRate> rates, decimal absorbionMassKilo)
    {
        var key = AbsorbionType.TreeSaplingKilogramsPerYear;
        var rate = rates.FirstOrDefault(x => x.AbsorbionType == key)!;

        var treesCount = Math.Ceiling(absorbionMassKilo / rate.Value);
        return new AbsorbionResult(rate.Caption, 
            key, treesCount);
    }

    private async Task<AbsorbionResult> ForAbsorbionArea(decimal absorbionMassKilo)
    {
        var group = await RandomAbsorbionGroup();

        return new AbsorbionResult($"Czas potrzebny na pochłonięcie CO2 przez {group.Caption} [w latach]",
            "random-absorbion-area", 10);
    }

    private Task<AbsorbionGroup> RandomAbsorbionGroup()
    {
        return dbContext.AbsorbionGroups
            .OrderBy(x => Guid.NewGuid())
            .Take(1)
            .FirstOrDefaultAsync()!;
    }
}