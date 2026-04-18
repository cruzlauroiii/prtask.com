namespace WillowMaze.Wasm.Decompiled;


public class pda25587c : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f178bb786;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f213b26d0;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f386f03d2;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f39e2e9a9;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f4d6d0a98;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fd6fe967d;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fe4bd1235;

    public pda25587c(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f39e2e9a9 = p364bf33aVar;
        this.f386f03d2 = p0fd1bdf1Var;
    }

    private pda25587c(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f39e2e9a9 = (p5a445d71.p7c922baa.pca323100.p364bf33a) pJYikXPbsuqscLaj(p80f8c729Var, 0);
        this.f386f03d2 = iFnxGMrkDeTdhYpR((p5a445d71.p7c922baa.pca323100.p582a4948) dlWTdFGARERrEyjD(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 JKTGxjaUXFrwZWbk(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void NNHmZAtBOsHRTuBK(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void ZSunRNNgDDTRicLL(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DlWTdFGARERrEyjD(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 IFnxGMrkDeTdhYpR(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.pda25587c M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.pda25587c) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.pda25587c) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.pda25587c(JKTGxjaUXFrwZWbk(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 PJYikXPbsuqscLaj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetCrlId() {
        return this.f39e2e9a9;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetCrlValue() {
        return this.f386f03d2;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((16 + 32) % 32 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        NNHmZAtBOsHRTuBK(pd6ccb7fcVar, this.f39e2e9a9);
        ZSunRNNgDDTRicLL(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(0, this.f386f03d2));
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

