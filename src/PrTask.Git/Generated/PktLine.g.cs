namespace PrTask.Git.Generated;

internal static partial class PktLine
{
    internal static void PacketTraceIdentity(string Prog)
    {
    }

    internal static int PacketTracePack(string Buf, Unint Len, int Sideband)
        => default;

    internal static void PacketTrace(string Buf, Unint Len, int Write)
    {
    }

    internal static void PacketFlush(int Fd)
    {
    }

    internal static void PacketDelim(int Fd)
    {
    }

    internal static void PacketResponseEnd(int Fd)
    {
    }

    internal static int PacketFlushGently(int Fd)
        => default;

    internal static void PacketBufFlush(nint Buf)
    {
    }

    internal static void PacketBufDelim(nint Buf)
    {
    }

    internal static void SetPacketHeader(string Buf, int Size)
    {
    }

    internal static void PacketWriteFmt(int Fd, string Fmt, params object[] VarArgs)
    {
    }

    internal static int PacketWriteFmtGently(int Fd, string Fmt, params object[] VarArgs)
        => default;

    internal static int PacketWriteGently(int FdOut, string Buf, nuint Size)
        => default;

    internal static void PacketWrite(int FdOut, string Buf, nuint Size)
    {
    }

    internal static void PacketFwrite(nint F, string Buf, nuint Size)
    {
    }

    internal static void PacketFwriteFmt(nint Fh, string Fmt, params object[] VarArgs)
    {
    }

    internal static void PacketFflush(nint F)
    {
    }

    internal static void PacketBufWrite(nint Buf, string Fmt, params object[] VarArgs)
    {
    }

    internal static int WritePacketizedFromFdNoFlush(int FdIn, int FdOut)
        => default;

    internal static int PacketLength(string LenbufHex, nuint Size)
        => default;

    internal static int PacketRead(int Fd, string Buffer, uint Size, int Options)
        => default;

    internal static int PacketReadLineGently(int Fd, nint DstLen, string DstLine)
        => default;

    internal static nint ReadPacketizedToStrbuf(int FdIn, nint SbOut, int Options)
        => default;

    internal static int RecvSideband(string Me, int InStream, int Out)
        => default;

    internal static PacketReadStatus PacketReaderRead(nint Reader)
        => default;

    internal static PacketReadStatus PacketReaderPeek(nint Reader)
        => default;

    internal static void PacketWriterInit(nint Writer, int DestFd)
    {
    }

    internal static void PacketWriterWrite(nint Writer, string Fmt, params object[] VarArgs)
    {
    }

    internal static void PacketWriterError(nint Writer, string Fmt, params object[] VarArgs)
    {
    }

    internal static void PacketWriterDelim(nint Writer)
    {
    }

    internal static void PacketWriterFlush(nint Writer)
    {
    }

}
