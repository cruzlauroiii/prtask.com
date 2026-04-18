namespace WillowMaze.Wasm.Decompiled;

public class Pe88e3082 : Pa8ad1191
{
    public static pe88e3082 F1fe07ceb;
    public static pe88e3082 F76425f17;

    private System.Numerics.BigInteger CheckValue(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // str: "Value out of range"
        // call: System.Numerics.BigInteger.compareTo
        // call: System.Numerics.BigInteger.signum
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return default!;
    }

    public System.Numerics.BigInteger[] Decode(System.Numerics.BigInteger P0, byte[] P1)
    {
        // str: "Malformed signature"
        // call: pe88e3082.encode
        // call: p80f8c729.size
        // call: IllegalArgumentException.<init>
        // call: pe88e3082.decodeValue
        // call: pff43b8de.m2a3f81d2
        // call: p301c7ed4.m89e75c46
        // type: IllegalArgumentException
        return default!;
    }

    private System.Numerics.BigInteger DecodeValue(System.Numerics.BigInteger P0, p80f8c729 P1, int P2)
    {
        // call: pe88e3082.checkValue
        // call: p80f8c729.getObjectAt
        // call: pf391b73d.getValue
        return default!;
    }

    public byte[] Encode(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // str: "26fb01c3327acfeb24e8c17b0eda53b44f577232ca449bf010193d296564ea"
        // call: pe88e3082.encodeValue
        // call: pd6ccb7fc.<init>
        // call: pb840b7ef.getEncoded
        // call: pb840b7ef.<init>
        // call: DecryptString.decryptString
        // type: pb840b7ef
        // type: pd6ccb7fc
        return default!;
    }

    private void EncodeValue(System.Numerics.BigInteger P0, pd6ccb7fc P1, System.Numerics.BigInteger P2)
    {
        // call: pe88e3082.checkValue
        // call: pf391b73d.<init>
        // call: pd6ccb7fc.add
        // type: pf391b73d
    }

}
