namespace PrTask.Application.Services;
public interface IGpuEmitter
{
    bool IsGpuAvailable { get; }
    string DeviceName { get; }
    byte[][] TranslateBlocks(uint[] InstructionData, int[] BlockOffsets, int[] BlockLengths);
}
