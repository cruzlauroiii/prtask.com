namespace WillowMaze.Wasm.Decompiled;

public class P1b0ecc4e : IDisposable
{
    public static p1b0ecc4e$p910eef8c F0e0b15fa;
    private static Logger F0e7a16af;
    public static p1b0ecc4e$p910eef8c F10d1b3b7;
    public static p1b0ecc4e$p910eef8c F31d6186b;
    private static Logger F6db435f3;
    public static p1b0ecc4e$p910eef8c F910eef8c;
    public static p1b0ecc4e$p910eef8c Fd6e2620f;
    private readonly bool F05faabd7;
    private readonly p1b0ecc4e$ped8626c7 F06fff460;
    private readonly pcc81e3f6 F36cd38f4;
    private readonly p406baf6c$p8a91260e F42eddb4d;
    private readonly p406baf6c$p8a91260e F57d60766;
    private readonly bool F6071ccdd;
    private readonly bool F62608e08;
    private readonly p406baf6c$p8a91260e F7004a136;
    private readonly p1b0ecc4e$ped8626c7 F8b822ac5;
    private readonly pcc81e3f6 Fbfbd8079;
    private readonly pcc81e3f6 Fcd4f1aa1;
    private readonly p1b0ecc4e$ped8626c7 Fce57254d;
    private readonly bool Fd2a0ce0e;
    private readonly bool Fd3e13c26;
    private readonly pcc81e3f6 Ff23bad35;

    public static Logger Access$getLogger$cp()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f6db435f3
        return default!;
    }

    private void ReadData(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "PROTOCOL_ERROR: FLAG_COMPRESSED without SETTINGS_COMPRESS_DATA"
        // str: "PROTOCOL_ERROR: TYPE_DATA streamId == 0"
        // call: p1b0ecc4e$p910eef8c.lengthWithoutPadding
        // call: pcc81e3f6.readByte
        // call: IOException.<init>
        // call: pcc81e3f6.skip
        // call: p1b0ecc4e$p0bb4c52b.data
        // call: p23e8a4b4.and
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f910eef8c
        // type: IOException
    }

    private void ReadGoAway(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "TYPE_GOAWAY length < 8: "
        // str: "TYPE_GOAWAY streamId != 0"
        // str: "TYPE_GOAWAY unexpected error code: "
        // call: int.valueOf
        // call: pcc81e3f6.readInt
        // call: Intrinsics.stringPlus
        // call: p1b0ecc4e$p0bb4c52b.goAway
        // call: pcc81e3f6.readByteString
        // call: IOException.<init>
        // call: p9bc96b38$p910eef8c.fromHttp2
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // field: p38cb8f46.p58efa9e8.fba2b45bd
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f910eef8c
        // type: IOException
    }

    private List<object> ReadHeaderBlock(int P0, int P1, int P2, int P3)
    {
        // call: p1b0ecc4e$ped8626c7.setFlags
        // call: p1b0ecc4e$ped8626c7.setLeft
        // call: p406baf6c$p8a91260e.getAndResetHeaderList
        // call: p406baf6c$p8a91260e.readHeaders
        // call: p1b0ecc4e$ped8626c7.setPadding
        // call: p1b0ecc4e$ped8626c7.getLeft
        // call: p1b0ecc4e$ped8626c7.setLength
        // call: p1b0ecc4e$ped8626c7.setStreamId
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f42eddb4d
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f8b822ac5
        return default!;
    }

    private void ReadHeaders(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "PROTOCOL_ERROR: TYPE_HEADERS streamId == 0"
        // call: p1b0ecc4e.readHeaderBlock
        // call: pcc81e3f6.readByte
        // call: p23e8a4b4.and
        // call: IOException.<init>
        // call: p1b0ecc4e$p910eef8c.lengthWithoutPadding
        // call: p1b0ecc4e$p0bb4c52b.headers
        // call: p1b0ecc4e.readPriority
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f910eef8c
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // type: IOException
    }

    private void ReadPing(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "TYPE_PING length != 8: "
        // str: "TYPE_PING streamId != 0"
        // call: pcc81e3f6.readInt
        // call: p1b0ecc4e$p0bb4c52b.ping
        // call: IOException.<init>
        // call: Intrinsics.stringPlus
        // call: int.valueOf
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // type: IOException
    }

    private void ReadPriority(p1b0ecc4e$p0bb4c52b P0, int P1)
    {
        // call: p23e8a4b4.and
        // call: pcc81e3f6.readInt
        // call: p1b0ecc4e$p0bb4c52b.priority
        // call: pcc81e3f6.readByte
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
    }

    private void ReadPriority(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "TYPE_PRIORITY streamId == 0"
        // str: "TYPE_PRIORITY length: "
        // str: " != 5"
        // call: IOException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p1b0ecc4e.readPriority
        // call: StringBuilder.toString
        // type: IOException
        // type: StringBuilder
    }

    private void ReadPushPromise(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "PROTOCOL_ERROR: TYPE_PUSH_PROMISE streamId == 0"
        // call: p23e8a4b4.and
        // call: p1b0ecc4e$p0bb4c52b.pushPromise
        // call: pcc81e3f6.readByte
        // call: IOException.<init>
        // call: p1b0ecc4e.readHeaderBlock
        // call: p1b0ecc4e$p910eef8c.lengthWithoutPadding
        // call: pcc81e3f6.readInt
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f910eef8c
        // type: IOException
    }

    private void ReadRstStream(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "TYPE_RST_STREAM unexpected error code: "
        // str: " != 4"
        // str: "TYPE_RST_STREAM streamId == 0"
        // str: "TYPE_RST_STREAM length: "
        // call: StringBuilder.toString
        // call: p1b0ecc4e$p0bb4c52b.rstStream
        // call: Intrinsics.stringPlus
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IOException.<init>
        // call: int.valueOf
        // call: pcc81e3f6.readInt
        // call: p9bc96b38$p910eef8c.fromHttp2
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f910eef8c
        // type: StringBuilder
        // type: IOException
    }

    private void ReadSettings(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "TYPE_SETTINGS streamId != 0"
        // str: "PROTOCOL_ERROR SETTINGS_ENABLE_PUSH != 0 or 1"
        // str: "FRAME_SIZE_ERROR ack frame should be empty!"
        // str: "TYPE_SETTINGS length % 6 != 0: "
        // str: "PROTOCOL_ERROR SETTINGS_MAX_FRAME_SIZE: "
        // str: "PROTOCOL_ERROR SETTINGS_INITIAL_WINDOW_SIZE > 2^31 - 1"
        // call: IOException.<init>
        // call: RangesKt.until
        // call: pf4f70727.set
        // call: IntProgression.getLast
        // call: RangesKt.step
        // call: pf4f70727.<init>
        // call: int.valueOf
        // call: IntProgression.getFirst
        // call: p1b0ecc4e$p0bb4c52b.ackSettings
        // call: Intrinsics.stringPlus
        // call: p1b0ecc4e$p0bb4c52b.settings
        // call: IntProgression.getStep
        // call: pcc81e3f6.readShort
        // call: p23e8a4b4.and
        // call: pcc81e3f6.readInt
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // type: pf4f70727
        // type: IOException
    }

    private void ReadWindowUpdate(p1b0ecc4e$p0bb4c52b P0, int P1, int P2, int P3)
    {
        // str: "windowSizeIncrement was 0"
        // str: "TYPE_WINDOW_UPDATE length !=4: "
        // call: p23e8a4b4.and
        // call: IOException.<init>
        // call: p1b0ecc4e$p0bb4c52b.windowUpdate
        // call: pcc81e3f6.readInt
        // call: int.valueOf
        // call: Intrinsics.stringPlus
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // type: IOException
    }

    public void Close()
    {
        // call: pcc81e3f6.close
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
    }

    public bool NextFrame(bool P0, p1b0ecc4e$p0bb4c52b P1)
    {
        // str: "Expected a SETTINGS frame but was "
        // str: "handler"
        // str: "FRAME_SIZE_ERROR: "
        // call: p1b0ecc4e.readPriority
        // call: p1b0ecc4e.readSettings
        // call: p1b0ecc4e.readPushPromise
        // call: pcc81e3f6.readByte
        // call: p23e8a4b4.and
        // call: pb354a53a.formattedType$okhttp
        // call: p1b0ecc4e.readWindowUpdate
        // call: pb354a53a.frameLog
        // call: Logger.isLoggable
        // call: Intrinsics.stringPlus
        // call: p1b0ecc4e.readRstStream
        // call: pcc81e3f6.skip
        // call: pcc81e3f6.readInt
        // call: p1b0ecc4e.readData
        // call: Logger.fine
        // call: int.valueOf
        // call: p1b0ecc4e.readPing
        // call: p1b0ecc4e.readGoAway
        // call: IOException.<init>
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f6db435f3
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f76425f17
        // type: IOException
        return false;
    }

    public void ReadConnectionPreface(p1b0ecc4e$p0bb4c52b P0)
    {
        // str: "Expected a connection header but was "
        // str: "Required SETTINGS preface not received"
        // str: "<< CONNECTION "
        // str: "handler"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: IOException.<init>
        // call: Logger.fine
        // call: p1b0ecc4e.nextFrame
        // call: p58efa9e8.utf8
        // call: Logger.isLoggable
        // call: p58efa9e8.hex
        // call: Intrinsics.areEqual
        // call: p58efa9e8.size
        // call: p23e8a4b4.format
        // call: pcc81e3f6.readByteString
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f0017a7c5
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f62608e08
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f36cd38f4
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f6db435f3
        // type: IOException
    }

}
