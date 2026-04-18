namespace WillowMaze.Wasm.Decompiled;

public class P8ca44722 : Pae380b4d
{
    private p1235ff36 F2e4d972c;
    private p1235ff36 F3c6e0b8a;
    private p1235ff36 F4e1334c0;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private p1235ff36 F9d285321;
    private System.Security.Cryptography.RandomNumberGenerator Fa368e0d1;
    private System.Security.Cryptography.RandomNumberGenerator Fac81145b;
    private System.Security.Cryptography.RandomNumberGenerator Fd8a4e3e2;

    private p267d2b96 CreateBasePointMultiplier()
    {
        // call: p90de1a81.<init>
        // type: p90de1a81
        return default!;
    }

    public System.Numerics.BigInteger[] GenerateSignature(byte[] P0)
    {
        // call: p21c2eb74.getG
        // call: p8ca44722.createBasePointMultiplier
        // call: p53a5793f.normalize
        // call: System.Numerics.BigInteger.mod
        // call: System.Numerics.BigInteger.bitLength
        // call: p5a196a0a.toBigInteger
        // call: System.Numerics.BigInteger.<init>
        // call: p1235ff36.getParameters
        // call: System.Numerics.BigInteger.add
        // call: p21c2eb74.getN
        // call: System.Numerics.BigInteger.multiply
        // call: System.Numerics.BigInteger.equals
        // call: p267d2b96.multiply
        // call: p06022b5a.getD
        // call: pff43b8de.m4d9c2073
        // call: p68e35a3f.m861a7ab4
        // call: p53a5793f.getAffineXCoord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p8ca44722.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p8ca44722.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b
        // type: System.Numerics.BigInteger
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // call: p1235ff36.getParameters
        // call: p21c2eb74.getN
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p8ca44722.f3c6e0b8a
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getParameters
        // call: pa9682fb5.m07091bf1
        // call: p4715f007.getRandom
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p8ca44722.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p8ca44722.f3c6e0b8a
    }

    public bool VerifySignature(byte[] P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // call: pff43b8de.m4d9c2073
        // call: System.Numerics.BigInteger.compareTo
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getAffineXCoord
        // call: System.Numerics.BigInteger.mod
        // call: p8ede7675.m226e8dbb
        // call: System.Numerics.BigInteger.equals
        // call: System.Numerics.BigInteger.multiply
        // call: pd16c2d8e.getQ
        // call: System.Numerics.BigInteger.<init>
        // call: p1235ff36.getParameters
        // call: System.Numerics.BigInteger.subtract
        // call: p5a196a0a.toBigInteger
        // call: p53a5793f.normalize
        // call: p68e35a3f.me90945d8
        // call: p21c2eb74.getN
        // call: p21c2eb74.getG
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p8ca44722.f3c6e0b8a
        // type: System.Numerics.BigInteger
        return false;
    }

}
