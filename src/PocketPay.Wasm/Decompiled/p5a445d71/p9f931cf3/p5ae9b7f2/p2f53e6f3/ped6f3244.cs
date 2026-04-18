namespace WillowMaze.Wasm.Decompiled;


public class ped6f3244 : p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pfd5f23f6 {
    private java.security.SecureRandom f225d210f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f3c6e0b8a;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fb0799cfb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fb33fdbcc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fc102812e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fe6da3431;
    private java.security.SecureRandom feb1735b1;

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        java.security.SecureRandom secureRandomM07091bf1;
        if ((22 + 25) % 25 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            if (!(p4715f007Var.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
                throw new java.lang.IllegalArgumentException("ECPublicKeyParameters are required for new public key transform.");
            }
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p4715f007Var.getParameters();
            secureRandomM07091bf1 = p4715f007Var.getRandom();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
                throw new java.lang.IllegalArgumentException("ECPublicKeyParameters are required for new public key transform.");
            }
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
            secureRandomM07091bf1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1 = secureRandomM07091bf1;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 Transform(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 pd38c8b22Var) {
        if ((7 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = this.f3c6e0b8a;
        if (pd16c2d8eVar is null) {
            throw new java.lang.IllegalStateException("ECNewPublicKeyTransform not initialised");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        java.math.Bigint n = parameters.getN();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        java.math.Bigint bigintM0d4cf95e = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p37c4833e.m0d4cf95e(n, this.f7ddf32e1);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[2];
        p53a5793fVarArr[0] = p267d2b96VarCreateBasePointMultiplier.multiply(parameters.getG(), bigintM0d4cf95e);
        p53a5793fVarArr[1] = this.f3c6e0b8a.getQ().multiply(bigintM0d4cf95e).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd38c8b22Var.getY()));
        parameters.getCurve().normalizeAll(p53a5793fVarArr);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22(p53a5793fVarArr[0], p53a5793fVarArr[1]);
    }
}

