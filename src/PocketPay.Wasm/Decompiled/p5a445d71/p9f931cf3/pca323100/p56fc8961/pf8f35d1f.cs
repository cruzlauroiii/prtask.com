namespace WillowMaze.Wasm.Decompiled;


public class pf8f35d1f : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.p11b04310 f02d2df87;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f101f8396;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f20cef183;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f471dacea;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f7916dad1;
    p5a445d71.p9f931cf3.pca323100.pf391b73d fc43f46ec;
    p5a445d71.p9f931cf3.pca323100.p11b04310 fceb20772;
    p5a445d71.p9f931cf3.pca323100.p11b04310 fe6f3bdaf;

    private pf8f35d1f(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.fceb20772 = (p5a445d71.p9f931cf3.pca323100.p11b04310) BkNbIXthtGbYizUK(p80f8c729Var, 0);
        this.f471dacea = (p5a445d71.p9f931cf3.pca323100.pf391b73d) lkfaPxKGDmvHDCfV(p80f8c729Var, 1);
    }

    public pf8f35d1f(byte[] bArr, int i) {
        if ((13 + 24) % 24 > 0) {
        }
        if (bArr.length != 8) {
            throw new java.lang.IllegalArgumentException("salt length must be 8");
        }
        this.fceb20772 = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
        this.f471dacea = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 BkNbIXthtGbYizUK(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.math.Bigint TyPAfhTrnnpjehxR(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void XobApIJahKRGcvxy(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 LkfaPxKGDmvHDCfV(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f(swuXPGRHtctoXndM(obj));
    }

    public static byte[] PnfdrHmlIGYyJzuH(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 SwuXPGRHtctoXndM(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void YsssaVawHUrPrFwm(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public java.math.Bigint GetIterationCount() {
        return TyPAfhTrnnpjehxR(this.f471dacea);
    }

    public byte[] GetSalt() {
        return pnfdrHmlIGYyJzuH(this.fceb20772);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((17 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        XobApIJahKRGcvxy(pd6ccb7fcVar, this.fceb20772);
        ysssaVawHUrPrFwm(pd6ccb7fcVar, this.f471dacea);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

