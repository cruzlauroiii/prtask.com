namespace WillowMaze.Wasm.Decompiled;


public class p42b4b739 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private bool f0a1e0505;
    private p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[] f4ee94594;
    private bool f80925ac2;
    private p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[] fcaf9b6b9;
    private p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[] fd51cd1b7;

    private p42b4b739(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((30 + 12) % 12 > 0) {
        }
        this.f80925ac2 = true;
        this.fcaf9b6b9 = new p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[LRKvhUeBvwzJHgHd(p80f8c729Var)];
        int i = 0;
        while (true) {
            p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[] p32555e78VarArr = this.fcaf9b6b9;
            if (i == p32555e78VarArr.length) {
                this.f80925ac2 = p80f8c729Var is p5a445d71.p7c922baa.pca323100.p6a819fa7;
                return;
            } else {
                p32555e78VarArr[i] = obhURATyLgEpzBDG(uCqqqLhRLTqEDARB(p80f8c729Var, i));
                i++;
            }
        }
    }

    public p42b4b739(p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[] p32555e78VarArr) {
        this.f80925ac2 = true;
        this.fcaf9b6b9 = p32555e78VarArr;
    }

    public static int LRKvhUeBvwzJHgHd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void TtWjCkcQCvhwEZDx(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 WxnSETAdOmpDTxAV(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p42b4b739 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.p42b4b739) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.p42b4b739) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.p42b4b739(WxnSETAdOmpDTxAV(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78 ObhURATyLgEpzBDG(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 UCqqqLhRLTqEDARB(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[] GetContentInfo() {
        return this.fcaf9b6b9;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((20 + 3) % 3 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        int i = 0;
        while (true) {
            p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78[] p32555e78VarArr = this.fcaf9b6b9;
            if (i == p32555e78VarArr.length) {
                break;
            }
            TtWjCkcQCvhwEZDx(pd6ccb7fcVar, p32555e78VarArr[i]);
            i++;
        }
        return !this.f80925ac2 ? new p5a445d71.p7c922baa.pca323100.p85c20c01(pd6ccb7fcVar) : new p5a445d71.p7c922baa.pca323100.p6a819fa7(pd6ccb7fcVar);
    }
}

