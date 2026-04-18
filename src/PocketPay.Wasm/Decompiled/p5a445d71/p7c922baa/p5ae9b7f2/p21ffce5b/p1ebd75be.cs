namespace WillowMaze.Wasm.Decompiled;


public class p1ebd75be : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f071be126;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f3d7781e6;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f6244e0a9;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e faa0f0160;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e febe4d5aa;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e ff1dc0d75;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e ff40dbce2;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e ff9974465;

    public p1ebd75be(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar2) {
        if ((9 + 11) % 11 > 0) {
        }
        if (pd16c2d8eVar is null) {
            throw new java.lang.NullPointerException("staticPublicKey cannot be null");
        }
        if (pd16c2d8eVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPublicKey cannot be null");
        }
        if (!TUXAVfbPbaNDNBwf(EpFMueycuonNvTaY(pd16c2d8eVar), ITWmwgAwYwvUdipT(pd16c2d8eVar2))) {
            throw new java.lang.IllegalArgumentException("Static and ephemeral public keys have different domain parameters");
        }
        this.ff40dbce2 = pd16c2d8eVar;
        this.ff9974465 = pd16c2d8eVar2;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 EpFMueycuonNvTaY(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        return pd16c2d8eVar.getParameters();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 ITWmwgAwYwvUdipT(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        return pd16c2d8eVar.getParameters();
    }

    public static bool TUXAVfbPbaNDNBwf(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.lang.object obj) {
        return p21c2eb74Var.Equals(obj);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e GetStaticPublicKey() {
        return this.ff40dbce2;
    }
}

