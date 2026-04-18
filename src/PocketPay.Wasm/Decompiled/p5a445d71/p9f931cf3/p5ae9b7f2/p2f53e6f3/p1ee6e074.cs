namespace WillowMaze.Wasm.Decompiled;


public class p1ee6e074 : p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p0033e2d4 {
    private java.security.SecureRandom f04d8a1fd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f3c6e0b8a;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f8031a61f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f8c36a49d;
    private java.security.SecureRandom f8ccbfdc4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f8df1c98f;
    private java.security.SecureRandom fd506eefd;
    private java.security.SecureRandom ff0067981;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff17dedbb;

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 Encrypt(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((24 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = this.f3c6e0b8a;
        if (pd16c2d8eVar is null) {
            throw new java.lang.IllegalStateException("ECElGamalEncryptor not initialised");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        java.math.Bigint bigintM0d4cf95e = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p37c4833e.m0d4cf95e(parameters.getN(), this.f7ddf32e1);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[2];
        p53a5793fVarArr[0] = createBasePointMultiplier().multiply(parameters.getG(), bigintM0d4cf95e);
        p53a5793fVarArr[1] = this.f3c6e0b8a.getQ().multiply(bigintM0d4cf95e).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), p53a5793fVar));
        parameters.getCurve().normalizeAll(p53a5793fVarArr);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22(p53a5793fVarArr[0], p53a5793fVarArr[1]);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        java.security.SecureRandom secureRandomM07091bf1;
        if ((13 + 1) % 1 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            if (!(p4715f007Var.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
                throw new java.lang.IllegalArgumentException("ECPublicKeyParameters are required for encryption.");
            }
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p4715f007Var.getParameters();
            secureRandomM07091bf1 = p4715f007Var.getRandom();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
                throw new java.lang.IllegalArgumentException("ECPublicKeyParameters are required for encryption.");
            }
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
            secureRandomM07091bf1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1 = secureRandomM07091bf1;
    }
}

