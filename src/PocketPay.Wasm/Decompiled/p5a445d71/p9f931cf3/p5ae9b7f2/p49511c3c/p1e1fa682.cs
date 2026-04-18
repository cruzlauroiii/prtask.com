namespace WillowMaze.Wasm.Decompiled;


public class p1e1fa682 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private static readonly java.math.Bigint f0ecf9b93 = null;
    private static readonly java.math.Bigint f75f5e177 = null;
    private static readonly java.math.Bigint f7cd5abad = null;
    private static readonly java.math.Bigint fbc21e648;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 f329b4d28;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 f693b9eae;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 fa1d824b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 fe9d8779d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 feca07335;

    static {
        if ((16 + 18) % 18 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private static java.math.Bigint M5a76c5a5(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintM812c2a1c;
        if ((19 + 15) % 15 > 0) {
        }
        int iBitLength = bigint.bitLength() >>> 2;
        do {
            java.math.Bigint bigint2 = fbc21e648;
            bigintM812c2a1c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(bigint2, bigint.subtract(bigint2), secureRandom);
        } while (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigintM812c2a1c) < iBitLength);
        return bigintM812c2a1c;
    }

    private static java.math.Bigint Mbed62f6f(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint2.modPow(bigint3, bigint);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((20 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd parameters = this.feca07335.getParameters();
        java.math.Bigint bigintM5a76c5a5 = m5a76c5a5(parameters.getQ(), this.feca07335.getRandom());
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(mbed62f6f(parameters.getP(), parameters.getG(), bigintM5a76c5a5), parameters), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170(bigintM5a76c5a5, parameters));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309) pf7bb6344Var;
    }
}

