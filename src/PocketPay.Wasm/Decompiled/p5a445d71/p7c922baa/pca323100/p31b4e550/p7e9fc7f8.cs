namespace WillowMaze.Wasm.Decompiled;


public class p7e9fc7f8 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f1157530f;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f39b99b7d;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f3a9f986f;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f5f0502af;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f603574ea;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f863acc43;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fab36c3b2;

    public p7e9fc7f8(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar) {
        this.f863acc43 = p364bf33aVar;
        this.f3a9f986f = null;
    }

    public p7e9fc7f8(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f863acc43 = p364bf33aVar;
        this.f3a9f986f = p0fd1bdf1Var;
    }

    private p7e9fc7f8(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((2 + 17) % 17 > 0) {
        }
        this.f863acc43 = lqYnNxmmplkrYvBg(csjMctMedcIFDDAd(p80f8c729Var, 0));
        if (WapsxNAXPaFyopDn(p80f8c729Var) <= 1) {
            return;
        }
        this.f3a9f986f = caRzHyWOVkIlanHt(p80f8c729Var, 1);
    }

    public static void CUbdRnvKXFVxOaYK(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int WapsxNAXPaFyopDn(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 BgOzJkcQyRIVOHsZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 CaRzHyWOVkIlanHt(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 CsjMctMedcIFDDAd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a LqYnNxmmplkrYvBg(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8(bgOzJkcQyRIVOHsZ(obj));
    }

    public static void OlmCRvUGCsYNoYHl(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetInfoType() {
        return this.f863acc43;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetInfoValue() {
        return this.f3a9f986f;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((29 + 5) % 5 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        olmCRvUGCsYNoYHl(pd6ccb7fcVar, this.f863acc43);
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f3a9f986f;
        if (p0fd1bdf1Var is not null) {
            CUbdRnvKXFVxOaYK(pd6ccb7fcVar, p0fd1bdf1Var);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

