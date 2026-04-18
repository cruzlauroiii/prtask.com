namespace WillowMaze.Wasm.Decompiled;

public class Pc74ae48a : P1eb558b5
{
    private readonly Deflater F0a8ccfbb;
    private readonly Deflater F1a603cb5;
    private readonly p08d84bc6 F3283eaa5;
    private bool F348ecf1e;
    private bool F349e6863;
    private readonly Deflater F66894bef;
    private readonly Deflater Fc53e9330;
    private bool Fc5714fce;
    private bool Fd96369ff;
    private readonly p08d84bc6 Ff6e04117;
    private readonly p08d84bc6 Ff75219b2;

    private void M7e8bb5a8(bool P0)
    {
        // call: p08d84bc6.emitCompleteSegments
        // call: p7e62bc34.writableSegment$okio
        // call: Deflater.deflate
        // call: Deflater.needsInput
        // call: p4b77e2a9.pop
        // call: p08d84bc6.getBuffer
        // call: p7e62bc34.setSize$okio
        // call: p7e62bc34.size
        // call: p2700aee4.mf914097e
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.pc74ae48a.f0a8ccfbb
        // field: p38cb8f46.pc74ae48a.ff6e04117
        // field: p38cb8f46.p7e62bc34.f96e89a29
    }

    public void Close()
    {
        // call: Deflater.end
        // call: pc74ae48a.finishDeflate$okio
        // call: p08d84bc6.close
        // field: p38cb8f46.pc74ae48a.f0a8ccfbb
        // field: p38cb8f46.pc74ae48a.f349e6863
        // field: p38cb8f46.pc74ae48a.ff6e04117
    }

    public void FinishDeflate$okio()
    {
        // call: pc74ae48a.m7e8bb5a8
        // call: Deflater.finish
        // field: p38cb8f46.pc74ae48a.f0a8ccfbb
    }

    public void Flush()
    {
        // call: pc74ae48a.m7e8bb5a8
        // call: p08d84bc6.flush
        // field: p38cb8f46.pc74ae48a.ff6e04117
    }

    public pc85a251c Timeout()
    {
        // call: p08d84bc6.timeout
        // field: p38cb8f46.pc74ae48a.ff6e04117
        return default!;
    }

    public string ToString()
    {
        // str: "DeflaterSink("
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p38cb8f46.pc74ae48a.ff6e04117
        // type: StringBuilder
        return string.Empty;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "source"
        // call: Deflater.setInput
        // call: Intrinsics.checkNotNullParameter
        // call: Math.min
        // call: pc74ae48a.m7e8bb5a8
        // call: p4b77e2a9.pop
        // call: p2700aee4.mf914097e
        // call: Intrinsics.checkNotNull
        // call: p2ff17a65.m799a7e61
        // call: p7e62bc34.setSize$okio
        // call: p7e62bc34.size
        // field: p38cb8f46.pc74ae48a.f0a8ccfbb
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p4b77e2a9.f8d777f38
    }

}
