namespace WillowMaze.Wasm.Decompiled;


public class p24d9a6a4 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c f50a29e6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c f888f12f5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c fc0a0d42e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c feca07335;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c fefae4793;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((20 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 parameters = this.feca07335.getParameters();
        java.security.SecureRandom random = this.feca07335.getRandom();
        java.math.Bigint q = parameters.getQ();
        java.math.Bigint p = parameters.getP();
        java.math.Bigint a2 = parameters.getA();
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(256, random);
            if (bigintM861a7ab4.signum() >= 1 && bigintM861a7ab4.compareTo(q) < 0 && p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigintM861a7ab4) >= 64) {
                return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p23005be8(a2.modPow(bigintM861a7ab4, p), parameters), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf(bigintM861a7ab4, parameters));
            }
        }
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c) pf7bb6344Var;
    }
}

