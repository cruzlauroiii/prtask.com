namespace WillowMaze.Wasm.Decompiled;

public class Pe3f477cc : Pae380b4d
{
    private System.Security.Cryptography.RandomNumberGenerator F0d73ecb9;
    private p1235ff36 F3c6e0b8a;
    private p1235ff36 F521282b1;
    private p1235ff36 F6a4d3e1e;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private System.Security.Cryptography.RandomNumberGenerator F99486d04;
    private p1235ff36 Fbe0b2d83;
    private p1235ff36 Fd3b0f207;

    private p267d2b96 CreateBasePointMultiplier()
    {
        // call: p90de1a81.<init>
        // type: p90de1a81
        return default!;
    }

    public System.Numerics.BigInteger[] GenerateSignature(byte[] P0)
    {
        // call: p1235ff36.getParameters
        // call: p68e35a3f.m861a7ab4
        // call: p53a5793f.getAffineXCoord
        // call: System.Numerics.BigInteger.<init>
        // call: System.Numerics.BigInteger.mod
        // call: p5a196a0a.toBigInteger
        // call: p21c2eb74.getN
        // call: System.Numerics.BigInteger.multiply
        // call: p267d2b96.multiply
        // call: System.Numerics.BigInteger.add
        // call: pff43b8de.m4d9c2073
        // call: System.Numerics.BigInteger.equals
        // call: p06022b5a.getD
        // call: pe3f477cc.createBasePointMultiplier
        // call: p53a5793f.normalize
        // call: System.Numerics.BigInteger.bitLength
        // call: p21c2eb74.getG
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe3f477cc.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe3f477cc.f7ddf32e1
        // type: System.Numerics.BigInteger
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // call: p21c2eb74.getN
        // call: p1235ff36.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe3f477cc.f3c6e0b8a
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getRandom
        // call: pa9682fb5.m07091bf1
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe3f477cc.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe3f477cc.f3c6e0b8a
    }

    public bool VerifySignature(byte[] P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // call: p5a196a0a.toBigInteger
        // call: p8ede7675.m226e8dbb
        // call: System.Numerics.BigInteger.multiply
        // call: System.Numerics.BigInteger.mod
        // call: p53a5793f.isInfinity
        // call: p68e35a3f.me90945d8
        // call: pff43b8de.m4d9c2073
        // call: p1235ff36.getParameters
        // call: p53a5793f.normalize
        // call: System.Numerics.BigInteger.compareTo
        // call: pd16c2d8e.getQ
        // call: System.Numerics.BigInteger.subtract
        // call: System.Numerics.BigInteger.equals
        // call: p53a5793f.getAffineXCoord
        // call: p21c2eb74.getN
        // call: p21c2eb74.getG
        // call: System.Numerics.BigInteger.<init>
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe3f477cc.f3c6e0b8a
        // type: System.Numerics.BigInteger
        return false;
    }

}
