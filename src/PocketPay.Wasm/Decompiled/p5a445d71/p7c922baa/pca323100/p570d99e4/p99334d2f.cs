namespace WillowMaze.Wasm.Decompiled;


public class p99334d2f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f37e29369;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f3e419811;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f63991e2f;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f7b93bc3d;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fc00f3f4c;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fc3c0e98e;

    public p99334d2f(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f63991e2f = p364bf33aVar;
        this.f3e419811 = p0fd1bdf1Var;
    }

    public p99334d2f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f63991e2f = YcSyWpTMVfbkwWiV(vIxirIKASyhfJnme(p80f8c729Var, 0));
        this.f3e419811 = ZgaIpmduSsFiCkyu(p80f8c729Var, 1);
    }

    public static void LAYKznAUgLydnraa(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 OdfIRBDSKBFJhqwC(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a YcSyWpTMVfbkwWiV(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ZgaIpmduSsFiCkyu(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GMvXkzfZtuJVpmov(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p99334d2f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p99334d2f) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p99334d2f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p99334d2f(gMvXkzfZtuJVpmov(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p99334d2f M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return ngbCzJYRbtuYEycQ(OdfIRBDSKBFJhqwC(p582a4948Var, z));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p99334d2f NgbCzJYRbtuYEycQ(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static void OQUXSGzxAnxXOZmv(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 VIxirIKASyhfJnme(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetType() {
        return this.f63991e2f;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetValue() {
        return this.f3e419811;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((6 + 20) % 20 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        LAYKznAUgLydnraa(pd6ccb7fcVar, this.f63991e2f);
        oQUXSGzxAnxXOZmv(pd6ccb7fcVar, this.f3e419811);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

