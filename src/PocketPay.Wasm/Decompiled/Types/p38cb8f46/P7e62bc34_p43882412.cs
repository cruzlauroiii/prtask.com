namespace WillowMaze.Wasm.Decompiled;

public class P7e62bc34_p43882412 : IDisposable
{
    public p7e62bc34 F0c16c8a3;
    public int F102273a6;
    public int F17c7af11;
    public bool F227a0f27;
    public p7e62bc34 F228180da;
    public byte[] F2a81a15d;
    public int F5e7be23c;
    public p7e62bc34 F5ede1b07;
    public bool F6bf4941c;
    public int F76c610aa;
    public long F7a86c157;
    public int F7f021a14;
    public p7e62bc34 F7f2db423;
    public byte[] F8435f036;
    public long F8829b0b5;
    public byte[] F8d777f38;
    public long F9287dfa7;
    public byte[] F959eb2b6;
    public byte[] F9716837d;
    private p4b77e2a9 Fabedf0ea;
    public long Fe8febab5;
    public int Fea2b2676;
    public int Fef0b6af4;
    public p7e62bc34 Ff4312760;
    private p4b77e2a9 Ffdd32b90;
    public bool Ffe9e616f;

    public void Close()
    {
        // str: "not attached to a buffer"
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p7e62bc34$p43882412.setSegment$okio
        // field: p38cb8f46.p7e62bc34$p43882412.f7f2db423
        // field: p38cb8f46.p7e62bc34$p43882412.f7a86c157
        // field: p38cb8f46.p7e62bc34$p43882412.f7f021a14
        // field: p38cb8f46.p7e62bc34$p43882412.f8d777f38
        // field: p38cb8f46.p7e62bc34$p43882412.fea2b2676
        // type: IllegalStateException
    }

    public long ExpandBuffer(int P0)
    {
        // str: "minByteCount > Segment.SIZE: "
        // str: "not attached to a buffer"
        // str: "minByteCount <= 0: "
        // str: "expandBuffer() only permitted for read/write buffers"
        // call: IllegalArgumentException.<init>
        // call: object.toString
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p7e62bc34.size
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: p7e62bc34$p43882412.setSegment$okio
        // call: p7e62bc34.setSize$okio
        // call: p7e62bc34.writableSegment$okio
        // field: p38cb8f46.p7e62bc34$p43882412.f8d777f38
        // field: p38cb8f46.p7e62bc34$p43882412.fea2b2676
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p7e62bc34$p43882412.f7f2db423
        // field: p38cb8f46.p7e62bc34$p43882412.f7f021a14
        // field: p38cb8f46.p7e62bc34$p43882412.f6bf4941c
        // field: p38cb8f46.p7e62bc34$p43882412.f7a86c157
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: IllegalStateException
        return 0;
    }

    public p4b77e2a9 GetSegment$okio()
    {
        // field: p38cb8f46.p7e62bc34$p43882412.ffdd32b90
        return default!;
    }

    public int Next()
    {
        // str: "no more bytes"
        // call: Intrinsics.checkNotNull
        // call: p7e62bc34$p43882412.seek
        // call: IllegalStateException.<init>
        // call: p7e62bc34.size
        // call: object.toString
        // field: p38cb8f46.p7e62bc34$p43882412.f7f2db423
        // field: p38cb8f46.p7e62bc34$p43882412.f7a86c157
        // field: p38cb8f46.p7e62bc34$p43882412.f7f021a14
        // field: p38cb8f46.p7e62bc34$p43882412.fea2b2676
        // type: IllegalStateException
        return 0;
    }

    public long ResizeBuffer(long P0)
    {
        // str: "resizeBuffer() only permitted for read/write buffers"
        // str: "not attached to a buffer"
        // str: "newSize < 0: "
        // call: p7e62bc34.size
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNull
        // call: p7e62bc34$p43882412.setSegment$okio
        // call: p2700aee4.mf914097e
        // call: object.toString
        // call: p7e62bc34.setSize$okio
        // call: IllegalStateException.<init>
        // call: p4b77e2a9.pop
        // call: p7e62bc34.writableSegment$okio
        // call: Math.min
        // call: StringBuilder.<init>
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p7e62bc34$p43882412.f8d777f38
        // field: p38cb8f46.p7e62bc34$p43882412.f7a86c157
        // field: p38cb8f46.p7e62bc34$p43882412.f7f021a14
        // field: p38cb8f46.p7e62bc34$p43882412.fea2b2676
        // field: p38cb8f46.p7e62bc34$p43882412.f7f2db423
        // field: p38cb8f46.p7e62bc34$p43882412.f6bf4941c
        // field: p38cb8f46.p4b77e2a9.ffcb08b16
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // type: StringBuilder
        // type: IllegalArgumentException
        // type: IllegalStateException
        return 0;
    }

    public int Seek(long P0)
    {
        // str: "offset="
        // str: " > size="
        // str: "not attached to a buffer"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p7e62bc34.size
        // call: Intrinsics.checkNotNull
        // call: p7e62bc34$p43882412.getSegment$okio
        // call: p4b77e2a9.pop
        // call: p7e62bc34$p43882412.setSegment$okio
        // call: p4b77e2a9.push
        // call: StringBuilder.<init>
        // call: object.toString
        // call: p4b77e2a9.unsharedCopy
        // call: ArrayIndexOutOfBoundsException.<init>
        // call: IllegalStateException.<init>
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p7e62bc34$p43882412.f7f021a14
        // field: p38cb8f46.p7e62bc34$p43882412.f7a86c157
        // field: p38cb8f46.p7e62bc34$p43882412.f8d777f38
        // field: p38cb8f46.p7e62bc34$p43882412.fea2b2676
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p4b77e2a9.ffcb08b16
        // field: p38cb8f46.p4b77e2a9.fd0cab90d
        // field: p38cb8f46.p7e62bc34$p43882412.f7f2db423
        // field: p38cb8f46.p7e62bc34$p43882412.f6bf4941c
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.f9e81e7b9
        // type: ArrayIndexOutOfBoundsException
        // type: IllegalStateException
        // type: StringBuilder
        return 0;
    }

    public void SetSegment$okio(p4b77e2a9 P0)
    {
        // field: p38cb8f46.p7e62bc34$p43882412.ffdd32b90
    }

}
