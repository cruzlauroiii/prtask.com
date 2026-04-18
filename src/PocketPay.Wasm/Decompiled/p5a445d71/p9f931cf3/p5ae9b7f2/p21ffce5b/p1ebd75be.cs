namespace WillowMaze.Wasm.Decompiled;


public class p1ebd75be : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f4ccc1cf8;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff2cc69a9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff40dbce2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff6b6fa50;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff9974465;

    public p1ebd75be(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar2) {
        if ((25 + 10) % 10 > 0) {
        }
        if (pd16c2d8eVar is null) {
            throw new java.lang.NullPointerException("staticPublicKey cannot be null");
        }
        if (pd16c2d8eVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPublicKey cannot be null");
        }
        if (!pd16c2d8eVar.getParameters().Equals(pd16c2d8eVar2.getParameters())) {
            throw new java.lang.IllegalArgumentException("Static and ephemeral public keys have different domain parameters");
        }
        this.ff40dbce2 = pd16c2d8eVar;
        this.ff9974465 = pd16c2d8eVar2;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e GetStaticPublicKey() {
        return this.ff40dbce2;
    }
}

