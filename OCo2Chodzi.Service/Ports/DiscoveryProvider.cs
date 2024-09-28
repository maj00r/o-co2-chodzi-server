using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Oco2Chodzi.Models.Emissions;
using OCo2Chodzi.Service.Infrastructure;

namespace OCo2Chodzi.Service.Ports;

internal class DiscoveryProvider(ApplicationDbContext dbContext) : IDiscoveryProvider
{
    public async Task<EmissionsDefinitions> GetEmissions()
    {
        return new EmissionsDefinitions(
            await dbContext.LinearEmissions.ToListAsync(),
            await dbContext.MassEmissions.ToListAsync(),
            await dbContext.SingularEmissions.ToListAsync(),
            await dbContext.EmissionGroups.ToListAsync()
        );
    }
}
