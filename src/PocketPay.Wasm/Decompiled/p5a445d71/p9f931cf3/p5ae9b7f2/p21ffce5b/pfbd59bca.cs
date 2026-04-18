namespace WillowMaze.Wasm.Decompiled;


public class pfbd59bca : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f08edd4e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f3ee73731;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f46358758;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f46f3fdf7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f57c1f6e7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f8e6a690c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f91105af7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f9d711355;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec fb05d2a89;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec fe8a3f38d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec ff8bd22b7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec ff8da9f2c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 ff9974465;

    public pfbd59bca(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar2) {
        this(pc9dc4fecVar, pc9dc4fecVar2, null);
    }

    public pfbd59bca(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var) {
        if ((1 + 15) % 15 > 0) {
        }
        if (pc9dc4fecVar is null) {
            throw new java.lang.NullPointerException("staticPrivateKey cannot be null");
        }
        if (pc9dc4fecVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPrivateKey cannot be null");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a parameters = pc9dc4fecVar.getParameters();
        if (!parameters.Equals(pc9dc4fecVar2.getParameters())) {
            throw new java.lang.IllegalArgumentException("static and ephemeral private keys have different domain parameters");
        }
        if (p1bfd3a52Var is null) {
            p1bfd3a52Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(parameters.getG().modPow(pc9dc4fecVar2.getX(), parameters.getP()), parameters);
        } else if (!parameters.Equals(p1bfd3a52Var.getParameters())) {
            throw new java.lang.IllegalArgumentException("ephemeral public key has different domain parameters");
        }
        this.f08edd4e1 = pc9dc4fecVar;
        this.ff8da9f2c = pc9dc4fecVar2;
        this.ff9974465 = p1bfd3a52Var;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec GetEphemeralPrivateKey() {
        return this.ff8da9f2c;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec GetStaticPrivateKey() {
        return this.f08edd4e1;
    }
}

