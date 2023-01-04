namespace generatedCodeTestProject;

using Serilog;

public class GeneratedOverrides : CSharpOverrideHelper {
  public GeneratedOverrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, Machine machine, ILogger logger, ushort entrySegment = 0xF000) : base(functionInformations, machine, logger) {
  }
}
