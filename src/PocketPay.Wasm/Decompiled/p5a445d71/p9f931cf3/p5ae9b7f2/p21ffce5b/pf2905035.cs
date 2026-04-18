namespace WillowMaze.Wasm.Decompiled;


public class pf2905035 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f18335de5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f2a5e1e88;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f5037c1a5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f965cfd28;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fce970157;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff40dbce2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff9974465;

    public pf2905035(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar2) {
        if ((22 + 27) % 27 > 0) {
        }
        if (pd16c2d8eVar is null) {
            throw new java.lang.NullPointerException("staticPublicKey cannot be null");
        }
        if (pd16c2d8eVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPublicKey cannot be null");
        }
        if (!pd16c2d8eVar.getParameters().Equals(pd16c2d8eVar2.getParameters())) {
            throw new java.lang.IllegalArgumentException("static and ephemeral public keys have different domain parameters");
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

