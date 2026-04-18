namespace WillowMaze.Wasm.Decompiled;

public class P879a2d24 : Pf31bbdd1
{
    private readonly pc85a251c F68955df3;
    private readonly Stream F6dbddd12;
    private readonly pc85a251c F90272dda;
    private readonly pc85a251c F911f2682;
    private readonly Stream Fa43c1b0a;
    private readonly Stream Fd5897f93;
    private readonly Stream Ffd5dd19e;

    public void Close()
    {
        // call: Stream.close
        // field: p38cb8f46.p879a2d24.fa43c1b0a
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "byteCount < 0: "
        // str: "sink"
        // call: IOException.<init>
        // call: object.toString
        // call: pc85a251c.throwIfReached
        // call: p7e62bc34.writableSegment$okio
        // call: Math.min
        // call: Stream.read
        // call: p4b77e2a9.pop
        // call: p2700aee4.mf914097e
        // call: p7e62bc34.size
        // call: p7e62bc34.setSize$okio
        // call: p0af9afa4.m87df3e77
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p879a2d24.f90272dda
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p879a2d24.fa43c1b0a
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // type: StringBuilder
        // type: IllegalArgumentException
        // type: IOException
        return 0;
    }

    public pc85a251c Timeout()
    {
        // field: p38cb8f46.p879a2d24.f90272dda
        return default!;
    }

    public string ToString()
    {
        // str: "source("
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // field: p38cb8f46.p879a2d24.fa43c1b0a
        // type: StringBuilder
        return string.Empty;
    }

}
