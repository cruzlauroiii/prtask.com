namespace WillowMaze.Wasm.Decompiled;

public class P0a19ac41 : Pae380b4d
{
    private p1235ff36 F22808399;
    private bool F39c7e2db;
    private p1235ff36 F3c6e0b8a;
    private System.Security.Cryptography.RandomNumberGenerator F3f731a45;
    private p1235ff36 F4f1ecd1b;
    private System.Security.Cryptography.RandomNumberGenerator F503fb8d3;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private bool F8feb6c46;
    private p1235ff36 Fb0acc3b6;
    private bool Fb94ef3da;
    private System.Security.Cryptography.RandomNumberGenerator Fbb9ffb35;
    private bool Fcf04871e;
    private bool Fdd182415;

    private System.Numerics.BigInteger M3b221961(pd16c2d8e P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // call: System.Numerics.BigInteger.subtract
        // call: p53a5793f.isInfinity
        // call: System.Numerics.BigInteger.compareTo
        // call: pd16c2d8e.getParameters
        // call: p53a5793f.normalize
        // call: p21c2eb74.getG
        // call: System.Numerics.BigInteger.mod
        // call: p21c2eb74.getN
        // call: p53a5793f.getAffineXCoord
        // call: p5a196a0a.toBigInteger
        // call: p8ede7675.m226e8dbb
        // call: pd16c2d8e.getQ
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648
        return default!;
    }

    public System.Numerics.BigInteger[] GenerateSignature(byte[] P0)
    {
        // str: "not initialised for signing"
        // str: "input too large for ECNR key"
        // call: p96068848.<init>
        // call: System.Numerics.BigInteger.add
        // call: p06022b5a.getD
        // call: System.Numerics.BigInteger.mod
        // call: p2c69f81a.init
        // call: pd16c2d8e.getQ
        // call: System.Numerics.BigInteger.compareTo
        // call: p53a5793f.getAffineXCoord
        // call: System.Numerics.BigInteger.<init>
        // call: pd255ec94.getPrivate
        // call: p06022b5a.getParameters
        // call: p4760c269.<init>
        // call: p5a196a0a.toBigInteger
        // call: p2c69f81a.<init>
        // call: p0a19ac41.getOrder
        // call: p2c69f81a.generateKeyPair
        // call: IllegalStateException.<init>
        // call: System.Numerics.BigInteger.subtract
        // call: pd255ec94.getPublic
        // call: System.Numerics.BigInteger.equals
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f3c6e0b8a
        // type: p96068848
        // type: System.Numerics.BigInteger
        // type: p4760c269
        // type: p2c69f81a
        // type: IllegalStateException
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // call: p21c2eb74.getN
        // call: p1235ff36.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f3c6e0b8a
        return default!;
    }

    public byte[] GetRecoveredMessage(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // str: "not initialised for verifying/recovery"
        // call: p68e35a3f.mec6269b9
        // call: p0a19ac41.m3b221961
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f39c7e2db
        // type: IllegalStateException
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: pa9682fb5.m07091bf1
        // call: p4715f007.getRandom
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f39c7e2db
    }

    public bool VerifySignature(byte[] P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2)
    {
        // str: "input too large for ECNR key."
        // str: "not initialised for verifying"
        // call: System.Numerics.BigInteger.equals
        // call: System.Numerics.BigInteger.<init>
        // call: p96068848.<init>
        // call: p0a19ac41.m3b221961
        // call: System.Numerics.BigInteger.mod
        // call: System.Numerics.BigInteger.bitLength
        // call: IllegalStateException.<init>
        // call: p21c2eb74.getN
        // call: pd16c2d8e.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p0a19ac41.f3c6e0b8a
        // type: p96068848
        // type: System.Numerics.BigInteger
        // type: IllegalStateException
        return false;
    }

}
