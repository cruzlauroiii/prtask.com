namespace WillowMaze.Wasm.Decompiled;


public class pfeaff37e : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f2063c160;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f26c24438;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f364c159c;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f467213f2;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f599dcce2;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 feeb61ca9;

    public pfeaff37e(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f599dcce2 = p364bf33aVar;
        this.f2063c160 = p0fd1bdf1Var;
    }

    private pfeaff37e(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f599dcce2 = (p5a445d71.p9f931cf3.pca323100.p364bf33a) sLvXZagCArZtjCUS(p80f8c729Var, 0);
        this.f2063c160 = NpiOjdYCQloBHkKY(p80f8c729Var, 1);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 LkwbamYcuoswdYMb(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void MoRMsVTSqPdiaJJr(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 NpiOjdYCQloBHkKY(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p32c90ea1.pfeaff37e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p32c90ea1.pfeaff37e) {
            return (p5a445d71.p9f931cf3.pca323100.p32c90ea1.pfeaff37e) obj;
        }
        if (obj is null) {
            throw new java.lang.IllegalArgumentException("null value in getInstance()");
        }
        return new p5a445d71.p9f931cf3.pca323100.p32c90ea1.pfeaff37e(LkwbamYcuoswdYMb(obj));
    }

    public static void NYaTwHJqYYPbKCUQ(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 SLvXZagCArZtjCUS(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetType() {
        return this.f599dcce2;
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetValue() {
        return this.f2063c160;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((21 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        MoRMsVTSqPdiaJJr(pd6ccb7fcVar, this.f599dcce2);
        nYaTwHJqYYPbKCUQ(pd6ccb7fcVar, this.f2063c160);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

