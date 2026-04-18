namespace WillowMaze.Wasm.Decompiled;

public class Pbf98b58a : IDisposable
{
    private static Logger F20f9b080;
    private static Logger F36f3549c;
    public static pbf98b58a$p910eef8c F49918429;
    private static Logger F6db435f3;
    private static Logger F8580a231;
    public static pbf98b58a$p910eef8c F910eef8c;
    private bool F007690d5;
    private int F03310a0b;
    private readonly p406baf6c$pbbad3d30 F16ad32c9;
    private readonly bool F1afe6139;
    private readonly p7e62bc34 F1fcdaccb;
    private readonly p08d84bc6 F265e37c7;
    private bool F349e6863;
    private readonly p406baf6c$pbbad3d30 F37a736cf;
    private readonly p7e62bc34 F38c34137;
    private bool F4eecaf91;
    private readonly bool F62608e08;
    private bool F66305a93;
    private readonly p406baf6c$pbbad3d30 F6a3640ae;
    private readonly p406baf6c$pbbad3d30 F715664f2;
    private int F7243d5af;
    private bool Fa2a0f7da;
    private readonly p7e62bc34 Fb63aa474;
    private readonly bool Fb9d5d9df;
    private int Fcfcfc8bb;
    private int Fd7ef87d8;
    private int Fe91e8cc7;
    private readonly p406baf6c$pbbad3d30 Feb4fe690;
    private readonly bool Fedb87b97;
    private readonly p08d84bc6 Ff6e04117;

    private void WriteContinuationFrames(int P0, long P1)
    {
        // call: pbf98b58a.frameHeader
        // call: Math.min
        // call: p08d84bc6.write
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.fd7ef87d8
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f38c34137
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
    }

    public void ApplyAndAckSettings(pf4f70727 P0)
    {
        // str: "peerSettings"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: pf4f70727.getMaxFrameSize
        // call: pf4f70727.getHeaderTableSize
        // call: p406baf6c$pbbad3d30.resizeHeaderTable
        // call: pbf98b58a.frameHeader
        // call: p08d84bc6.flush
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.fd7ef87d8
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f715664f2
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IOException
    }

    public void Close()
    {
        // call: p08d84bc6.close
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
    }

    public void ConnectionPreface()
    {
        // str: "closed"
        // str: ">> CONNECTION "
        // call: IOException.<init>
        // call: Logger.isLoggable
        // call: p58efa9e8.hex
        // call: Intrinsics.stringPlus
        // call: p23e8a4b4.format
        // call: Logger.fine
        // call: p08d84bc6.write
        // call: p08d84bc6.flush
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f6db435f3
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f0017a7c5
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f62608e08
        // type: IOException
    }

    public void Data(bool P0, int P1, p7e62bc34 P2, int P3)
    {
        // str: "closed"
        // call: pbf98b58a.dataFrame
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // type: IOException
    }

    public void DataFrame(int P0, int P1, p7e62bc34 P2, int P3)
    {
        // call: Intrinsics.checkNotNull
        // call: p08d84bc6.write
        // call: pbf98b58a.frameHeader
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
    }

    public void Flush()
    {
        // str: "closed"
        // call: p08d84bc6.flush
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IOException
    }

    public void FrameHeader(int P0, int P1, int P2, int P3)
    {
        // str: "reserved bit set: "
        // str: ": "
        // str: "FRAME_SIZE_ERROR length > "
        // call: p08d84bc6.writeByte
        // call: StringBuilder.append
        // call: Logger.isLoggable
        // call: Logger.fine
        // call: int.valueOf
        // call: p08d84bc6.writeInt
        // call: p23e8a4b4.writeMedium
        // call: pb354a53a.frameLog
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Intrinsics.stringPlus
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.fd7ef87d8
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f6db435f3
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f76425f17
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public p406baf6c$pbbad3d30 GetHpackWriter()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f715664f2
        return default!;
    }

    public void GoAway(int P0, p9bc96b38 P1, byte[] P2)
    {
        // str: "errorCode"
        // str: "debugData"
        // str: "errorCode.httpCode == -1"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: p9bc96b38.getHttpCode
        // call: pbf98b58a.frameHeader
        // call: p08d84bc6.writeInt
        // call: p08d84bc6.write
        // call: p08d84bc6.flush
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IllegalArgumentException
        // type: IOException
    }

    public void Headers(bool P0, int P1, List<object> P2)
    {
        // str: "headerBlock"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: p406baf6c$pbbad3d30.writeHeaders
        // call: p7e62bc34.size
        // call: Math.min
        // call: pbf98b58a.frameHeader
        // call: p08d84bc6.write
        // call: pbf98b58a.writeContinuationFrames
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f715664f2
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f38c34137
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.fd7ef87d8
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IOException
    }

    public int MaxDataLength()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.fd7ef87d8
        return 0;
    }

    public void Ping(bool P0, int P1, int P2)
    {
        // str: "closed"
        // call: IOException.<init>
        // call: pbf98b58a.frameHeader
        // call: p08d84bc6.writeInt
        // call: p08d84bc6.flush
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IOException
    }

    public void PushPromise(int P0, int P1, List<object> P2)
    {
        // str: "closed"
        // str: "requestHeaders"
        // call: IOException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p406baf6c$pbbad3d30.writeHeaders
        // call: p7e62bc34.size
        // call: Math.min
        // call: pbf98b58a.frameHeader
        // call: p08d84bc6.writeInt
        // call: p08d84bc6.write
        // call: pbf98b58a.writeContinuationFrames
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f715664f2
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f38c34137
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.fd7ef87d8
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IOException
    }

    public void RstStream(int P0, p9bc96b38 P1)
    {
        // str: "Failed requirement."
        // str: "closed"
        // str: "errorCode"
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: IOException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p9bc96b38.getHttpCode
        // call: pbf98b58a.frameHeader
        // call: p08d84bc6.writeInt
        // call: p08d84bc6.flush
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IllegalArgumentException
        // type: IOException
    }

    public void Settings(pf4f70727 P0)
    {
        // str: "settings"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: pf4f70727.size
        // call: pbf98b58a.frameHeader
        // call: pf4f70727.isSet
        // call: p08d84bc6.writeShort
        // call: pf4f70727.get
        // call: p08d84bc6.writeInt
        // call: p08d84bc6.flush
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IOException
    }

    public void WindowUpdate(int P0, long P1)
    {
        // str: "windowSizeIncrement == 0 || windowSizeIncrement > 0x7fffffffL: "
        // str: "closed"
        // call: pbf98b58a.frameHeader
        // call: p08d84bc6.writeInt
        // call: p08d84bc6.flush
        // call: long.valueOf
        // call: Intrinsics.stringPlus
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f349e6863
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.ff6e04117
        // type: IllegalArgumentException
        // type: IOException
    }

}
