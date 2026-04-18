namespace WillowMaze.Wasm.Decompiled;

public class P090ea2b4 : Pa8ad1191
{
    public static p090ea2b4 F17f350a0;
    public static p090ea2b4 F434db8a2;
    public static p090ea2b4 F76425f17;
    public static p090ea2b4 Fbeaddfb9;
    public static p090ea2b4 Fee6ea2c5;

    private void M298e9e2e(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1, byte[] P2, int P3, int P4)
    {
        // call: pff43b8de.ma552c747
        // call: p090ea2b4.checkValue
        // call: System.Numerics.BigInteger.toByteArray
        // call: Math.max
        // call: System.arraycopy
    }

    private System.Numerics.BigInteger CheckValue(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // str: "Value out of range"
        // call: System.Numerics.BigInteger.compareTo
        // call: IllegalArgumentException.<init>
        // call: System.Numerics.BigInteger.signum
        // type: IllegalArgumentException
        return default!;
    }

    public System.Numerics.BigInteger[] Decode(System.Numerics.BigInteger P0, byte[] P1)
    {
        // str: "Encoding has incorrect length"
        // call: p090ea2b4.decodeValue
        // call: IllegalArgumentException.<init>
        // call: p68e35a3f.m0894479c
        // type: IllegalArgumentException
        return default!;
    }

    private System.Numerics.BigInteger DecodeValue(System.Numerics.BigInteger P0, byte[] P1, int P2, int P3)
    {
        // call: p090ea2b4.checkValue
        // call: pff43b8de.mb084e52d
        // call: System.Numerics.BigInteger.<init>
        // type: System.Numerics.BigInteger
        return default!;
    }

    public byte[] Encode(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // call: p68e35a3f.m0894479c
        // call: p090ea2b4.m298e9e2e
        return default!;
    }

}
