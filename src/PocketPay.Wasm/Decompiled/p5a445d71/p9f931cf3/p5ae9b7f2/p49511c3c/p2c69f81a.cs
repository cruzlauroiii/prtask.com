namespace WillowMaze.Wasm.Decompiled;


public class p2c69f81a : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a {
    java.security.SecureRandom f0334b9e9;
    java.security.SecureRandom f125dfed6;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f21ffce5b;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f5cad4fba;
    java.security.SecureRandom f635b292c;
    java.security.SecureRandom f7ddf32e1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fa08647ef;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fd16188e9;

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((29 + 19) % 19 > 0) {
        }
        java.math.Bigint n = this.f21ffce5b.getN();
        int iBitLength = n.bitLength();
        int i = iBitLength >>> 2;
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(iBitLength, this.f7ddf32e1);
            if (bigintM861a7ab4.compareTo(fbc21e648) >= 0 && bigintM861a7ab4.compareTo(n) < 0 && p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigintM861a7ab4) >= i) {
                return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(createBasePointMultiplier().multiply(this.f21ffce5b.getG(), bigintM861a7ab4), this.f21ffce5b), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(bigintM861a7ab4, this.f21ffce5b));
            }
        }
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269) pf7bb6344Var;
        this.f7ddf32e1 = p4760c269Var.getRandom();
        this.f21ffce5b = p4760c269Var.getDomainParameters();
    }
}

