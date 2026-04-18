namespace WillowMaze.Wasm.Decompiled;


public class p601fd45b : p5a445d71.p9f931cf3.p5ae9b7f2.p5d34c947 {
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f17f03752;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f3c6e0b8a;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f5f11c245;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fb6fa8005;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fc03b3d87;

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M3989192a(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        if ((14 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
        if (!parameters.Equals(pd16c2d8eVar.getParameters())) {
            throw new java.lang.IllegalStateException("ECDHC public key has wrong domain parameters");
        }
        java.math.Bigint bigintMod = parameters.getH().multiply(this.f3c6e0b8a.getD()).mod(parameters.getN());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd16c2d8eVar.getQ());
        if (p53a5793fVarMcff1d00d.isInfinity()) {
            throw new java.lang.IllegalStateException("Infinity is not a valid public key for ECDHC");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p53a5793fVarMcff1d00d.multiply(bigintMod).normalize();
        if (p53a5793fVarNormalize.isInfinity()) {
            throw new java.lang.IllegalStateException("Infinity is not a valid agreement value for ECDHC");
        }
        return p53a5793fVarNormalize;
    }

    public override java.math.Bigint CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        return m3989192a((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var).getAffineXCoord().toBigint();
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a CalculateStage(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(m3989192a((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var), this.f3c6e0b8a.getParameters());
    }

    public override int GetFieldSize() {
        return (this.f3c6e0b8a.getParameters().getCurve().getFieldSize() + 7) / 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pc9ef6b45Var;
    }
}

