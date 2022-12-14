namespace Spice86ProjectTemplate;

using Spice86.Core.DI;

/// <summary>
/// Provides functions overrides for the DOS program.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier {
    public Dictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(int programStartAddress, Machine machine) {
        Dictionary<SegmentedAddress, FunctionInformation> functionInformations = new();
        // You can extend / replace GeneratedOverrides with your own overrides as well.
        new GeneratedOverrides(functionInformations, machine, new ServiceProvider().GetLoggerForContext<GeneratedOverrides>());
        return functionInformations;
    }
}