namespace Spice86ProjectTemplate;

/// <summary>
/// Provides functions overrides for the DOS program.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier
{
    public Dictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(
        int programStartAddress,
        Machine machine)
    {
        //Add overrides here.
        return new Dictionary<SegmentedAddress, FunctionInformation>();
    }
}