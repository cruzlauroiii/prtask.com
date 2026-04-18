namespace WillowMaze.Wasm.Decompiled;


public class p16c4f39d : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private java.math.Bigint f0ad930c2;
    private java.math.Bigint f2ed6a976;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f8439f8bb;
    private java.math.Bigint f8b5f6a6a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f92cae78b;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 fa51bac0e;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 fc36853ea;
    private java.math.Bigint fe8849871;

    public p16c4f39d(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var, java.math.Bigint bigint) {
        if (p753eae39Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p859968b9) {
            throw new java.lang.IllegalArgumentException("RSA parameters should be for a public key");
        }
        this.fc36853ea = p753eae39Var;
        this.f2ed6a976 = bigint;
    }

    public java.math.Bigint GetBlindingFactor() {
        return this.f2ed6a976;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 GetPublicKey() {
        return this.fc36853ea;
    }
}

