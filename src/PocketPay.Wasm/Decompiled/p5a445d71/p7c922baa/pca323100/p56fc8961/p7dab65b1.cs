namespace WillowMaze.Wasm.Decompiled;


public class p7dab65b1 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f159e189d;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f239eac37;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f2a104162;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f5bc79f52;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f5d4f0f99;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f5e68b266;

    public p7dab65b1(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f5bc79f52 = p364bf33aVar;
        this.f5e68b266 = p0fd1bdf1Var;
    }

    private p7dab65b1(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f5bc79f52 = (p5a445d71.p7c922baa.pca323100.p364bf33a) YxvtRtBDMPiQanMb(p80f8c729Var, 0);
        this.f5e68b266 = CcPPtPtnrpqryrcA((p5a445d71.p7c922baa.pca323100.p87af127c) JEdBlPvnOGyspSam(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 CcPPtPtnrpqryrcA(p5a445d71.p7c922baa.pca323100.p87af127c p87af127cVar) {
        return p87af127cVar.getobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JEdBlPvnOGyspSam(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void NObSfCyewlJliUmG(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YxvtRtBDMPiQanMb(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void JVXxsEVKAIDMkqQf(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p7dab65b1 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.p7dab65b1) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.p7dab65b1) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.p7dab65b1(qgRtLyrypuoRmiyJ(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 QgRtLyrypuoRmiyJ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetCertId() {
        return this.f5bc79f52;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetCertValue() {
        return this.f5e68b266;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((14 + 11) % 11 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        jVXxsEVKAIDMkqQf(pd6ccb7fcVar, this.f5bc79f52);
        NObSfCyewlJliUmG(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(0, this.f5e68b266));
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

