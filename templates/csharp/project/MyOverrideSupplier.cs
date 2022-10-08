namespace Spice86ProjectTemplate;

/// <summary>
/// Provides functions overrides for the DOS program.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier {
    public Dictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(int programStartAddress, Machine machine) {
        Dictionary<SegmentedAddress, FunctionInformation> functionInformations = new();
        // You can extend / replace GeneratedOverrides with your own overrides.
        // new GeneratedOverrides(functionInformations, machine);
        return functionInformations;
    }
}