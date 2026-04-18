namespace WillowMaze.Wasm.Decompiled;


public class pfb2c6ef8 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 f1598bb5d;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 f21d6f096;
    private readonly p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 f3e6c2bc1;
    private readonly p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 f45a9e13e;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 fab1e07f8;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 fdbec03b3;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 fe1b07cd9;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 ff28167fa;

    private pfb2c6ef8(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((32 + 24) % 24 > 0) {
        }
        this.f3e6c2bc1 = xVMsxvDdtPNhXFpN(mWftgdbjIRUodHJR(p80f8c729Var, 0));
        this.fab1e07f8 = tKyuBkQjVRULpEys(p80f8c729Var) != 2 ? null : UjuDtRtmwATwRGOV(IRMFhQdROTGEgbpk(p80f8c729Var, 1));
    }

    public static void ANtRGZUSpJPELMDl(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 IRMFhQdROTGEgbpk(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void PvrrmsQQeEUfGXNO(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 UjuDtRtmwATwRGOV(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.pfb2c6ef8 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p785c9c91.pfb2c6ef8) {
            return (p5a445d71.p9f931cf3.pca323100.p785c9c91.pfb2c6ef8) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p785c9c91.pfb2c6ef8(uErhuayGQVrkPaZD(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 MWftgdbjIRUodHJR(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int TKyuBkQjVRULpEys(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 UErhuayGQVrkPaZD(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 XVMsxvDdtPNhXFpN(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 GetIssuer() {
        return this.f3e6c2bc1;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 GetLocator() {
        return this.fab1e07f8;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((20 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        PvrrmsQQeEUfGXNO(pd6ccb7fcVar, this.f3e6c2bc1);
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p7c2f3921 p7c2f3921Var = this.fab1e07f8;
        if (p7c2f3921Var is not null) {
            ANtRGZUSpJPELMDl(pd6ccb7fcVar, p7c2f3921Var);
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

