namespace WillowMaze.Wasm.Decompiled;

public class Pde24d82c : P5f014d83
{
    private static System.Numerics.BigInteger F66d18e88;
    private static System.Numerics.BigInteger Fb26b438a;
    private static System.Numerics.BigInteger Fbc21e648;
    private static System.Numerics.BigInteger Fbf2f8338;
    private p07d32999 F168e7cba;
    private bool F19b45d9f;
    private bool F3875bff4;
    private p1235ff36 F3c6e0b8a;
    private bool F420a0313;
    private bool F52fc16d0;
    private System.Security.Cryptography.RandomNumberGenerator F577c2406;
    private System.Security.Cryptography.RandomNumberGenerator F5d414653;
    private bool F6c94d2ef;
    private p07d32999 F800a0e2b;
    private p07d32999 F88f68b1b;
    private p1235ff36 F977aefbd;
    private p1235ff36 F9fb44e05;
    private p07d32999 Fb5f9f4ea;
    private bool Fb691217c;
    private System.Security.Cryptography.RandomNumberGenerator Fbc03b76a;
    private bool Fc81555a7;
    private p07d32999 Fcfb8c482;
    private bool Feee17c76;
    private bool Ff3847401;

    private p267d2b96 CreateBasePointMultiplier()
    {
        // call: p90de1a81.<init>
        // type: p90de1a81
        return default!;
    }

    public pc9ef6b45 Decrypt(byte[] P0, int P1)
    {
        // call: pde24d82c.decrypt
        return default!;
    }

    public pc9ef6b45 Decrypt(byte[] P0, int P1, int P2, int P3)
    {
        // str: "Private key required for encryption"
        // call: p21c2eb74.getH
        // call: p06022b5a.getParameters
        // call: p53a5793f.normalize
        // call: p5a196a0a.getEncoded
        // call: p53a5793f.multiply
        // call: System.Numerics.BigInteger.multiply
        // call: p21c2eb74.getN
        // call: p21c2eb74.getHInv
        // call: IllegalArgumentException.<init>
        // call: pde24d82c.deriveKey
        // call: p53a5793f.getAffineXCoord
        // call: pa827ecfa.decodePoint
        // call: System.Numerics.BigInteger.mod
        // call: System.arraycopy
        // call: p21c2eb74.getCurve
        // call: p06022b5a.getD
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f19b45d9f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f420a0313
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f3c6e0b8a
        // type: IllegalArgumentException
        return default!;
    }

    private p94919be6 DeriveKey(int P0, byte[] P1, byte[] P2)
    {
        // call: pc03b0fe3.<init>
        // call: p07d32999.init
        // call: p07d32999.generateBytes
        // call: p94919be6.<init>
        // call: pff43b8de.md844b504
        // call: pff43b8de.ma552c747
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f168e7cba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f52fc16d0
        // type: pc03b0fe3
        // type: p94919be6
        return default!;
    }

    public pc9ef6b45 Encrypt(byte[] P0, int P1)
    {
        // call: pde24d82c.encrypt
        return default!;
    }

    public pc9ef6b45 Encrypt(byte[] P0, int P1, int P2)
    {
        // str: "Public key required for encryption"
        // call: p21c2eb74.getH
        // call: p21c2eb74.getG
        // call: IllegalArgumentException.<init>
        // call: pde24d82c.deriveKey
        // call: p53a5793f.getEncoded
        // call: p53a5793f.getAffineXCoord
        // call: pd16c2d8e.getParameters
        // call: p68e35a3f.m812c2a1c
        // call: System.Numerics.BigInteger.multiply
        // call: pd16c2d8e.getQ
        // call: pa827ecfa.normalizeAll
        // call: p5a196a0a.getEncoded
        // call: p21c2eb74.getCurve
        // call: System.arraycopy
        // call: p267d2b96.multiply
        // call: p53a5793f.multiply
        // call: pde24d82c.createBasePointMultiplier
        // call: System.Numerics.BigInteger.mod
        // call: p21c2eb74.getN
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f577c2406
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f420a0313
        // type: IllegalArgumentException
        return default!;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "EC key required"
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pde24d82c.f3c6e0b8a
        // type: IllegalArgumentException
    }

}
