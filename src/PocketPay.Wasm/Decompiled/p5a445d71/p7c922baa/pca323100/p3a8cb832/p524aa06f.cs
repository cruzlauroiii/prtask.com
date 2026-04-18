namespace WillowMaze.Wasm.Decompiled;


public class p524aa06f : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.pf391b73d f83878c91;
    p5a445d71.p7c922baa.pca323100.pf391b73d f8d930cda;
    p5a445d71.p7c922baa.pca323100.pf391b73d fb2f5ff47;
    p5a445d71.p7c922baa.pca323100.pf391b73d fb5e65b6e;
    p5a445d71.p7c922baa.pca323100.pf391b73d fd73f67c1;
    p5a445d71.p7c922baa.pca323100.pf391b73d fe5673c3a;

    public p524aa06f(java.math.Bigint bigint, java.math.Bigint bigint2) {
        this.f83878c91 = new p5a445d71.p7c922baa.pca323100.pf391b73d(bigint);
        this.fb2f5ff47 = new p5a445d71.p7c922baa.pca323100.pf391b73d(bigint2);
    }

    private p524aa06f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationTRoIQSLthVBhscRJ = tRoIQSLthVBhscRJ(p80f8c729Var);
        this.f83878c91 = (p5a445d71.p7c922baa.pca323100.pf391b73d) CIURCLtsIPOIRQeD(enumerationTRoIQSLthVBhscRJ);
        this.fb2f5ff47 = (p5a445d71.p7c922baa.pca323100.pf391b73d) fVwEiIlbzmLwsDem(enumerationTRoIQSLthVBhscRJ);
    }

    public static java.lang.object CIURCLtsIPOIRQeD(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void KRhyUiFMPvJFLLbH(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 PhXljdgkkPBDCbBL(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object FVwEiIlbzmLwsDem(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.math.Bigint IJyIcJToFEHohUTW(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static void JrvovNlOAhqlEuxT(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.math.Bigint LypKsEfQTCWiGLgI(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p3a8cb832.p524aa06f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p3a8cb832.p524aa06f) {
            return (p5a445d71.p7c922baa.pca323100.p3a8cb832.p524aa06f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p3a8cb832.p524aa06f(PhXljdgkkPBDCbBL(obj));
    }

    public static java.util.Enumeration TRoIQSLthVBhscRJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public java.math.Bigint GetG() {
        return lypKsEfQTCWiGLgI(this.fb2f5ff47);
    }

    public java.math.Bigint GetP() {
        return iJyIcJToFEHohUTW(this.f83878c91);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((26 + 16) % 16 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        jrvovNlOAhqlEuxT(pd6ccb7fcVar, this.f83878c91);
        KRhyUiFMPvJFLLbH(pd6ccb7fcVar, this.fb2f5ff47);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

