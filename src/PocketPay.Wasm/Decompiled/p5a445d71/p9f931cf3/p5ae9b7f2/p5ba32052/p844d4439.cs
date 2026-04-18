namespace WillowMaze.Wasm.Decompiled;


public class p844d4439 : p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f774183c1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f8dd8c03c;

    public override java.math.Bigint CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((20 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
        if (!parameters.Equals(pd16c2d8eVar.getParameters())) {
            throw new java.lang.IllegalStateException("ECDH public key has wrong domain parameters");
        }
        java.math.Bigint d = this.f3c6e0b8a.getD();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd16c2d8eVar.getQ());
        if (p53a5793fVarMcff1d00d.isInfinity()) {
            throw new java.lang.IllegalStateException("Infinity is not a valid public key for ECDH");
        }
        java.math.Bigint h = parameters.getH();
        if (!h.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
            d = parameters.getHInv().multiply(d).mod(parameters.getN());
            p53a5793fVarMcff1d00d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m00df1f7b(p53a5793fVarMcff1d00d, h);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p53a5793fVarMcff1d00d.multiply(d).normalize();
        if (p53a5793fVarNormalize.isInfinity()) {
            throw new java.lang.IllegalStateException("Infinity is not a valid agreement value for ECDH");
        }
        return p53a5793fVarNormalize.getAffineXCoord().toBigint();
    }

    public override int GetFieldSize() {
        return (this.f3c6e0b8a.getParameters().getCurve().getFieldSize() + 7) / 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pc9ef6b45Var;
    }
}

