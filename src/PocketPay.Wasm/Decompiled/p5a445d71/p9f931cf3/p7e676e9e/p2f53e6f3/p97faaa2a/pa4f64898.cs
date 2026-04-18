namespace WillowMaze.Wasm.Decompiled;


public class pa4f64898 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef {
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 f14903f51;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p180fc2af f166e64f6;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p180fc2af f30d21d6c;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 f3806b70f;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 f6497bde9;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 fa13c3d0b;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p180fc2af fadfaa5ed;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 fc3675d20;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p180fc2af fe46a0951;

    public pa4f64898(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p180fc2af p180fc2afVar) {
        this.f166e64f6 = p180fc2afVar;
        this.f14903f51 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p7b4709bf(pa827ecfaVar.fromBigint(p180fc2afVar.getBeta()));
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

