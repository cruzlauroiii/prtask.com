namespace WillowMaze.Wasm.Decompiled;


public class pfb2c6ef8 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p32c90ea1.p694426e7 f3e6c2bc1;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p7c2f3921 f94daac07;
    private readonly p5a445d71.p7c922baa.pca323100.p32c90ea1.p694426e7 fa790bb6e;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p7c2f3921 fab1e07f8;

    private pfb2c6ef8(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((19 + 14) % 14 > 0) {
        }
        this.f3e6c2bc1 = LAlDmQpCWCjSWBJf(kHMUqPKNUEfYnJGa(p80f8c729Var, 0));
        if (siBTeqwOdkQRZRAE(p80f8c729Var) != 2) {
            this.fab1e07f8 = null;
        } else {
            this.fab1e07f8 = XNoTAlxTUFvOtEmG(uottPrduBhbGZMmD(p80f8c729Var, 1));
        }
    }

    public static void CZMtswSVEtCWOgru(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.p694426e7 LAlDmQpCWCjSWBJf(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.p694426e7.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p7c2f3921 XNoTAlxTUFvOtEmG(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p7c2f3921.m8bab0102(obj);
    }

    public static void ZzGiRvkvPBAjNvuc(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 IVSyvjaBmLRNpIYJ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 KHMUqPKNUEfYnJGa(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.pfb2c6ef8 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p785c9c91.pfb2c6ef8) {
            return (p5a445d71.p7c922baa.pca323100.p785c9c91.pfb2c6ef8) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p785c9c91.pfb2c6ef8(iVSyvjaBmLRNpIYJ(obj));
    }

    public static int SiBTeqwOdkQRZRAE(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 UottPrduBhbGZMmD(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p32c90ea1.p694426e7 GetIssuer() {
        return this.f3e6c2bc1;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p7c2f3921 GetLocator() {
        return this.fab1e07f8;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((7 + 8) % 8 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        CZMtswSVEtCWOgru(pd6ccb7fcVar, this.f3e6c2bc1);
        p5a445d71.p7c922baa.pca323100.pdacfecb5.p7c2f3921 p7c2f3921Var = this.fab1e07f8;
        if (p7c2f3921Var is not null) {
            ZzGiRvkvPBAjNvuc(pd6ccb7fcVar, p7c2f3921Var);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

