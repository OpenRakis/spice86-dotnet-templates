namespace Spice86ProjectTemplate;

using Spice86.Core.CLI;
using Spice86.Shared;
using Spice86.Shared.Interfaces;
using Spice86.Shared.Emulator.Memory;
using Spice86.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

/// <summary>
/// Provides functions overrides for the DOS program.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier {
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(ILoggerService loggserService, Configuration configuration, ushort programStartAddress, Machine machine) {
        // You can extend / replace GeneratedOverrides with your own overrides as well.
        GeneratedOverrides generatedOverrides = new GeneratedOverrides(new(), configuration, machine, loggserService);
        return generatedOverrides.FunctionInformation;
    }
}