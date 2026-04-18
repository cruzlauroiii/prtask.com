namespace WillowMaze.Wasm.Decompiled;


public class p524aa06f : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.pf391b73d f1ae5b38b;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f42eb7c7b;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f83878c91;
    p5a445d71.p9f931cf3.pca323100.pf391b73d fb2f5ff47;
    p5a445d71.p9f931cf3.pca323100.pf391b73d fdc3ebba3;

    public p524aa06f(java.math.Bigint bigint, java.math.Bigint bigint2) {
        this.f83878c91 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint);
        this.fb2f5ff47 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint2);
    }

    private p524aa06f(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationJweQDmYUNdfBdNen = jweQDmYUNdfBdNen(p80f8c729Var);
        this.f83878c91 = (p5a445d71.p9f931cf3.pca323100.pf391b73d) vofdTzBnIGNLqAoU(enumerationJweQDmYUNdfBdNen);
        this.fb2f5ff47 = (p5a445d71.p9f931cf3.pca323100.pf391b73d) fFCLSSvaRfHCVQDd(enumerationJweQDmYUNdfBdNen);
    }

    public static void CVGWvcweCYHVZmoq(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 DLTLfvqYVPAgHCZT(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.math.Bigint IclIWTwmHotOzbcb(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static java.math.Bigint RxdJVyhqPdvOppRr(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static java.lang.object FFCLSSvaRfHCVQDd(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.util.Enumeration JweQDmYUNdfBdNen(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f) {
            return (p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f(DLTLfvqYVPAgHCZT(obj));
    }

    public static java.lang.object VofdTzBnIGNLqAoU(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void ZrVGCoqAcbeEewyD(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public java.math.Bigint GetG() {
        return IclIWTwmHotOzbcb(this.fb2f5ff47);
    }

    public java.math.Bigint GetP() {
        return RxdJVyhqPdvOppRr(this.f83878c91);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((19 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        CVGWvcweCYHVZmoq(pd6ccb7fcVar, this.f83878c91);
        zrVGCoqAcbeEewyD(pd6ccb7fcVar, this.fb2f5ff47);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

