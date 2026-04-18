namespace WillowMaze.Wasm.Decompiled;

public class P52f19097
{
    private p06022b5a F09aeb038;
    private System.Numerics.BigInteger F2e469222;
    private p06022b5a F3c6e0b8a;
    private readonly pe5cfc515 F4d5ebfbe;
    private System.Numerics.BigInteger F5b595ba5;
    private p06022b5a F666a5552;
    private readonly pe5cfc515 F8edaa94d;
    private System.Numerics.BigInteger Faf47e31e;
    private p06022b5a Fbc5dbbd8;
    private readonly pe5cfc515 Fc10f7796;
    private p06022b5a Fd86a5f59;
    private System.Numerics.BigInteger Fe530f0bd;
    private System.Numerics.BigInteger Ff1bbb1b6;

    private static System.Numerics.BigInteger M1389ace5(byte[] P0)
    {
        // call: System.Numerics.BigInteger.<init>
        // type: System.Numerics.BigInteger
        return default!;
    }

    private byte[] Mcda6f6a8(p53a5793f P0)
    {
        // call: pe5cfc515.doFinal
        // call: p68e35a3f.mec6269b9
        // call: p5a196a0a.toBigInteger
        // call: p53a5793f.getAffineXCoord
        // call: pe5cfc515.update
        // call: pe5cfc515.getDigestSize
        // call: p53a5793f.getAffineYCoord
        // call: System.Numerics.BigInteger.toByteArray
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097.fc10f7796
        return default!;
    }

    public byte[] CalculateAgreement(pc9ef6b45 P0)
    {
        // str: "Infinity is not a valid agreement value for ECVKO"
        // str: "Infinity is not a valid public key for ECDHC"
        // str: "ECVKO public key has wrong domain parameters"
        // call: IllegalStateException.<init>
        // call: System.Numerics.BigInteger.multiply
        // call: p21c2eb74.getCurve
        // call: pd16c2d8e.getQ
        // call: p53a5793f.isInfinity
        // call: p53a5793f.multiply
        // call: p06022b5a.getParameters
        // call: pd16c2d8e.getParameters
        // call: System.Numerics.BigInteger.mod
        // call: p06022b5a.getD
        // call: p21c2eb74.equals
        // call: p21c2eb74.getH
        // call: p8ede7675.mcff1d00d
        // call: p53a5793f.normalize
        // call: p21c2eb74.getN
        // call: p52f19097.mcda6f6a8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097.fe530f0bd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097.f3c6e0b8a
        // type: IllegalStateException
        return default!;
    }

    public int GetFieldSize()
    {
        // call: pa827ecfa.getFieldSize
        // call: p06022b5a.getParameters
        // call: p21c2eb74.getCurve
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097.f3c6e0b8a
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: p52f19097.m1389ace5
        // call: p473e31bf.getParameters
        // call: p473e31bf.getUKM
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097.fe530f0bd
    }

}
