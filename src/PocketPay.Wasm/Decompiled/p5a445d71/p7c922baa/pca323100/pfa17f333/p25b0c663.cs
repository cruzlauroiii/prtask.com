namespace WillowMaze.Wasm.Decompiled;


public class p25b0c663 : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.p80f8c729 f07aa3dd0;
    p5a445d71.p7c922baa.pca323100.p80f8c729 f66dbe924;
    p5a445d71.p7c922baa.pca323100.p80f8c729 fd130b2d6;
    p5a445d71.p7c922baa.pca323100.p80f8c729 fd91fb58b;
    p5a445d71.p7c922baa.pca323100.p80f8c729 fdeb189c7;

    private p25b0c663(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f07aa3dd0 = p80f8c729Var;
    }

    public p25b0c663(p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c[] p6eecfb0cVarArr) {
        if ((7 + 23) % 23 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        for (p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c p6eecfb0cVar : p6eecfb0cVarArr) {
            pcPGsFrssUqLLoBC(pd6ccb7fcVar, p6eecfb0cVar);
        }
        this.f07aa3dd0 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c DfLuCxjGXCRamwYS(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 DltCCbyecsWXfkmA(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 TAeYidSbqSnIcGQY(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p25b0c663 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.p25b0c663) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.p25b0c663) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p80f8c729) {
            return new p5a445d71.p7c922baa.pca323100.pfa17f333.p25b0c663(DltCCbyecsWXfkmA(obj));
        }
        return null;
    }

    public static void PcPGsFrssUqLLoBC(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int QWgNEgNcWhtAVtrx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c GetInfoAt(int i) {
        return DfLuCxjGXCRamwYS(TAeYidSbqSnIcGQY(this.f07aa3dd0, i));
    }

    public int Size() {
        return qWgNEgNcWhtAVtrx(this.f07aa3dd0);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f07aa3dd0;
    }
}

