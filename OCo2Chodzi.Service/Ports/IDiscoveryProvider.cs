using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oco2Chodzi.Models.Emissions;

namespace OCo2Chodzi.Service.Ports;

public record EmissionsDefinitions(IEnumerable<LinearEmission> LinearEmissions, 
    IEnumerable<MassEmission> MassEmissions, 
    IEnumerable<SingularEmission> SingularEmissions,
    IEnumerable<EmissionGroup> EmissionGroups);

public interface IDiscoveryProvider
{
    public Task<EmissionsDefinitions> GetEmissions();
}