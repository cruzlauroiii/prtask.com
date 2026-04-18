namespace WillowMaze.Wasm.Decompiled;


public class pa0e89898 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private static readonly java.math.Bigint f68b4d774 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint ffb3cf360 = null;
    private static readonly java.math.Bigint ffd594839 = null;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa6fcd55f f2cdb6f6a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa6fcd55f f55e4204d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa6fcd55f f58ae7cd7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa6fcd55f fb9e5fdc1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa6fcd55f feca07335;

    static {
        if ((32 + 23) % 23 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private java.math.Bigint M584e9a98(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigint2 = fbc21e648;
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(bigint2, bigint.subtract(bigint2), secureRandom);
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031 M5a76c5a5(java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        if ((32 + 11) % 11 > 0) {
        }
        java.math.Bigint p = p6b500a61Var.getP();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031(p6b500a61Var, m584e9a98(p, secureRandom), m584e9a98(p, secureRandom), m584e9a98(p, secureRandom), m584e9a98(p, secureRandom), m584e9a98(p, secureRandom));
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc Mbed62f6f(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031 p582dc031Var) {
        if ((30 + 32) % 32 > 0) {
        }
        java.math.Bigint g1 = p6b500a61Var.getG1();
        java.math.Bigint g2 = p6b500a61Var.getG2();
        java.math.Bigint p = p6b500a61Var.getP();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc(p6b500a61Var, g1.modPow(p582dc031Var.getX1(), p).multiply(g2.modPow(p582dc031Var.getX2(), p)), g1.modPow(p582dc031Var.getY1(), p).multiply(g2.modPow(p582dc031Var.getY2(), p)), g1.modPow(p582dc031Var.getZ(), p));
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((28 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 parameters = this.feca07335.getParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031 p582dc031VarM5a76c5a5 = m5a76c5a5(this.feca07335.getRandom(), parameters);
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc p3f7da2fcVarMbed62f6f = mbed62f6f(parameters, p582dc031VarM5a76c5a5);
        p582dc031VarM5a76c5a5.setPk(p3f7da2fcVarMbed62f6f);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p3f7da2fcVarMbed62f6f, (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p582dc031VarM5a76c5a5);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa6fcd55f) pf7bb6344Var;
    }
}

