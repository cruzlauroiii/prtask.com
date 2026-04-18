namespace WillowMaze.Wasm.Decompiled;

public class P4942c8b7 : Pd1977c1b, P28d0f68a
{
    private readonly pbd7aaca5 F1717583e;
    private byte[] F20f325f8;
    private p53a5793f F2992c4e9;
    private p21c2eb74 F2bf32144;
    private p53a5793f F3d780b84;
    private byte[] F5ea5be72;
    private p21c2eb74 F6006888e;
    private p1235ff36 F626f130f;
    private readonly pbd7aaca5 F6d9af419;
    private readonly pa8ad1191 F84bea1f0;
    private p21c2eb74 F918b1e00;
    private readonly pe5cfc515 Fa4ed37a0;
    private p21c2eb74 Fab1fc6d5;
    private p53a5793f Fb94c60de;
    private p53a5793f Fbd0374a6;
    private readonly pe5cfc515 Fc10f7796;
    private p1235ff36 Fc2f5bba2;
    private readonly pa8ad1191 Fd4e5014c;
    private p21c2eb74 Fd5cf6538;
    private readonly pbd7aaca5 Fe7eafe1c;
    private p1235ff36 Ff56e9fe8;
    private p53a5793f Ff6ac8b9d;
    private byte[] Ffbade9e3;

    private void M0675eada(pe5cfc515 P0, byte[] P1)
    {
        // call: pe5cfc515.update
    }

    private bool M34a82b06(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // call: System.Numerics.BigInteger.add
        // call: p4942c8b7.calculateE
        // call: p53a5793f.isInfinity
        // call: System.Numerics.BigInteger.compareTo
        // call: pd16c2d8e.getQ
        // call: System.Numerics.BigInteger.mod
        // call: p4942c8b7.me725be6a
        // call: p53a5793f.getAffineXCoord
        // call: p21c2eb74.getN
        // call: System.Numerics.BigInteger.equals
        // call: p8ede7675.m226e8dbb
        // call: p21c2eb74.getG
        // call: p53a5793f.normalize
        // call: p5a196a0a.toBigInteger
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f918b1e00
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f626f130f
        return false;
    }

    private byte[] Mc8c29e33(byte[] P0)
    {
        // call: p4942c8b7.mffce134a
        // call: p21c2eb74.getG
        // call: p21c2eb74.getCurve
        // call: pa827ecfa.getB
        // call: p4942c8b7.m0675eada
        // call: pa827ecfa.getA
        // call: p53a5793f.getAffineXCoord
        // call: pe5cfc515.reset
        // call: p53a5793f.getAffineYCoord
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f918b1e00
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f3d780b84
        return default!;
    }

    private byte[] Me725be6a()
    {
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // call: p4942c8b7.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fc10f7796
        return default!;
    }

    private void Mffce134a(pe5cfc515 P0, p5a196a0a P1)
    {
        // call: p5a196a0a.getEncoded
        // call: pe5cfc515.update
    }

    private System.Numerics.BigInteger CalculateE(System.Numerics.BigInteger P0, byte[] P1)
    {
        // call: System.Numerics.BigInteger.<init>
        // type: System.Numerics.BigInteger
        return default!;
    }

    private p267d2b96 CreateBasePointMultiplier()
    {
        // call: p90de1a81.<init>
        // type: p90de1a81
        return default!;
    }

    public byte[] GenerateSignature()
    {
        // str: "unable to encode signature: "
        // call: System.Numerics.BigInteger.equals
        // call: System.Numerics.BigInteger.mod
        // call: pbd7aaca5.nextK
        // call: System.Numerics.BigInteger.add
        // call: System.Numerics.BigInteger.multiply
        // call: p21c2eb74.getN
        // call: pa8ad1191.encode
        // call: p4942c8b7.calculateE
        // call: p53a5793f.normalize
        // call: StringBuilder.append
        // call: p06022b5a.getD
        // call: StringBuilder.toString
        // call: p4942c8b7.me725be6a
        // call: p267d2b96.multiply
        // call: System.Numerics.BigInteger.subtract
        // call: Exception.getMessage
        // call: p48d8e57f.<init>
        // call: StringBuilder.<init>
        // call: p21c2eb74.getG
        // call: p68e35a3f.m635f3861
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f84bea1f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f918b1e00
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fe7eafe1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f626f130f
        // type: p48d8e57f
        // type: StringBuilder
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "31323334353637383132333435363738"
        // str: "SM2 user ID must be less than 2^16 bits long"
        // call: p1235ff36.getParameters
        // call: p06022b5a.getD
        // call: p4942c8b7.mc8c29e33
        // call: pd16c2d8e.getQ
        // call: IllegalArgumentException.<init>
        // call: p21c2eb74.getN
        // call: p4715f007.getParameters
        // call: p267d2b96.multiply
        // call: pa9682fb5.m07091bf1
        // call: pbd7aaca5.init
        // call: p4942c8b7.createBasePointMultiplier
        // call: pdf34a1dd.getID
        // call: p92640bd7.medb28b6e
        // call: p21c2eb74.getG
        // call: p53a5793f.normalize
        // call: pdf34a1dd.getParameters
        // call: p4715f007.getRandom
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f918b1e00
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fe7eafe1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f626f130f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.ffbade9e3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f3d780b84
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pe5cfc515.update
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.ffbade9e3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fc10f7796
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fc10f7796
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.fc10f7796
    }

    public bool VerifySignature(byte[] P0)
    {
        // call: p21c2eb74.getN
        // call: pa8ad1191.decode
        // call: p4942c8b7.m34a82b06
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f84bea1f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7.f918b1e00
        return false;
    }

}
