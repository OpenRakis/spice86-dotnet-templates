namespace Spice86ProjectTemplate;

using Spice86.Shared;
using Spice86.Shared.Interfaces;
using Spice86.Shared.Emulator.Memory;
using Spice86.Logging;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides functions overrides for the DOS program.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier {
    private GeneratedOverrides? _generatedOverrides;

    public Dictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(int programStartAddress, Machine machine) {
        Dictionary<SegmentedAddress, FunctionInformation> functionInformations = new();
        // You can extend / replace GeneratedOverrides with your own overrides as well.
        ILoggerService? loggerService = Program.ServiceProvider?.GetService<ILoggerService>();
        _generatedOverrides = new GeneratedOverrides(functionInformations, machine, loggerService!);
        return functionInformations;
    }
}