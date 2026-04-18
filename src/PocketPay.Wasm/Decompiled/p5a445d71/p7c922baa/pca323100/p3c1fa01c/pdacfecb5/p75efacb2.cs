namespace WillowMaze.Wasm.Decompiled;


public class p75efacb2 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd f077dd2e3;
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd f3dadfaeb;

    public p75efacb2(java.lang.string str) {
        this.f3dadfaeb = new p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd(str);
    }

    private p75efacb2(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar) {
        this.f3dadfaeb = pa7d0acfdVar;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 FuMLNKbciYcqGRhy(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar) {
        return pa7d0acfdVar.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd KzPKXcupChqXDVEo(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p75efacb2 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p75efacb2) {
            return (p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p75efacb2) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p3c1fa01c.pdacfecb5.p75efacb2(kzPKXcupChqXDVEo(obj));
    }

    public p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd GetRestriction() {
        return this.f3dadfaeb;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return FuMLNKbciYcqGRhy(this.f3dadfaeb);
    }
}

