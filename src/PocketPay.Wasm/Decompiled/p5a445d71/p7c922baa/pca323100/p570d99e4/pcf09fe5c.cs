namespace WillowMaze.Wasm.Decompiled;


public class pcf09fe5c : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f37a1ed82;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f44f4da5f;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f45bc08e6;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f9f7b0c36;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fadad79a3;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fc65914d2;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fdd720641;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 ffb959963;

    private pcf09fe5c(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((29 + 1) % 1 > 0) {
        }
        if (rIKcQkbrJHPbpMWN(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("ASN.1 SEQUENCE should be of length 2");
        }
        this.f9f7b0c36 = xSXBpMaCQzRScDYw(bNUTmbnjEjRsvjWq(p80f8c729Var, 0));
        this.f45bc08e6 = vKswWEQdzgTDaaIR(kQbzVZPbYhuAPFCI(p80f8c729Var, 1));
    }

    public pcf09fe5c(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var2) {
        this.f9f7b0c36 = p234a7530Var;
        this.f45bc08e6 = p234a7530Var2;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 CoFXozXMLosTpAay(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void MgSoquDvaDTsybaU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BNUTmbnjEjRsvjWq(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 KQbzVZPbYhuAPFCI(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pcf09fe5c M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pcf09fe5c) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pcf09fe5c) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pcf09fe5c(CoFXozXMLosTpAay(obj));
    }

    public static int RIKcQkbrJHPbpMWN(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void UcyHtrzRaIOwdIng(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 VKswWEQdzgTDaaIR(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 XSXBpMaCQzRScDYw(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetDem() {
        return this.f45bc08e6;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetKem() {
        return this.f9f7b0c36;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((11 + 7) % 7 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        MgSoquDvaDTsybaU(pd6ccb7fcVar, this.f9f7b0c36);
        ucyHtrzRaIOwdIng(pd6ccb7fcVar, this.f45bc08e6);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

