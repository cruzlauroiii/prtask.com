namespace WillowMaze.Wasm.Decompiled;

public class P844d4439 : P38d4f313
{
    private p06022b5a F3c6e0b8a;
    private p06022b5a F774183c1;
    private p06022b5a F8dd8c03c;

    public System.Numerics.BigInteger CalculateAgreement(pc9ef6b45 P0)
    {
        // str: "Infinity is not a valid public key for ECDH"
        // str: "Infinity is not a valid agreement value for ECDH"
        // str: "ECDH public key has wrong domain parameters"
        // call: System.Numerics.BigInteger.mod
        // call: pd16c2d8e.getQ
        // call: p21c2eb74.getCurve
        // call: p06022b5a.getD
        // call: pd16c2d8e.getParameters
        // call: p53a5793f.normalize
        // call: p21c2eb74.getH
        // call: p21c2eb74.getHInv
        // call: p53a5793f.isInfinity
        // call: IllegalStateException.<init>
        // call: System.Numerics.BigInteger.equals
        // call: p8ede7675.m00df1f7b
        // call: p8ede7675.mcff1d00d
        // call: p06022b5a.getParameters
        // call: p53a5793f.getAffineXCoord
        // call: p21c2eb74.getN
        // call: p21c2eb74.equals
        // call: System.Numerics.BigInteger.multiply
        // call: p5a196a0a.toBigInteger
        // call: p53a5793f.multiply
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p844d4439.f3c6e0b8a
        // type: IllegalStateException
        return default!;
    }

    public int GetFieldSize()
    {
        // call: p06022b5a.getParameters
        // call: pa827ecfa.getFieldSize
        // call: p21c2eb74.getCurve
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p844d4439.f3c6e0b8a
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p844d4439.f3c6e0b8a
    }

}
