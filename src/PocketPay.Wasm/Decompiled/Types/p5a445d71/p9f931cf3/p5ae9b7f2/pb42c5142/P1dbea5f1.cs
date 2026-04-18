namespace WillowMaze.Wasm.Decompiled;

public class P1dbea5f1 : Pae380b4d
{
    private static System.Numerics.BigInteger F1ff54435;
    private static System.Numerics.BigInteger Fbc21e648;
    private static System.Numerics.BigInteger Fc1cb0577;
    private System.Security.Cryptography.RandomNumberGenerator F2701d7a4;
    private p1235ff36 F3c6e0b8a;
    private p1235ff36 F3e499ad7;
    private p1235ff36 F76f914ae;
    private p1235ff36 F7da1cff0;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private System.Security.Cryptography.RandomNumberGenerator Fd2253135;
    private System.Security.Cryptography.RandomNumberGenerator Fd94be20e;
    private System.Security.Cryptography.RandomNumberGenerator Fdc61d0d9;

    private static System.Numerics.BigInteger M0e49f2ff(System.Numerics.BigInteger P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p68e35a3f.m861a7ab4
        // call: System.Numerics.BigInteger.bitLength
        return default!;
    }

    private static System.Numerics.BigInteger M244f58cf(System.Numerics.BigInteger P0, int P1)
    {
        // call: System.Numerics.BigInteger.shiftLeft
        // call: System.Numerics.BigInteger.mod
        // call: System.Numerics.BigInteger.bitLength
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.fbc21e648
        return default!;
    }

    private static System.Numerics.BigInteger Mc6f6e5b7(System.Numerics.BigInteger P0, p5a196a0a P1)
    {
        // call: System.Numerics.BigInteger.bitLength
        // call: p1dbea5f1.m244f58cf
        // call: p5a196a0a.toBigInteger
        return default!;
    }

    private static p5a196a0a Me97bbc94(pa827ecfa P0, byte[] P1)
    {
        // call: pff43b8de.m4d9c2073
        // call: pa827ecfa.getFieldSize
        // call: p1dbea5f1.m244f58cf
        // call: System.Numerics.BigInteger.<init>
        // call: pa827ecfa.fromBigInteger
        // type: System.Numerics.BigInteger
        return default!;
    }

    private p267d2b96 CreateBasePointMultiplier()
    {
        // call: p90de1a81.<init>
        // type: p90de1a81
        return default!;
    }

    public System.Numerics.BigInteger[] GenerateSignature(byte[] P0)
    {
        // call: System.Numerics.BigInteger.add
        // call: pa827ecfa.fromBigInteger
        // call: p21c2eb74.getCurve
        // call: System.Numerics.BigInteger.multiply
        // call: p21c2eb74.getG
        // call: p53a5793f.getAffineXCoord
        // call: p21c2eb74.getN
        // call: System.Numerics.BigInteger.signum
        // call: p5a196a0a.isZero
        // call: p1dbea5f1.mc6f6e5b7
        // call: p1dbea5f1.createBasePointMultiplier
        // call: System.Numerics.BigInteger.mod
        // call: p06022b5a.getD
        // call: p1dbea5f1.m0e49f2ff
        // call: p53a5793f.normalize
        // call: p267d2b96.multiply
        // call: p1dbea5f1.me97bbc94
        // call: p1235ff36.getParameters
        // call: p5a196a0a.multiply
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.f3c6e0b8a
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // call: p21c2eb74.getN
        // call: p1235ff36.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.f3c6e0b8a
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: pa9682fb5.m07091bf1
        // call: p4715f007.getRandom
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.f3c6e0b8a
    }

    public bool VerifySignature(byte[] P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // call: p5a196a0a.multiply
        // call: p21c2eb74.getG
        // call: pa827ecfa.fromBigInteger
        // call: p1dbea5f1.me97bbc94
        // call: p1dbea5f1.mc6f6e5b7
        // call: p53a5793f.isInfinity
        // call: p21c2eb74.getCurve
        // call: p21c2eb74.getN
        // call: pd16c2d8e.getQ
        // call: System.Numerics.BigInteger.compareTo
        // call: p5a196a0a.isZero
        // call: p8ede7675.m226e8dbb
        // call: p53a5793f.normalize
        // call: p53a5793f.getAffineXCoord
        // call: System.Numerics.BigInteger.signum
        // call: p1235ff36.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1.fbc21e648
        return false;
    }

}
