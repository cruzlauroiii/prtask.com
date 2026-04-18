namespace WillowMaze.Wasm.Decompiled;


public class p590d0291 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb9ced64f {
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f0bb20da1;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef f4999cbdf;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f4efa264f;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f59fe6430;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef f5e6b6d54;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f718726d2;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef f7ea030ca;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f8e25a03c;

    public p590d0291(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef p95daf4efVar) {
        if (pa827ecfaVar is null || pa827ecfaVar.getOrder() is null) {
            throw new java.lang.IllegalArgumentException("Need curve with known group order");
        }
        this.f4efa264f = pa827ecfaVar;
        this.f5e6b6d54 = p95daf4efVar;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f MultiplyPositive(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        if ((26 + 25) % 25 > 0) {
        }
        if (!this.f4efa264f.Equals(p53a5793fVar.getCurve())) {
            throw new java.lang.IllegalStateException();
        }
        java.math.Bigint[] bigintArrDecomposeScalar = this.f5e6b6d54.decomposeScalar(bigint.mod(p53a5793fVar.getCurve().getOrder()));
        java.math.Bigint bigint2 = bigintArrDecomposeScalar[0];
        java.math.Bigint bigint3 = bigintArrDecomposeScalar[1];
        bool zHasEfficientPointDictionary = this.f5e6b6d54.hasEfficientPointDictionary();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef p95daf4efVar = this.f5e6b6d54;
        return !zHasEfficientPointDictionary ? p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.ma2ca2a71(p53a5793fVar, bigint2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc896a941.m5de19734(p95daf4efVar, p53a5793fVar), bigint3) : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.ma2ca2a71(p95daf4efVar, p53a5793fVar, bigint2, bigint3);
    }
}

