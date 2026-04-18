namespace WillowMaze.Wasm.Decompiled;

public class P601fd45b : P5d34c947
{
    private p06022b5a F17f03752;
    private p06022b5a F3c6e0b8a;
    private p06022b5a F5f11c245;
    private p06022b5a Fb6fa8005;
    private p06022b5a Fc03b3d87;

    private p53a5793f M3989192a(pd16c2d8e P0)
    {
        // str: "Infinity is not a valid public key for ECDHC"
        // str: "ECDHC public key has wrong domain parameters"
        // str: "Infinity is not a valid agreement value for ECDHC"
        // call: p21c2eb74.getN
        // call: System.Numerics.BigInteger.mod
        // call: IllegalStateException.<init>
        // call: System.Numerics.BigInteger.multiply
        // call: p21c2eb74.equals
        // call: p06022b5a.getParameters
        // call: pd16c2d8e.getQ
        // call: p53a5793f.multiply
        // call: p21c2eb74.getH
        // call: p53a5793f.isInfinity
        // call: p53a5793f.normalize
        // call: p8ede7675.mcff1d00d
        // call: pd16c2d8e.getParameters
        // call: p21c2eb74.getCurve
        // call: p06022b5a.getD
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p601fd45b.f3c6e0b8a
        // type: IllegalStateException
        return default!;
    }

    public System.Numerics.BigInteger CalculateAgreement(pc9ef6b45 P0)
    {
        // call: p601fd45b.m3989192a
        // call: p53a5793f.getAffineXCoord
        // call: p5a196a0a.toBigInteger
        return default!;
    }

    public pcfffbc4a CalculateStage(pc9ef6b45 P0)
    {
        // call: pd16c2d8e.<init>
        // call: p06022b5a.getParameters
        // call: p601fd45b.m3989192a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p601fd45b.f3c6e0b8a
        // type: pd16c2d8e
        return default!;
    }

    public int GetFieldSize()
    {
        // call: p06022b5a.getParameters
        // call: p21c2eb74.getCurve
        // call: pa827ecfa.getFieldSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p601fd45b.f3c6e0b8a
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p601fd45b.f3c6e0b8a
    }

}
