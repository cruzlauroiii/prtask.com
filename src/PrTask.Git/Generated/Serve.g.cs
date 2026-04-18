namespace PrTask.Git.Generated;

internal static partial class Serve
{
    internal static int SessionIdAdvertise(nint R, nint Value)
        => default;

    internal static int ObjectInfoAdvertise(nint R, nint UNUSED)
        => default;

    internal static void ProtocolV2AdvertiseCapabilities(nint R)
    {
    }

    internal static int ReceiveClientCapability(nint R, string Key)
        => default;

    internal static int ParseCommand(nint R, string Key, nint Command)
        => default;

    internal enum RequestState
    {
        PROCESS_REQUEST_KEYS,
        PROCESS_REQUEST_DONE,
    }
    internal static int ProcessRequest(nint R)
        => default;

    internal static void ProtocolV2ServeLoop(nint R, int StatelessRpc)
    {
    }

}
