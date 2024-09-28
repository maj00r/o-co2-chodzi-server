using OCo2Chodzi.Model;
using OCo2Chodzi.Service.Infrastructure;

namespace OCo2Chodzi.Service.Ports;

public enum Unit
{
    [StringValue("kg")]
    Kilogram,
    [StringValue("km")]
    Kilometr,
    [StringValue("l")]
    Liter,
    [StringValue("unit")]
    Unit
}


public record Emission(string CanonicalName, string Caption, decimal Value, string Unit, string BusinessType);

public interface IDiscoveryProvider
{
    public Task<IEnumerable<Emission>> GetEmissions();
}