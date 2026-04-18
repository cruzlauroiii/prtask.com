namespace WillowMaze.Wasm.Decompiled;

public class P2aacdd87 : P38d4f313
{
    private static System.Numerics.BigInteger F9140e166;
    private static System.Numerics.BigInteger Fbc21e648;
    private pc9dc4fec F3c6e0b8a;
    private p4460e12a F80c66df7;
    private pc9dc4fec Faa548528;
    private p4460e12a Fc16955d9;

    public System.Numerics.BigInteger CalculateAgreement(pc9ef6b45 P0)
    {
        // str: "Shared key can't be 1"
        // str: "Diffie-Hellman public key is weak"
        // str: "Diffie-Hellman public key has wrong parameters."
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.equals
        // call: p4460e12a.equals
        // call: p4460e12a.getP
        // call: p1bfd3a52.getParameters
        // call: IllegalArgumentException.<init>
        // call: System.Numerics.BigInteger.subtract
        // call: p1bfd3a52.getY
        // call: pc9dc4fec.getX
        // call: System.Numerics.BigInteger.compareTo
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87.f80c66df7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87.f3c6e0b8a
        // type: IllegalArgumentException
        // type: IllegalStateException
        return default!;
    }

    public int GetFieldSize()
    {
        // call: p4460e12a.getP
        // call: System.Numerics.BigInteger.bitLength
        // call: pc9dc4fec.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87.f3c6e0b8a
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "DHEngine expects DHPrivateKeyParameters"
        // call: pc9dc4fec.getParameters
        // call: IllegalArgumentException.<init>
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87.f80c66df7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87.f3c6e0b8a
        // type: IllegalArgumentException
    }

}
