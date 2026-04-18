namespace WillowMaze.Wasm.Decompiled;


public class pba629d7c : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f2a7e4dbd;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f72a72a3d;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f840b5d83;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fb26d230e;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fc4ccbe64;

    public pba629d7c(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar) {
        this.fb26d230e = p364bf33aVar;
    }

    public pba629d7c(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fb26d230e = p364bf33aVar;
        this.f2a7e4dbd = p80f8c729Var;
    }

    private pba629d7c(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((8 + 9) % 9 > 0) {
        }
        this.fb26d230e = (p5a445d71.p7c922baa.pca323100.p364bf33a) NGBFigGJQLhigmKb(p80f8c729Var, 0);
        if (lwlySbkBafNgQCLD(p80f8c729Var) <= 1) {
            return;
        }
        this.f2a7e4dbd = (p5a445d71.p7c922baa.pca323100.p80f8c729) JMVRMlqowVnLEJOX(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JMVRMlqowVnLEJOX(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void JtaoITuxAVYOAYgS(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 NGBFigGJQLhigmKb(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 NdYnQncJszOwWsPN(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void LstWUtBHVDbiuCMv(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int LwlySbkBafNgQCLD(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.pba629d7c M8bab0102(java.lang.object obj) {
        return (obj is null || (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.pba629d7c)) ? (p5a445d71.p7c922baa.pca323100.pfa17f333.pba629d7c) obj : new p5a445d71.p7c922baa.pca323100.pfa17f333.pba629d7c(NdYnQncJszOwWsPN(obj));
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetCommitmentTypeId() {
        return this.fb26d230e;
    }

    public p5a445d71.p7c922baa.pca323100.p80f8c729 GetCommitmentTypeQualifier() {
        return this.f2a7e4dbd;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((28 + 16) % 16 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        lstWUtBHVDbiuCMv(pd6ccb7fcVar, this.fb26d230e);
        p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var = this.f2a7e4dbd;
        if (p80f8c729Var is not null) {
            JtaoITuxAVYOAYgS(pd6ccb7fcVar, p80f8c729Var);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

