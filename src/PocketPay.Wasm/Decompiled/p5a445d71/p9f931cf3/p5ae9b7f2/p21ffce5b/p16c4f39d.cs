namespace WillowMaze.Wasm.Decompiled;


public class p16c4f39d : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f22961b2f;
    private java.math.Bigint f2ed6a976;
    private java.math.Bigint fc2182758;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fc36853ea;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fec45ef09;

    public p16c4f39d(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var, java.math.Bigint bigint) {
        if (p753eae39Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9) {
            throw new java.lang.IllegalArgumentException("RSA parameters should be for a public key");
        }
        this.fc36853ea = p753eae39Var;
        this.f2ed6a976 = bigint;
    }

    public java.math.Bigint GetBlindingFactor() {
        return this.f2ed6a976;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 GetPublicKey() {
        return this.fc36853ea;
    }
}

