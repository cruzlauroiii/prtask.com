namespace WillowMaze.Wasm.Decompiled;


public class p3dbab193 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f1fa6392e;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f886bb73b;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fbbbea0d9;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fed469618;

    public p3dbab193(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        this.fed469618 = p364bf33aVar;
        this.f886bb73b = p11b04310Var;
    }

    private p3dbab193(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationAqtLWzYrPcZpPzFk = AqtLWzYrPcZpPzFk(p80f8c729Var);
        this.fed469618 = (p5a445d71.p9f931cf3.pca323100.p364bf33a) KcaniCChUkWPUukw(enumerationAqtLWzYrPcZpPzFk);
        this.f886bb73b = (p5a445d71.p9f931cf3.pca323100.p11b04310) hWqiAXrZFKPleCFX(enumerationAqtLWzYrPcZpPzFk);
    }

    public static java.util.Enumeration AqtLWzYrPcZpPzFk(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static java.lang.object KcaniCChUkWPUukw(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void RRGpokAppzIUwHTx(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 SwTmKbRPZqmKLdZc(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void GnZithSHhUNniPRx(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object HWqiAXrZFKPleCFX(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p3dbab193 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pd0c2225b.p3dbab193) {
            return (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p3dbab193) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p3dbab193(SwTmKbRPZqmKLdZc(obj));
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetAlgorithm() {
        return this.fed469618;
    }

    public p5a445d71.p9f931cf3.pca323100.p11b04310 GetCounter() {
        return this.f886bb73b;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((9 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        gnZithSHhUNniPRx(pd6ccb7fcVar, this.fed469618);
        RRGpokAppzIUwHTx(pd6ccb7fcVar, this.f886bb73b);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

