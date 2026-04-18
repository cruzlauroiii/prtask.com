namespace WillowMaze.Wasm.Decompiled;

public class Pa3c6c283 : P38d4f313
{
    private p06022b5a F36983fef;
    private p06022b5a F3c6e0b8a;
    private p06022b5a Fed1d9844;

    public System.Numerics.BigInteger CalculateAgreement(pc9ef6b45 P0)
    {
        // str: "Infinity is not a valid agreement value for ECDHC"
        // str: "Infinity is not a valid public key for ECDHC"
        // str: "ECDHC public key has wrong domain parameters"
        // call: pd16c2d8e.getQ
        // call: p53a5793f.isInfinity
        // call: p06022b5a.getD
        // call: System.Numerics.BigInteger.multiply
        // call: p21c2eb74.getN
        // call: p53a5793f.normalize
        // call: p21c2eb74.getCurve
        // call: System.Numerics.BigInteger.mod
        // call: p8ede7675.mcff1d00d
        // call: p53a5793f.getAffineXCoord
        // call: IllegalStateException.<init>
        // call: p21c2eb74.equals
        // call: p06022b5a.getParameters
        // call: p53a5793f.multiply
        // call: p5a196a0a.toBigInteger
        // call: pd16c2d8e.getParameters
        // call: p21c2eb74.getH
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pa3c6c283.f3c6e0b8a
        // type: IllegalStateException
        return default!;
    }

    public int GetFieldSize()
    {
        // call: p21c2eb74.getCurve
        // call: pa827ecfa.getFieldSize
        // call: p06022b5a.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pa3c6c283.f3c6e0b8a
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pa3c6c283.f3c6e0b8a
    }

}
