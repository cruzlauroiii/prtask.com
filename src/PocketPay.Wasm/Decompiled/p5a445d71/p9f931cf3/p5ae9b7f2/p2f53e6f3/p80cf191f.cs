namespace WillowMaze.Wasm.Decompiled;


public class p80cf191f : p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p8da4b697 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f4e1cfb3e;
    private java.math.Bigint f5630502b;
    private java.math.Bigint f72b5b8c9;
    private java.math.Bigint f8ce4b16b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fd1178160;

    public p80cf191f(java.math.Bigint bigint) {
        this.f8ce4b16b = bigint;
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override java.math.Bigint GetTransformValue() {
        return this.f8ce4b16b;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
            throw new java.lang.IllegalArgumentException("ECPublicKeyParameters are required for fixed transform.");
        }
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 Transform(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 pd38c8b22Var) {
        if ((2 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = this.f3c6e0b8a;
        if (pd16c2d8eVar is null) {
            throw new java.lang.IllegalStateException("ECFixedTransform not initialised");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        java.math.Bigint n = parameters.getN();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        java.math.Bigint bigintMod = this.f8ce4b16b.mod(n);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[2];
        p53a5793fVarArr[0] = p267d2b96VarCreateBasePointMultiplier.multiply(parameters.getG(), bigintMod).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd38c8b22Var.getX()));
        p53a5793fVarArr[1] = this.f3c6e0b8a.getQ().multiply(bigintMod).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd38c8b22Var.getY()));
        parameters.getCurve().normalizeAll(p53a5793fVarArr);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22(p53a5793fVarArr[0], p53a5793fVarArr[1]);
    }
}

