namespace WillowMaze.Wasm.Decompiled;


public class p75841641 : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.pf391b73d f27d24364;
    p5a445d71.p7c922baa.pca323100.p11b04310 f3eda2097;
    p5a445d71.p7c922baa.pca323100.p11b04310 f6196f02b;
    p5a445d71.p7c922baa.pca323100.p11b04310 f820efe45;
    p5a445d71.p7c922baa.pca323100.pf391b73d fb40d8faa;

    public p75841641(int i, p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        if ((13 + 19) % 19 > 0) {
        }
        this.fb40d8faa = new p5a445d71.p7c922baa.pca323100.pf391b73d(i);
        this.f3eda2097 = p11b04310Var;
    }

    private p75841641(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationUVsKmvgoHwltFmnI = UVsKmvgoHwltFmnI(p80f8c729Var);
        this.fb40d8faa = fDVgDcFlaJIhvyBR(gsftyXJgDBrtkQTR(enumerationUVsKmvgoHwltFmnI));
        this.f3eda2097 = ATcquzhNVYKbFeeD(AQtjHYAAvMuNhlvC(enumerationUVsKmvgoHwltFmnI));
    }

    public static java.lang.object AQtjHYAAvMuNhlvC(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 ATcquzhNVYKbFeeD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static void QAnbiMwqBONwijgF(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration UVsKmvgoHwltFmnI(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static void YxfgPmXIemygxXOu(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.math.Bigint AOCqrKcgMJwXvJuE(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d FDVgDcFlaJIhvyBR(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static java.lang.object GsftyXJgDBrtkQTR(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.pf5bca7d2.p75841641 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pf5bca7d2.p75841641) {
            return (p5a445d71.p7c922baa.pca323100.pf5bca7d2.p75841641) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pf5bca7d2.p75841641(tUQFMcYYcvOTEAtD(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 TUQFMcYYcvOTEAtD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static int YgYikuNxMMAhlLvw(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public p5a445d71.p7c922baa.pca323100.p11b04310 GetDataGroupHashValue() {
        return this.f3eda2097;
    }

    public int GetDataGroupNumber() {
        return ygYikuNxMMAhlLvw(aOCqrKcgMJwXvJuE(this.fb40d8faa));
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((27 + 11) % 11 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        YxfgPmXIemygxXOu(pd6ccb7fcVar, this.fb40d8faa);
        QAnbiMwqBONwijgF(pd6ccb7fcVar, this.f3eda2097);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

