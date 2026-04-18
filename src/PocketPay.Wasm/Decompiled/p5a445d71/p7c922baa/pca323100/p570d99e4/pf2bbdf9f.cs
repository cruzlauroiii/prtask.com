namespace WillowMaze.Wasm.Decompiled;


public class pf2bbdf9f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f07fd7790;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f13bbce87;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f1ef64c01;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f2aab42cb;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f2feacd43;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f7740dd0c;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f778c8c4c;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f9836b3c0;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 fb871e134;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 fefd717fe;

    public pf2bbdf9f(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        this.f1ef64c01 = p364bf33aVar;
        this.fefd717fe = ped34daf1Var;
    }

    private pf2bbdf9f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f1ef64c01 = (p5a445d71.p7c922baa.pca323100.p364bf33a) yQUpLovZOdckzVLd(p80f8c729Var, 0);
        this.fefd717fe = (p5a445d71.p7c922baa.pca323100.ped34daf1) ajPWWruhGFpaHLSa(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] OuIagQazuYkDgFMw(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.toArray();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 AjPWWruhGFpaHLSa(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void IylXrNFlaarVZCUm(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f(tWWOsqSQIGjyezTe(obj));
    }

    public static void PjtSAAFAbImkkCjY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 TWWOsqSQIGjyezTe(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YQUpLovZOdckzVLd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetAttrType() {
        return this.f1ef64c01;
    }

    public p5a445d71.p7c922baa.pca323100.ped34daf1 GetAttrValues() {
        return this.fefd717fe;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] GetAttributeValues() {
        return OuIagQazuYkDgFMw(this.fefd717fe);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((19 + 10) % 10 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        iylXrNFlaarVZCUm(pd6ccb7fcVar, this.f1ef64c01);
        pjtSAAFAbImkkCjY(pd6ccb7fcVar, this.fefd717fe);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

