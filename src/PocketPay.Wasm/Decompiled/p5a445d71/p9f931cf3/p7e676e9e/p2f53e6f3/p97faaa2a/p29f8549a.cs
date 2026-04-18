namespace WillowMaze.Wasm.Decompiled;


public class p29f8549a : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef {
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 f14903f51;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p1e0bd86c f166e64f6;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p1e0bd86c f6f9cd7af;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p1e0bd86c f8b4b0c2c;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 fe1ecd198;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 fe80ceddf;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p1e0bd86c fffdf9c8e;

    public p29f8549a(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p1e0bd86c p1e0bd86cVar) {
        this.f166e64f6 = p1e0bd86cVar;
        this.f14903f51 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p4a3a0c35(pa827ecfaVar.fromBigint(p1e0bd86cVar.getI()));
    }

    public override java.math.Bigint[] DecomposeScalar(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc896a941.mc13976c3(this.f166e64f6.getSplitParams(), bigint);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 GetPointDictionary() {
        return this.f14903f51;
    }

    public override bool HasEfficientPointDictionary() {
        return true;
    }
}

