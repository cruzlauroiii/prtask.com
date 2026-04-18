namespace WillowMaze.Wasm.Decompiled;

public class P8ac70daa : Pf31bbdd1
{
    private readonly Inflater F0ae7f9d1;
    private int F11ba1aa9;
    private bool F349e6863;
    private readonly pcc81e3f6 F36cd38f4;
    private readonly Inflater F62cd49b2;
    private readonly pcc81e3f6 F7d6108b8;
    private readonly Inflater F8c0dd53b;
    private int F8f04ef67;
    private readonly Inflater F982b14cd;
    private readonly Inflater F9cc391ba;
    private bool Fbc48ad1c;
    private bool Fc30fa3d9;

    private void M0e7d0da6()
    {
        // call: Inflater.getRemaining
        // call: pcc81e3f6.skip
        // field: p38cb8f46.p8ac70daa.f0ae7f9d1
        // field: p38cb8f46.p8ac70daa.f8f04ef67
        // field: p38cb8f46.p8ac70daa.f36cd38f4
    }

    public void Close()
    {
        // call: pcc81e3f6.close
        // call: Inflater.end
        // field: p38cb8f46.p8ac70daa.f349e6863
        // field: p38cb8f46.p8ac70daa.f0ae7f9d1
        // field: p38cb8f46.p8ac70daa.f36cd38f4
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "sink"
        // str: "source exhausted prematurely"
        // call: EOFException.<init>
        // call: Inflater.finished
        // call: Intrinsics.checkNotNullParameter
        // call: Inflater.needsDictionary
        // call: p8ac70daa.readOrInflate
        // call: pcc81e3f6.exhausted
        // field: p38cb8f46.p8ac70daa.f0ae7f9d1
        // field: p38cb8f46.p8ac70daa.f36cd38f4
        // type: EOFException
        return 0;
    }

    public long ReadOrInflate(p7e62bc34 P0, long P1)
    {
        // str: "sink"
        // str: "closed"
        // str: "byteCount < 0: "
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p7e62bc34.writableSegment$okio
        // call: Math.min
        // call: p8ac70daa.refill
        // call: Inflater.inflate
        // call: p8ac70daa.m0e7d0da6
        // call: p7e62bc34.size
        // call: p7e62bc34.setSize$okio
        // call: p4b77e2a9.pop
        // call: p2700aee4.mf914097e
        // call: IOException.<init>
        // call: IllegalArgumentException.<init>
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p8ac70daa.f0ae7f9d1
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p8ac70daa.f349e6863
        // type: StringBuilder
        // type: IllegalStateException
        // type: IllegalArgumentException
        // type: IOException
        return 0;
    }

    public bool Refill()
    {
        // call: Inflater.setInput
        // call: pcc81e3f6.getBuffer
        // call: Intrinsics.checkNotNull
        // call: Inflater.needsInput
        // call: pcc81e3f6.exhausted
        // field: p38cb8f46.p8ac70daa.f8f04ef67
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p8ac70daa.f36cd38f4
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p8ac70daa.f0ae7f9d1
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        return false;
    }

    public pc85a251c Timeout()
    {
        // call: pcc81e3f6.timeout
        // field: p38cb8f46.p8ac70daa.f36cd38f4
        return default!;
    }

}
