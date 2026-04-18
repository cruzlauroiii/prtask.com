namespace PrTask.Git.Generated;

internal static partial class ParallelCheckout
{
    internal static PcStatus ParallelCheckoutStatus()
        => default;

    internal static void GetParallelCheckoutConfigs(nint NumWorkers, nint Threshold)
    {
    }

    internal static void InitParallelCheckout()
    {
    }

    internal static void FinishParallelCheckout()
    {
    }

    internal static nuint PcQueueSize()
        => default;

    internal static void AdvanceProgressMeter()
    {
    }

    internal static int HandleResults(nint State)
        => default;

    internal static int ResetFd(int Fd, string Path)
        => default;

    internal static int CloseAndClear(nint Fd)
        => default;

    internal static void SendOneItem(int Fd, nint PcItem)
    {
    }

    internal static void SendBatch(int Fd, nuint Start, nuint Nr)
    {
    }

    internal static void FinishWorkers(nint Workers, int NumWorkers)
    {
    }

    internal static void AssertPcItemResultSize(int Got, int Exp)
    {
    }

    internal static void WriteItemsSequentially(nint State)
    {
    }

}
