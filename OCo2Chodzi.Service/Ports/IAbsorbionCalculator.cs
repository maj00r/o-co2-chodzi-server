using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oco2Chodzi.Models.Absorbions;

namespace OCo2Chodzi.Service.Ports;

public record AbsorbionResult(
    string Caption,
    string Key,
    decimal Value
);

public interface IAbsorbionCalculator
{
    Task<IEnumerable<AbsorbionResult>> Compute(decimal absorbionMassKilo);
}