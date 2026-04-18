namespace WillowMaze.Wasm.Decompiled;


public class pc7b2a4d5 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c f0e03c59b;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c f2707da2d;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c f83d1c8d2;

    public pc7b2a4d5(p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c pe1725a0cVar) {
        this.f0e03c59b = pe1725a0cVar;
    }

    private pc7b2a4d5(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if (KjqYlcokdWmjWXRf(p582a4948Var) != 0) {
            return;
        }
        this.f0e03c59b = NXogsIGdNiLFTWls(p582a4948Var, false);
    }

    public static int KjqYlcokdWmjWXRf(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c NXogsIGdNiLFTWls(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 KrUYNehukjJfYrdD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pc7b2a4d5 M8bab0102(java.lang.object obj) {
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pc7b2a4d5)) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pc7b2a4d5) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p582a4948) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.pc7b2a4d5(krUYNehukjJfYrdD(obj));
        }
        throw new java.lang.IllegalArgumentException("unknown object in getInstance");
    }

    public p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c GetTstEvidence() {
        return this.f0e03c59b;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((25 + 3) % 3 > 0) {
        }
        if (this.f0e03c59b is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, this.f0e03c59b);
    }
}

