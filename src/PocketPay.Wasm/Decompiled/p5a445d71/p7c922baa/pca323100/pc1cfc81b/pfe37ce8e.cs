namespace WillowMaze.Wasm.Decompiled;


public class pfe37ce8e : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pf391b73d f80b3afde;
    private p5a445d71.p7c922baa.pca323100.pf391b73d fa984185b;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd fb190df95;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd fd36bc652;

    private pfe37ce8e(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((32 + 20) % 20 > 0) {
        }
        this.f80b3afde = mPVLHMYUjaoZALpD(xVqeepMuUMptWCNB(p80f8c729Var, 0));
        if (IrxbNDYxSqVQjaOm(p80f8c729Var) != 2) {
            return;
        }
        this.fd36bc652 = CRFBRYOdrXEEfVzN(ebycBTXLPUFcjnDW(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd CRFBRYOdrXEEfVzN(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(obj);
    }

    public static int IrxbNDYxSqVQjaOm(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 TmtLjPhjBBHaZzSp(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 EbycBTXLPUFcjnDW(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void LCiMHsGmToqolklb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfe37ce8e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfe37ce8e) {
            return (p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfe37ce8e) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfe37ce8e(TmtLjPhjBBHaZzSp(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d MPVLHMYUjaoZALpD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 XVqeepMuUMptWCNB(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void ZYwOqMefrWJNNswP(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd GetPubLocation() {
        return this.fd36bc652;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((6 + 1) % 1 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        zYwOqMefrWJNNswP(pd6ccb7fcVar, this.f80b3afde);
        p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar = this.fd36bc652;
        if (pf17d2ecdVar is not null) {
            lCiMHsGmToqolklb(pd6ccb7fcVar, pf17d2ecdVar);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

