namespace WillowMaze.Wasm.Decompiled;

public class P0402a594
{
    private int F5e0bdcbd;
    private int F63c06dc2;
    private readonly byte[] F7f2db423;
    private readonly byte[] F86130b41;
    private readonly byte[] Fac87966b;
    private int Fbb4f9670;
    private int Fdc77d09a;
    private int Ff30b6bfa;

    public byte[] GetBuffer()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f7f2db423
        return default!;
    }

    public bool HasRemaining()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f5e0bdcbd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f7f2db423
        return false;
    }

    public System.Numerics.BigInteger ReadBigNumPositive()
    {
        // str: "not enough data for big num"
        // call: System.Numerics.BigInteger.<init>
        // call: pff43b8de.mb084e52d
        // call: IllegalArgumentException.<init>
        // call: p0402a594.readU32
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f7f2db423
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f5e0bdcbd
        // type: IllegalArgumentException
        // type: System.Numerics.BigInteger
        return default!;
    }

    public byte[] ReadBlock()
    {
        // str: "not enough data for block"
        // call: pff43b8de.mb084e52d
        // call: p0402a594.readU32
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f5e0bdcbd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f7f2db423
        // type: IllegalArgumentException
        return default!;
    }

    public byte[] ReadPaddedBlock()
    {
        // call: p0402a594.readPaddedBlock
        return default!;
    }

    public byte[] ReadPaddedBlock(int P0)
    {
        // str: "missing padding"
        // str: "not enough data for block"
        // str: "incorrect padding"
        // call: pff43b8de.mb084e52d
        // call: IllegalArgumentException.<init>
        // call: p0402a594.readU32
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f7f2db423
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f5e0bdcbd
        // type: IllegalArgumentException
        return default!;
    }

    public string ReadString()
    {
        // call: p0402a594.readBlock
        // call: p89be9433.m89e75c46
        return string.Empty;
    }

    public int ReadU32()
    {
        // str: "4 bytes for U32 exceeds buffer."
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f5e0bdcbd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f7f2db423
        // type: IllegalArgumentException
        return 0;
    }

    public void SkipBlock()
    {
        // str: "not enough data for block"
        // call: p0402a594.readU32
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f5e0bdcbd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594.f7f2db423
        // type: IllegalArgumentException
    }

}
