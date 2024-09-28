using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Oco2Chodzi.Models.Emissions;
using OCo2Chodzi.Service.Infrastructure;
using OCo2Chodzi.Model;

namespace OCo2Chodzi.Service.Ports;

internal class DiscoveryProvider(ApplicationDbContext dbContext) : IDiscoveryProvider
{
    public async Task<IEnumerable<Emission>> GetEmissions()
    {
        var linearEmissions = await dbContext.LinearEmissions.ToListAsync();
        var massEmissions = await dbContext.MassEmissions.ToListAsync();
        var singularEmission = await dbContext.SingularEmissions.ToListAsync();

        List<Emission> result = [];

        var linearDTO = linearEmissions.Select(x =>
            new Emission($"linear-{x.Id}", x.Caption, x.EmissionPerKm, Unit.Kilometr.GetStringValue(), "transport"));
        var massDTO = massEmissions.Select(x =>
            new Emission($"mass-{x.Id}", x.Caption, x.EmissionPerKilo, Unit.Kilogram.GetStringValue(), x.BusinessType));
        var unitDTO = singularEmission.Select(x =>
            new Emission($"unit-{x.Id}", x.Caption, x.Emission, Unit.Unit.GetStringValue(), x.BusinessType));


        result.AddRange(linearDTO);
        result.AddRange(massDTO);
        result.AddRange(unitDTO);
        return result;
    }



}
