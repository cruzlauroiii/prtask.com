namespace WillowMaze.Wasm.Decompiled;


public class pa58780e4 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f108f000e;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f24529b93;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f51149b73;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f94012590;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fa95804d0;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fcebb6233;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fd4a47456;

    public pa58780e4(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.fcebb6233 = p364bf33aVar;
        this.f108f000e = p0fd1bdf1Var;
    }

    public pa58780e4(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fcebb6233 = (p5a445d71.p7c922baa.pca323100.p364bf33a) ItrQopndLOzlBaLJ(p80f8c729Var, 0);
        this.f108f000e = vUjGwZWGpZNBzEgk(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ItrQopndLOzlBaLJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void RvkODDwzBPWHAzhU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void DJspVUAbzKQbdAuQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 FrXUllHPcTwuXpaX(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pa58780e4 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pa58780e4) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pa58780e4) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pa58780e4(frXUllHPcTwuXpaX(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 VUjGwZWGpZNBzEgk(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetKeyAttr() {
        return this.f108f000e;
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetKeyAttrId() {
        return this.fcebb6233;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((9 + 17) % 17 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        dJspVUAbzKQbdAuQ(pd6ccb7fcVar, this.fcebb6233);
        RvkODDwzBPWHAzhU(pd6ccb7fcVar, this.f108f000e);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

