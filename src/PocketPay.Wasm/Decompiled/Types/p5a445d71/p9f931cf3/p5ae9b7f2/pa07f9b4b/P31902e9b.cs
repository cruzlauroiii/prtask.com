namespace WillowMaze.Wasm.Decompiled;

public class P31902e9b
{
    private static System.Numerics.BigInteger F2af87a59;
    private static System.Numerics.BigInteger F40bce837;
    private static System.Numerics.BigInteger Fa2a3a571;
    private static System.Numerics.BigInteger Fb67956ca;
    private static System.Numerics.BigInteger Fbc21e648;
    private bool F0617be93;
    private pa95206b0 F28811255;
    private pa95206b0 F28b17c20;
    private pa95206b0 F3c6e0b8a;
    private pa95206b0 F46eb346f;
    private System.Security.Cryptography.RandomNumberGenerator F5548baa7;
    private byte[] F7bb755d4;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private byte[] F910b81ac;
    private bool F9301aa9b;
    private bool F9e5cd30a;
    private System.Security.Cryptography.RandomNumberGenerator Fae2c10b5;
    private byte[] Fd304ba20;
    private bool Fe52c0d3b;
    private System.Security.Cryptography.RandomNumberGenerator Ff16e1a91;

    private System.Numerics.BigInteger M584e9a98(System.Numerics.BigInteger P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: System.Numerics.BigInteger.subtract
        // call: p68e35a3f.m812c2a1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.fbc21e648
        return default!;
    }

    private bool Mbd50c654(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // call: System.Numerics.BigInteger.compareTo
        return false;
    }

    public System.Numerics.BigInteger ConvertInput(byte[] P0, int P1, int P2)
    {
        // str: "input too large for Cramer Shoup cipher."
        // call: System.Numerics.BigInteger.<init>
        // call: p96068848.<init>
        // call: p31902e9b.getInputBlockSize
        // call: pa95206b0.getParameters
        // call: p6b500a61.getP
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.compareTo
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f9301aa9b
        // type: System.Numerics.BigInteger
        // type: p96068848
        return default!;
    }

    public byte[] ConvertOutput(System.Numerics.BigInteger P0)
    {
        // call: p31902e9b.getOutputBlockSize
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.toByteArray
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f9301aa9b
        return default!;
    }

    public System.Numerics.BigInteger DecryptBlock(p75cb1af5 P0)
    {
        // str: "Sorry, that ciphertext is not correct"
        // call: pe5cfc515.update
        // call: System.Numerics.BigInteger.mod
        // call: p75cb1af5.getE
        // call: pe5cfc515.doFinal
        // call: p582dc031.getParameters
        // call: System.Numerics.BigInteger.multiply
        // call: System.Numerics.BigInteger.toByteArray
        // call: p582dc031.getX2
        // call: p582dc031.getY2
        // call: p6b500a61.getP
        // call: System.Numerics.BigInteger.modPow
        // call: p75cb1af5.getU1
        // call: p6b500a61.getH
        // call: p582dc031.getY1
        // call: pe5cfc515.getDigestSize
        // call: System.Numerics.BigInteger.add
        // call: p75cb1af5.getU2
        // call: p582dc031.getZ
        // call: System.Numerics.BigInteger.equals
        // call: System.Numerics.BigInteger.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75cb1af5.f270c1b08
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75cb1af5.fe4774cdd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75cb1af5.f9e3669d1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.fd304ba20
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75cb1af5.fe1671797
        // type: p31902e9b$pabd2ae71
        // type: System.Numerics.BigInteger
        return default!;
    }

    public p75cb1af5 EncryptBlock(System.Numerics.BigInteger P0)
    {
        // call: pe5cfc515.update
        // call: p3f7da2fc.getH
        // call: p3f7da2fc.getParameters
        // call: p3f7da2fc.getD
        // call: p75cb1af5.<init>
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.<init>
        // call: pa95206b0.isPrivate
        // call: System.Numerics.BigInteger.mod
        // call: p6b500a61.getP
        // call: p31902e9b.m584e9a98
        // call: System.Numerics.BigInteger.toByteArray
        // call: p6b500a61.getG2
        // call: System.Numerics.BigInteger.multiply
        // call: p6b500a61.getG1
        // call: p31902e9b.mbd50c654
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.doFinal
        // call: p3f7da2fc.getC
        // call: p6b500a61.getH
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.fd304ba20
        // type: p75cb1af5
        // type: System.Numerics.BigInteger
        return default!;
    }

    public int GetInputBlockSize()
    {
        // call: p6b500a61.getP
        // call: pa95206b0.getParameters
        // call: System.Numerics.BigInteger.bitLength
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f3c6e0b8a
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: System.Numerics.BigInteger.bitLength
        // call: p6b500a61.getP
        // call: pa95206b0.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f9301aa9b
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getRandom
        // call: p4715f007.getParameters
        // call: p31902e9b.initSecureRandom
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.f7ddf32e1
    }

    public void Init(bool P0, pc9ef6b45 P1, string P2)
    {
        // call: p31902e9b.init
        // call: p89be9433.m48fbf2cf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b.fd304ba20
    }

    private System.Security.Cryptography.RandomNumberGenerator InitSecureRandom(bool P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: pa9682fb5.m07091bf1
        return default!;
    }

}
