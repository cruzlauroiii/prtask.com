namespace WillowMaze.Wasm.Decompiled;


public class pd2ddd449 : p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p8da4b697 {
    private java.math.Bigint f099860e7;
    private java.math.Bigint f28f16ce0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f3b649629;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f3c6e0b8a;
    private java.math.Bigint f3d38281b;
    private java.security.SecureRandom f69652ba7;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f85cb9865;
    private java.security.SecureRandom fadaa1e82;
    private java.math.Bigint fd993a220;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff3e0fb07;

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override java.math.Bigint GetTransformValue() {
        return this.f28f16ce0;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        java.security.SecureRandom random;
        if ((20 + 13) % 13 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            if (!(p4715f007Var.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
                throw new java.lang.IllegalArgumentException("ECPublicKeyParameters are required for new randomness transform.");
            }
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p4715f007Var.getParameters();
            random = p4715f007Var.getRandom();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
                throw new java.lang.IllegalArgumentException("ECPublicKeyParameters are required for new randomness transform.");
            }
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
            random = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1 = random;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 Transform(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 pd38c8b22Var) {
        if ((7 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = this.f3c6e0b8a;
        if (pd16c2d8eVar is null) {
            throw new java.lang.IllegalStateException("ECNewRandomnessTransform not initialised");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        java.math.Bigint n = parameters.getN();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        java.math.Bigint bigintM0d4cf95e = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p37c4833e.m0d4cf95e(n, this.f7ddf32e1);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[2];
        p53a5793fVarArr[0] = p267d2b96VarCreateBasePointMultiplier.multiply(parameters.getG(), bigintM0d4cf95e).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd38c8b22Var.getX()));
        p53a5793fVarArr[1] = this.f3c6e0b8a.getQ().multiply(bigintM0d4cf95e).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd38c8b22Var.getY()));
        parameters.getCurve().normalizeAll(p53a5793fVarArr);
        this.f28f16ce0 = bigintM0d4cf95e;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22(p53a5793fVarArr[0], p53a5793fVarArr[1]);
    }
}

