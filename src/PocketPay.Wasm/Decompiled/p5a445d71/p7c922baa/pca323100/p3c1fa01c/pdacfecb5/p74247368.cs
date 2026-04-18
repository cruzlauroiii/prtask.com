namespace WillowMaze.Wasm.Decompiled;


public class p74247368 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd f2708ac04;
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd fbb3ccd58;
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd fc5f47fae;

    public p74247368(java.lang.string str) {
        this(new p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd(str));
    }

    private p74247368(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar) {
        this.fbb3ccd58 = pa7d0acfdVar;
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd SOVtJdAEjIwjuyIY(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 CSPbRYCfijvKXqHR(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar) {
        return pa7d0acfdVar.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p74247368 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p74247368) {
            return (p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p74247368) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p74247368(SOVtJdAEjIwjuyIY(obj));
    }

    public p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd GetInformation() {
        return this.fbb3ccd58;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return cSPbRYCfijvKXqHR(this.fbb3ccd58);
    }
}

