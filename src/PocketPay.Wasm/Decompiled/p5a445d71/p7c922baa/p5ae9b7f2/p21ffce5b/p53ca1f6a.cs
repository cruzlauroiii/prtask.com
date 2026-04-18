namespace WillowMaze.Wasm.Decompiled;


public class p53ca1f6a : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f771af1ff;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f7d30e9a5;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f7e5a4065;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f974d7191;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e fc4922f45;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e ff40dbce2;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e ff9974465;

    public p53ca1f6a(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar2) {
        if ((28 + 6) % 6 > 0) {
        }
        if (pd16c2d8eVar is null) {
            throw new java.lang.NullPointerException("staticPublicKey cannot be null");
        }
        if (pd16c2d8eVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPublicKey cannot be null");
        }
        if (!KWSLBsTubtVOxQLa(HqXYBmbiNAIbEQOf(pd16c2d8eVar), sHWsPOVGDrKUsHCW(pd16c2d8eVar2))) {
            throw new java.lang.IllegalArgumentException("Static and ephemeral public keys have different domain parameters");
        }
        this.ff40dbce2 = pd16c2d8eVar;
        this.ff9974465 = pd16c2d8eVar2;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 HqXYBmbiNAIbEQOf(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        return pd16c2d8eVar.getParameters();
    }

    public static bool KWSLBsTubtVOxQLa(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.lang.object obj) {
        return p21c2eb74Var.Equals(obj);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 SHWsPOVGDrKUsHCW(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        return pd16c2d8eVar.getParameters();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e GetStaticPublicKey() {
        return this.ff40dbce2;
    }
}

