namespace WillowMaze.Wasm.Decompiled;

public class P72436115
{
    private readonly List<object> Fb65280eb;
    private readonly List<object> Fd82b2e0b;
    private readonly List<object> Fe34b9c64;
    private readonly List<object> Fe96ef487;

    private static p34dacb78 M21879d3d(string P0, string P1, int P2, int P3)
    {
        // str: "UTC"
        // call: string.equals
        // call: pd70f43ec.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d
        // type: pd70f43ec
        return default!;
    }

    private static long M47410cb8(DataInput P0)
    {
        // call: DataInput.readUnsignedByte
        // call: DataInput.readLong
        return 0;
    }

    private p72436115$peb91ed7a M567cc009()
    {
        // call: List<object>.size
        // call: List<object>.get
        // call: p72436115.addCutover
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.fe34b9c64
        return default!;
    }

    public static p34dacb78 Mbf464907(DataInput P0, string P1)
    {
        // str: "Invalid encoding"
        // call: p72436115.m47410cb8
        // call: IOException.<init>
        // call: DataInput.readUnsignedByte
        // call: pd70f43ec.<init>
        // call: p34dacb78.equals
        // call: p72436115$p4b16c53e.mbf464907
        // call: p12929327.mb3659554
        // call: DataInput.readUTF
        // field: p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d
        // type: pd70f43ec
        // type: IOException
        return default!;
    }

    public static p34dacb78 Mbf464907(Stream P0, string P1)
    {
        // call: p72436115.mbf464907
        // call: DataInputStream.<init>
        // type: DataInputStream
        return default!;
    }

    private bool Mcca07d1e(List<object> P0, p72436115$pafedf9af P1)
    {
        // call: p72436115$pafedf9af.getMillis
        // call: p72436115$pafedf9af.withMillis
        // call: List<object>.size
        // call: List<object>.add
        // call: p72436115$pafedf9af.getWallOffset
        // call: List<object>.get
        // call: p72436115$pafedf9af.isTransitionFrom
        // call: p72436115.mcca07d1e
        // call: List<object>.remove
        return false;
    }

    private static void Me26a9a75(DataOutput P0, long P1)
    {
        // call: DataOutput.writeByte
        // call: DataOutput.writeInt
        // call: DataOutput.writeLong
    }

    public p72436115 AddCutover(int P0, char P1, int P2, int P3, int P4, bool P5, int P6)
    {
        // call: List<object>.size
        // call: p72436115$peb91ed7a.<init>
        // call: p72436115$p5990edb2.<init>
        // call: p72436115$peb91ed7a.setUpperLimit
        // call: List<object>.add
        // call: List<object>.get
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.fe34b9c64
        // type: p72436115$p5990edb2
        // type: p72436115$peb91ed7a
        return default!;
    }

    public p72436115 AddRecurringSavings(string P0, int P1, int P2, int P3, char P4, int P5, int P6, int P7, bool P8, int P9)
    {
        // call: p72436115.m567cc009
        // call: p72436115$pab7a485e.<init>
        // call: p72436115$pa38ed59a.<init>
        // call: p72436115$p5990edb2.<init>
        // call: p72436115$peb91ed7a.addRule
        // type: p72436115$pa38ed59a
        // type: p72436115$pab7a485e
        // type: p72436115$p5990edb2
        return default!;
    }

    public p72436115 SetFixedSavings(string P0, int P1)
    {
        // call: p72436115$peb91ed7a.setFixedSavings
        // call: p72436115.m567cc009
        return default!;
    }

    public p72436115 SetStandardOffset(int P0)
    {
        // call: p72436115$peb91ed7a.setStandardOffset
        // call: p72436115.m567cc009
        return default!;
    }

    public p34dacb78 ToDateTimeZone(string P0, bool P1)
    {
        // str: "UTC"
        // call: p72436115$pafedf9af.getMillis
        // call: p72436115.mcca07d1e
        // call: p12929327.mb3659554
        // call: List<object>.<init>
        // call: List<object>.get
        // call: List<object>.size
        // call: p72436115$peb91ed7a.<init>
        // call: p72436115.m21879d3d
        // call: p72436115$peb91ed7a.nextTransition
        // call: p72436115$pafedf9af.getNameKey
        // call: p72436115$peb91ed7a.firstTransition
        // call: p72436115$peb91ed7a.getUpperLimit
        // call: p72436115$pafedf9af.getWallOffset
        // call: p72436115$p4b16c53e.m76ea0beb
        // call: IllegalArgumentException.<init>
        // call: p72436115$peb91ed7a.buildTailZone
        // call: p72436115$p4b16c53e.isCachable
        // call: p72436115$pafedf9af.getStandardOffset
        // call: p72436115$pafedf9af.getSaveMillis
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.fe34b9c64
        // type: List<object>
        // type: p72436115$peb91ed7a
        // type: IllegalArgumentException
        return default!;
    }

    public void WriteTo(string P0, DataOutput P1)
    {
        // call: DataOutput.writeUTF
        // call: DataOutput.writeByte
        // call: p72436115.me26a9a75
        // call: p34dacb78.getOffset
        // call: p34dacb78.getNameKey
        // call: p12929327.getUncachedZone
        // call: p72436115.toDateTimeZone
        // call: p72436115$p4b16c53e.writeTo
        // call: p34dacb78.getStandardOffset
    }

    public void WriteTo(string P0, Stream P1)
    {
        // call: p72436115.writeTo
        // call: DataOutputStream.flush
        // call: DataOutputStream.<init>
        // type: DataOutputStream
    }

}
