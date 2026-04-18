namespace WillowMaze.Wasm.Decompiled;

public class Pa50229ae : P28d0f68a, Pae380b4d
{
    private System.Security.Cryptography.RandomNumberGenerator F1afd36ba;
    private readonly pbd7aaca5 F1fe5a9d3;
    private p1235ff36 F3c6e0b8a;
    private p1235ff36 F46561a0c;
    private System.Security.Cryptography.RandomNumberGenerator F58c70ae0;
    private p1235ff36 F7a389923;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private System.Security.Cryptography.RandomNumberGenerator F9d784c64;
    private p1235ff36 Fc8cc52d7;
    private readonly pbd7aaca5 Fe7eafe1c;
    private System.Security.Cryptography.RandomNumberGenerator Ff12de489;
    private p1235ff36 Ff5d549c7;

    private System.Numerics.BigInteger CalculateE(System.Numerics.BigInteger P0, byte[] P1)
    {
        // call: System.Numerics.BigInteger.<init>
        // call: System.Numerics.BigInteger.shiftRight
        // call: System.Numerics.BigInteger.bitLength
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
        // call: pa50229ae.createBasePointMultiplier
        // call: p5a196a0a.toBigInteger
        // call: System.Numerics.BigInteger.mod
        // call: pa50229ae.calculateE
        // call: pbd7aaca5.init
        // call: System.Numerics.BigInteger.equals
        // call: p21c2eb74.getN
        // call: p06022b5a.getD
        // call: System.Numerics.BigInteger.add
        // call: pbd7aaca5.nextK
        // call: p1235ff36.getParameters
        // call: p267d2b96.multiply
        // call: p21c2eb74.getG
        // call: pbd7aaca5.isDeterministic
        // call: System.Numerics.BigInteger.multiply
        // call: p53a5793f.normalize
        // call: p68e35a3f.m635f3861
        // call: p53a5793f.getAffineXCoord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.fe7eafe1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f7ddf32e1
        return default!;
    }

    private p5a196a0a GetDenominator(int P0, p53a5793f P1)
    {
        // call: p53a5793f.getZCoord
        // call: p5a196a0a.square
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // call: p1235ff36.getParameters
        // call: p21c2eb74.getN
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f3c6e0b8a
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: pbd7aaca5.isDeterministic
        // call: p4715f007.getParameters
        // call: pa50229ae.initSecureRandom
        // call: p4715f007.getRandom
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.fe7eafe1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f7ddf32e1
    }

    private System.Security.Cryptography.RandomNumberGenerator InitSecureRandom(bool P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: pa9682fb5.m07091bf1
        return default!;
    }

    public bool VerifySignature(byte[] P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // call: p1235ff36.getParameters
        // call: p8ede7675.m226e8dbb
        // call: System.Numerics.BigInteger.multiply
        // call: pa827ecfa.fromBigInteger
        // call: p5a196a0a.isZero
        // call: p68e35a3f.me90945d8
        // call: System.Numerics.BigInteger.compareTo
        // call: p53a5793f.isInfinity
        // call: System.Numerics.BigInteger.add
        // call: pd16c2d8e.getQ
        // call: System.Numerics.BigInteger.equals
        // call: p5a196a0a.toBigInteger
        // call: object.equals
        // call: p53a5793f.getCurve
        // call: pa827ecfa.isValidFieldElement
        // call: p53a5793f.normalize
        // call: pa827ecfa.getCofactor
        // call: pa50229ae.calculateE
        // call: p21c2eb74.getN
        // call: pa827ecfa.getCoordinateSystem
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa50229ae.f960df6d7
        return false;
    }

}
