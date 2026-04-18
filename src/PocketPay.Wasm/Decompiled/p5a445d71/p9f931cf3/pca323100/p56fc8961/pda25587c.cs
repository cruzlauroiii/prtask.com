namespace WillowMaze.Wasm.Decompiled;


public class pda25587c : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f04ea320b;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f386f03d2;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f39e2e9a9;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fb0686be8;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fb1362ca8;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fc78d8568;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fd01f4ed2;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ff654ab07;

    public pda25587c(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f39e2e9a9 = p364bf33aVar;
        this.f386f03d2 = p0fd1bdf1Var;
    }

    private pda25587c(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f39e2e9a9 = (p5a445d71.p9f931cf3.pca323100.p364bf33a) zorPMtuikZmgFPni(p80f8c729Var, 0);
        this.f386f03d2 = szhjKKSjQNhiDkcy((p5a445d71.p9f931cf3.pca323100.p582a4948) yAOUegeECYGgPQCG(p80f8c729Var, 1));
    }

    public static void QXHUZjSAuRrfrAOy(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 JhLhKTALUUfYVEkZ(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.pda25587c M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.pda25587c) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.pda25587c) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.pda25587c(jhLhKTALUUfYVEkZ(obj));
    }

    public static void RvtHdokWSWQDUDKa(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 SzhjKKSjQNhiDkcy(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 YAOUegeECYGgPQCG(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ZorPMtuikZmgFPni(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetCrlId() {
        return this.f39e2e9a9;
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetCrlValue() {
        return this.f386f03d2;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((15 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        rvtHdokWSWQDUDKa(pd6ccb7fcVar, this.f39e2e9a9);
        QXHUZjSAuRrfrAOy(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(0, this.f386f03d2));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

