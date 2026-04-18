namespace PrTask.Git.Generated;

internal static partial class Record
{
    internal static int GetVarInt(nint Dest, nint In)
        => default;

    internal static int PutVarInt(nint Dest, ulong Value)
        => default;

    internal static int ReftableIsBlockType(byte Typ)
        => default;

    internal static int DecodeString(nint Dest, StringView In)
        => default;

    internal static int EncodeString(string Str, StringView S)
        => default;

    internal static int ReftableRefRecordKey(nint R, nint Dest)
        => default;

    internal static void ReftableRefRecordReleaseVoid(nint Rec)
    {
    }

    internal static void ReftableRefRecordRelease(nint Ref)
    {
    }

    internal static byte ReftableRefRecordValType(nint Rec)
        => default;

    internal static int ReftableRefRecordIsDeletionVoid(nint P)
        => default;

    internal static int ReftableRefRecordCmpVoid(nint A, nint B)
        => default;

    internal static int ReftableObjRecordKey(nint R, nint Dest)
        => default;

    internal static void ReftableObjRecordRelease(nint Rec)
    {
    }

    internal static byte ReftableObjRecordValType(nint Rec)
        => default;

    internal static int NotADeletion(nint REFTABLEUNUSED)
        => default;

    internal static int ReftableObjRecordCmpVoid(nint A, nint B)
        => default;

    internal static int ReftableLogRecordKey(nint R, nint Dest)
        => default;

    internal static void ReftableLogRecordReleaseVoid(nint Rec)
    {
    }

    internal static void ReftableLogRecordRelease(nint R)
    {
    }

    internal static byte ReftableLogRecordValType(nint Rec)
        => default;

    internal static int NullStreq(string A, string B)
        => default;

    internal static int ReftableLogRecordCmpVoid(nint A, nint B)
        => default;

    internal static int ReftableLogRecordIsDeletionVoid(nint P)
        => default;

    internal static int ReftableIndexRecordKey(nint R, nint Dest)
        => default;

    internal static void ReftableIndexRecordRelease(nint Rec)
    {
    }

    internal static byte ReftableIndexRecordValType(nint REFTABLEUNUSED)
        => default;

    internal static int ReftableIndexRecordCmp(nint A, nint B)
        => default;

    internal static int ReftableRecordKey(nint Rec, nint Dest)
        => default;

    internal static byte ReftableRecordValType(nint Rec)
        => default;

    internal static void ReftableRecordRelease(nint Rec)
    {
    }

    internal static int ReftableRecordIsDeletion(nint Rec)
        => default;

    internal static int ReftableRecordEqual(nint A, nint B, uint HashSize)
        => default;

    internal static int HashEqual(nint A, nint B, uint HashSize)
        => default;

    internal static int ReftableRefRecordCompareName(nint A, nint B)
        => default;

    internal static int ReftableRefRecordIsDeletion(nint Ref)
        => default;

    internal static int ReftableLogRecordCompareKey(nint A, nint B)
        => default;

    internal static int ReftableLogRecordIsDeletion(nint Log)
        => default;

    internal static int ReftableRecordInit(nint Rec, byte Typ)
        => default;

}
