namespace Spice86ProjectTemplate;

using Spice86.Core.CLI;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public class GeneratedOverrides : CSharpOverrideHelper { 
  public GeneratedOverrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, Configuration configuration, Machine machine, ILoggerService logger, ushort entrySegment = 0xF000) : base(functionInformations, machine, logger, configuration) {
  }

  public IDictionary<SegmentedAddress, FunctionInformation> FunctionInformation => _functionInformations;
}
