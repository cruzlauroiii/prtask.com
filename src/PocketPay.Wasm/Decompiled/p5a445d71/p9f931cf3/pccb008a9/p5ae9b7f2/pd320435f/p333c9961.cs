namespace WillowMaze.Wasm.Decompiled;


public readonly class p333c9961 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private int f12526038;
    private java.security.SecureRandom f349eb529;
    private int f45dad585;
    private int f5ad46ced;
    private java.security.SecureRandom f7a369dc1;
    private java.security.SecureRandom f890d43bd;
    private int fc25c15e4;
    private java.security.SecureRandom fca8921a6;
    private java.security.SecureRandom fe68e9829;

    private byte[] M656cbf25(int i) {
        return new byte[p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.m021ac29e(i)];
    }

    private byte[] M7e6f1d4d(int i) {
        return new byte[p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.m58bc3a3e(i)];
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((6 + 8) % 8 > 0) {
        }
        byte[] bArrM7e6f1d4d = m7e6f1d4d(this.f45dad585);
        byte[] bArrM656cbf25 = m656cbf25(this.f45dad585);
        int i = this.f45dad585;
        if (i == 5) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d.m92f3f98f(bArrM656cbf25, bArrM7e6f1d4d, this.f7a369dc1);
        } else {
            if (i != 6) {
                throw new java.lang.IllegalArgumentException("unknown security category: " + this.f45dad585);
            }
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee.m92f3f98f(bArrM656cbf25, bArrM7e6f1d4d, this.f7a369dc1);
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30(this.f45dad585, bArrM656cbf25), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25(this.f45dad585, bArrM7e6f1d4d));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0 pcf3bf7e0Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0) pf7bb6344Var;
        this.f7a369dc1 = pcf3bf7e0Var.getRandom();
        this.f45dad585 = pcf3bf7e0Var.getSecurityCategory();
    }
}

