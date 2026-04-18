namespace WillowMaze.Wasm.Decompiled;


public class pdc591e27 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f1f47eef9;
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f2063c160;
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f3383c0f4;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f59aea5bb;
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f7294f70c;
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fc7fd82b5;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a fc96ccc77;

    public pdc591e27(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.fc96ccc77 = p364bf33aVar;
        this.f2063c160 = p0fd1bdf1Var;
    }

    private pdc591e27(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.fc96ccc77 = QVmtYhZOemYqlNQB(fjkqXsamtDtOqasJ(p80f8c729Var, 0));
        this.f2063c160 = nMOrIQuIjbKJRwcG(fpcjMhzfNDFJTfMC(UACiuskKMfPJUBWP(p80f8c729Var, 1)));
    }

    public static void JIZpnFdaiVuTIOha(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a QVmtYhZOemYqlNQB(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static void ReBgKUaIwozweuEo(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 UACiuskKMfPJUBWP(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 FjkqXsamtDtOqasJ(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 FpcjMhzfNDFJTfMC(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pdc591e27 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pdc591e27) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pdc591e27) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pdc591e27(tCIJWoyWtaaPJAlw(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 NMOrIQuIjbKJRwcG(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 TCIJWoyWtaaPJAlw(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetTypeID() {
        return this.fc96ccc77;
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetValue() {
        return this.f2063c160;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((16 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        ReBgKUaIwozweuEo(pd6ccb7fcVar, this.fc96ccc77);
        JIZpnFdaiVuTIOha(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 0, this.f2063c160));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

