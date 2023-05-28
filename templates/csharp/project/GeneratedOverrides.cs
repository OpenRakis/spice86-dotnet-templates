namespace Spice86ProjectTemplate;

using Spice86.Logging;
using Spice86.Shared;
using Spice86.Shared.Interfaces;
using Spice86.Shared.Emulator.Memory;

public class GeneratedOverrides : CSharpOverrideHelper { 
  public GeneratedOverrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, Machine machine, ILoggerService logger, ushort entrySegment = 0xF000) : base(functionInformations, machine, logger) {
  }
}
