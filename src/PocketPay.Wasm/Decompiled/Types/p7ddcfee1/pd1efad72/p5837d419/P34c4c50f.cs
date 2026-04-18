namespace WillowMaze.Wasm.Decompiled;

public class P34c4c50f
{
    private static int F006577c6;
    private static long F037fd266;
    private static int F26153c54;
    private static int F36285302;
    private static int F39d7c030;
    private static int F426d3ae0;
    private static int F49edc961;
    public static p34c4c50f$p910eef8c F5701fb70;
    public static p58efa9e8 F5fd832f7;
    public static p58efa9e8 F638b2308;
    private static long F7ad8f07d;
    public static p34c4c50f$p910eef8c F7f7b7e62;
    private static int F903f618c;
    public static p34c4c50f$p910eef8c F910eef8c;
    private static int F95d500fd;
    public static p34c4c50f$p910eef8c F9f3f3ab8;
    public static p58efa9e8 Fba23e361;
    public static p58efa9e8 Fc7a35402;
    public static p58efa9e8 Fd26b6e1f;
    private static long Fd74cc577;
    public static p58efa9e8 Fdf861d39;
    public static p58efa9e8 Fe34c0b6c;
    public static p34c4c50f$p910eef8c Fe4efed8f;
    private static int Fe5dfefd3;
    private static long Feed5e47a;
    private readonly long F1bdeee89;
    private bool F2bb32f52;
    private readonly p58efa9e8 F2f402f50;
    private readonly p7e62bc34 F3041c946;
    private long F3d67b031;
    private readonly p7e62bc34 F46808aee;
    private int F4a74eb1e;
    private Thread F4cc5ce1c;
    private int F509ae5c6;
    private int F6181ff2a;
    private bool F65d04d1f;
    private long F758a9b32;
    private int F78f4a40e;
    private readonly p7e62bc34 F7f2db423;
    private int F8146247a;
    private RandomAccessFile F83a532fb;
    private RandomAccessFile F8c7dd922;
    private readonly p7e62bc34 F9966ba3e;
    private readonly p58efa9e8 F9f81f3c0;
    private Thread F9ff607ff;
    private readonly long Fb0b8c4ff;
    private long Fba873e5d;
    private readonly long Fbc0cd606;
    private pf31bbdd1 Fbc3b0556;
    private Thread Fc9f16e4a;
    private long Fca7847cd;
    private pf31bbdd1 Fca945b72;
    private bool Fcef2b857;
    private bool Fd9a22d7a;
    private RandomAccessFile Ff7ff10ff;

    public static void Access$writeHeader(p34c4c50f P0, p58efa9e8 P1, long P2, long P3)
    {
        // call: p34c4c50f.writeHeader
    }

    private void WriteHeader(p58efa9e8 P0, long P1, long P2)
    {
        // str: "Failed requirement."
        // str: "file!!.channel"
        // call: p7e62bc34.writeLong
        // call: IllegalArgumentException.<init>
        // call: p9efefad6.write
        // call: p7e62bc34.write
        // call: RandomAccessFile.getChannel
        // call: p7e62bc34.size
        // call: p9efefad6.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: object.toString
        // call: p7e62bc34.<init>
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f8c7dd922
        // type: p7e62bc34
        // type: p9efefad6
        // type: IllegalArgumentException
    }

    private void WriteMetadata(long P0)
    {
        // str: "file!!.channel"
        // call: p7e62bc34.write
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p58efa9e8.size
        // call: p9efefad6.write
        // call: p7e62bc34.<init>
        // call: p9efefad6.<init>
        // call: RandomAccessFile.getChannel
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f8c7dd922
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f9f81f3c0
        // type: p9efefad6
        // type: p7e62bc34
    }

    public void Commit(long P0)
    {
        // call: p34c4c50f.writeMetadata
        // call: Intrinsics.checkNotNull
        // call: p34c4c50f.writeHeader
        // call: RandomAccessFile.getChannel
        // call: p23e8a4b4.closeQuietly
        // call: FileChannel.force
        // call: p58efa9e8.size
        // call: p34c4c50f.setComplete
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fbc3b0556
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fba23e361
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f9f81f3c0
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f8c7dd922
    }

    public p7e62bc34 GetBuffer()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f7f2db423
        return default!;
    }

    public long GetBufferMaxSize()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f1bdeee89
        return 0;
    }

    public bool GetComplete()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fd9a22d7a
        return false;
    }

    public RandomAccessFile GetFile()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f8c7dd922
        return default!;
    }

    public int GetSourceCount()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f78f4a40e
        return 0;
    }

    public pf31bbdd1 GetUpstream()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fbc3b0556
        return default!;
    }

    public p7e62bc34 GetUpstreamBuffer()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f46808aee
        return default!;
    }

    public long GetUpstreamPos()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fca7847cd
        return 0;
    }

    public Thread GetUpstreamReader()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f9ff607ff
        return default!;
    }

    public bool IsClosed()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f8c7dd922
        return false;
    }

    public p58efa9e8 Metadata()
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f9f81f3c0
        return default!;
    }

    public pf31bbdd1 NewSource()
    {
        // call: p34c4c50f.getSourceCount
        // call: p34c4c50f.setSourceCount
        // call: p34c4c50f.getFile
        // call: p34c4c50f$p8a348876.<init>
        // type: p34c4c50f$p8a348876
        return default!;
    }

    public void SetComplete(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fd9a22d7a
    }

    public void SetFile(RandomAccessFile P0)
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f8c7dd922
    }

    public void SetSourceCount(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f78f4a40e
    }

    public void SetUpstream(pf31bbdd1 P0)
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fbc3b0556
    }

    public void SetUpstreamPos(long P0)
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fca7847cd
    }

    public void SetUpstreamReader(Thread P0)
    {
        // field: p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.f9ff607ff
    }

}
