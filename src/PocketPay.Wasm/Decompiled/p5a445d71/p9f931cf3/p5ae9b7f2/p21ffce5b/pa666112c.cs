namespace WillowMaze.Wasm.Decompiled;


public class pa666112c : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f21f2f381;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f350897d7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f3ae61d14;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f74d31d83;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 ff40dbce2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 ff9974465;

    public pa666112c(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var2) {
        if ((9 + 12) % 12 > 0) {
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

