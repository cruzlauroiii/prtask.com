namespace WillowMaze.Wasm.Decompiled;

public class Paeb89c06
{
    private readonly MemoryStream F15fc4a53;
    private readonly MemoryStream F67b67ce3;

    public byte[] GetBytes()
    {
        // call: MemoryStream.toByteArray
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06.f15fc4a53
        return default!;
    }

    public byte[] GetPaddedBytes()
    {
        // call: paeb89c06.getPaddedBytes
        return default!;
    }

    public byte[] GetPaddedBytes(int P0)
    {
        // call: MemoryStream.size
        // call: MemoryStream.toByteArray
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06.f15fc4a53
        return default!;
    }

    public void U32(int P0)
    {
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06.f15fc4a53
    }

    public void WriteBigNum(System.Numerics.BigInteger P0)
    {
        // call: System.Numerics.BigInteger.toByteArray
        // call: paeb89c06.writeBlock
    }

    public void WriteBlock(byte[] P0)
    {
        // call: IllegalStateException.<init>
        // call: paeb89c06.u32
        // call: MemoryStream.write
        // call: IOException.getMessage
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06.f15fc4a53
        // type: IllegalStateException
    }

    public void WriteBytes(byte[] P0)
    {
        // call: IOException.getMessage
        // call: IllegalStateException.<init>
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06.f15fc4a53
        // type: IllegalStateException
    }

    public void WriteString(string P0)
    {
        // call: p89be9433.md6c3dad7
        // call: paeb89c06.writeBlock
    }

}
