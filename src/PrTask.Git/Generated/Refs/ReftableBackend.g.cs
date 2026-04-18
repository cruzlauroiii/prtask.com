namespace PrTask.Git.Generated;

internal static partial class ReftableBackend
{
    internal static void ReftableBackendOnReload(nint Payload)
    {
    }

    internal static void ReftableBackendRelease(nint Be)
    {
    }

    internal static int ShouldWriteLog(nint Refs, string Refname)
        => default;

    internal static void FillReftableLogRecord(nint Log, nint Split)
    {
    }

    internal static int ReftableBeFsync(int Fd)
        => default;

    internal static void ReftableBeRelease(nint RefStore)
    {
    }

    internal static int ShouldExcludeCurrentRef(nint Iter)
        => default;

    internal static int ReftableRefIteratorAdvance(nint RefIterator)
        => default;

    internal static void ReftableRefIteratorRelease(nint RefIterator)
    {
    }

    internal static int QsortStrcmp(nint Va, nint Vb)
        => default;

    internal static void FreeTransactionData(nint TxData)
    {
    }

    internal static int TransactionUpdateCmp(nint A, nint B)
        => default;

    internal static int WriteTransactionTable(nint Writer, nint CbData)
        => default;

    internal static int WriteCopyTable(nint Writer, nint CbData)
        => default;

    internal static int ReftableReflogIteratorAdvance(nint RefIterator)
        => default;

    internal static void ReftableReflogIteratorRelease(nint RefIterator)
    {
    }

    internal static int WriteReflogDeleteTable(nint Writer, nint CbData)
        => default;

    internal static int WriteReflogExpiryTable(nint Writer, nint CbData)
        => default;

    internal static void ReftableFsckVerboseHandler(string Msg, nint CbData)
    {
    }

}
