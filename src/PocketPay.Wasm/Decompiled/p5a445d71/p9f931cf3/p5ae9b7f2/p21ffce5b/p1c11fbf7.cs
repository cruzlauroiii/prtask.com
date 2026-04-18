namespace WillowMaze.Wasm.Decompiled;


public class p1c11fbf7 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f2e6ee0d7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f47705112;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f5e88b58f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f8828a5f0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f912db07d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 ff40dbce2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 ff9974465;

    public p1c11fbf7(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var2) {
        if ((3 + 14) % 14 > 0) {
        }
        if (p1bfd3a52Var is null) {
            throw new java.lang.NullPointerException("staticPublicKey cannot be null");
        }
        if (p1bfd3a52Var2 is null) {
            throw new java.lang.NullPointerException("ephemeralPublicKey cannot be null");
        }
        if (!p1bfd3a52Var.getParameters().Equals(p1bfd3a52Var2.getParameters())) {
            throw new java.lang.IllegalArgumentException("Static and ephemeral public keys have different domain parameters");
        }
        this.ff40dbce2 = p1bfd3a52Var;
        this.ff9974465 = p1bfd3a52Var2;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 GetStaticPublicKey() {
        return this.ff40dbce2;
    }
}

