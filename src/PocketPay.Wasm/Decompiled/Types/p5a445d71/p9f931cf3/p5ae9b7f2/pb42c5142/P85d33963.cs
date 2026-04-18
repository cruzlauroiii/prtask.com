namespace WillowMaze.Wasm.Decompiled;

public class P85d33963 : Pae380b4d
{
    private readonly pbd7aaca5 F15a174cb;
    private readonly pbd7aaca5 F36f12594;
    private p5a6b556f F3c6e0b8a;
    private p5a6b556f F4db67f2e;
    private System.Security.Cryptography.RandomNumberGenerator F6a2fceb4;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private System.Security.Cryptography.RandomNumberGenerator Fabeef833;
    private System.Security.Cryptography.RandomNumberGenerator Fbfa58257;
    private p5a6b556f Fdfbfec68;
    private readonly pbd7aaca5 Fe7eafe1c;

    private System.Numerics.BigInteger M3fc46678(System.Numerics.BigInteger P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p68e35a3f.m861a7ab4
        // call: pa9682fb5.m07091bf1
        // call: System.Numerics.BigInteger.valueOf
        // call: System.Numerics.BigInteger.multiply
        // call: System.Numerics.BigInteger.add
        return default!;
    }

    private System.Numerics.BigInteger Mdf265527(System.Numerics.BigInteger P0, byte[] P1)
    {
        // call: System.Numerics.BigInteger.bitLength
        // call: System.Numerics.BigInteger.<init>
        // call: System.arraycopy
        // type: System.Numerics.BigInteger
        return default!;
    }

    public System.Numerics.BigInteger[] GenerateSignature(byte[] P0)
    {
        // call: System.Numerics.BigInteger.modPow
        // call: pacb8a170.getX
        // call: System.Numerics.BigInteger.multiply
        // call: p85d33963.mdf265527
        // call: p5a6b556f.getParameters
        // call: pbd7aaca5.init
        // call: System.Numerics.BigInteger.add
        // call: p85d33963.m3fc46678
        // call: System.Numerics.BigInteger.mod
        // call: pe0946edd.getP
        // call: pbd7aaca5.isDeterministic
        // call: pe0946edd.getG
        // call: pe0946edd.getQ
        // call: p68e35a3f.m635f3861
        // call: pbd7aaca5.nextK
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.fe7eafe1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.f3c6e0b8a
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // call: pe0946edd.getQ
        // call: p5a6b556f.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.f3c6e0b8a
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getRandom
        // call: pbd7aaca5.isDeterministic
        // call: p85d33963.initSecureRandom
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.fe7eafe1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.f7ddf32e1
    }

    private System.Security.Cryptography.RandomNumberGenerator InitSecureRandom(bool P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: pa9682fb5.m07091bf1
        return default!;
    }

    public bool VerifySignature(byte[] P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // call: pe0946edd.getQ
        // call: System.Numerics.BigInteger.multiply
        // call: System.Numerics.BigInteger.modPow
        // call: pf574193a.getY
        // call: System.Numerics.BigInteger.mod
        // call: p85d33963.mdf265527
        // call: System.Numerics.BigInteger.valueOf
        // call: System.Numerics.BigInteger.compareTo
        // call: System.Numerics.BigInteger.equals
        // call: pe0946edd.getG
        // call: p68e35a3f.me90945d8
        // call: p5a6b556f.getParameters
        // call: pe0946edd.getP
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p85d33963.f3c6e0b8a
        return false;
    }

}
