namespace Spice86ProjectTemplate;

using Spice86.Core.CLI;
using Spice86.Logging;
using Spice86.Shared;
using Spice86.Shared.Interfaces;
using Spice86.Shared.Emulator.Memory;

public class GeneratedOverrides : CSharpOverrideHelper { 
  public GeneratedOverrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, Configuration configuration, Machine machine, ILoggerService logger, ushort entrySegment = 0xF000) : base(functionInformations, machine, logger, configuration) {
  }

  public Dictionary<SegmentedAddress, FunctionInformation> FunctionInformation => _functionInformations;
}
