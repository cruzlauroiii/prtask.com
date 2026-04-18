namespace WillowMaze.Wasm.Decompiled;

public class Pac49128f : Pae380b4d
{
    private p4a6c1060 F2d7f4c93;
    private p4a6c1060 F3c6e0b8a;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private p4a6c1060 F9e3f76d4;
    private p4a6c1060 Fa52ff1cf;
    private System.Security.Cryptography.RandomNumberGenerator Ffbd23c4e;

    public System.Numerics.BigInteger[] GenerateSignature(byte[] P0)
    {
        // call: pff43b8de.m4d9c2073
        // call: p9c4e2d05.getQ
        // call: System.Numerics.BigInteger.mod
        // call: p9c2a10cf.getX
        // call: System.Numerics.BigInteger.multiply
        // call: p4a6c1060.getParameters
        // call: p9c4e2d05.getA
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.<init>
        // call: System.Numerics.BigInteger.add
        // call: System.Numerics.BigInteger.bitLength
        // call: p68e35a3f.m861a7ab4
        // call: p9c4e2d05.getP
        // call: System.Numerics.BigInteger.compareTo
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pac49128f.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pac49128f.f3c6e0b8a
        // type: System.Numerics.BigInteger
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // call: p4a6c1060.getParameters
        // call: p9c4e2d05.getQ
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pac49128f.f3c6e0b8a
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getParameters
        // call: p4715f007.getRandom
        // call: pa9682fb5.m07091bf1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pac49128f.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pac49128f.f7ddf32e1
    }

    public bool VerifySignature(byte[] P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // str: "779dc8fba718ff967d2decd7bfa4bf8bb77737a047c643cc8f98f3a0eb"
        // call: System.Numerics.BigInteger.<init>
        // call: p9c4e2d05.getQ
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.compareTo
        // call: pff43b8de.m4d9c2073
        // call: System.Numerics.BigInteger.mod
        // call: p4a6c1060.getParameters
        // call: p9c4e2d05.getP
        // call: System.Numerics.BigInteger.multiply
        // call: System.Numerics.BigInteger.subtract
        // call: p9c4e2d05.getA
        // call: System.Numerics.BigInteger.equals
        // call: System.Numerics.BigInteger.valueOf
        // call: DecryptString.decryptString
        // call: p23005be8.getY
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pac49128f.f3c6e0b8a
        // type: System.Numerics.BigInteger
        return false;
    }

}
