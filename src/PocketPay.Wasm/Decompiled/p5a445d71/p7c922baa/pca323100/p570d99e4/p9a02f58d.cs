namespace WillowMaze.Wasm.Decompiled;


public class p9a02f58d : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f3dc1ae7d;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f3dfd07d5;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f5c99e9c5;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f85928359;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f87a229f1;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f8854a74b;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 ffa861882;

    private p9a02f58d(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((2 + 8) % 8 > 0) {
        }
        int iLkDgDHWAZUcSCQzH = lkDgDHWAZUcSCQzH(p80f8c729Var);
        if (iLkDgDHWAZUcSCQzH == 0) {
            return;
        }
        if (iLkDgDHWAZUcSCQzH != 1) {
            if (iLkDgDHWAZUcSCQzH != 2) {
                throw new java.lang.IllegalArgumentException("OriginatorInfo too big");
            }
            this.f5c99e9c5 = vWfKtwvRIyBwAhzj((p5a445d71.p7c922baa.pca323100.p582a4948) MQgvLdQRLFVghSdA(p80f8c729Var, 0), false);
            this.f3dc1ae7d = kdgYTbMLheDbgCKb((p5a445d71.p7c922baa.pca323100.p582a4948) KeBghOqCWWWoNpjz(p80f8c729Var, 1), false);
            return;
        }
        p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var = (p5a445d71.p7c922baa.pca323100.p582a4948) EEVzuAIgmMvYmeIv(p80f8c729Var, 0);
        int iDvPfwOPCcHblAvmh = dvPfwOPCcHblAvmh(p582a4948Var);
        if (iDvPfwOPCcHblAvmh == 0) {
            this.f5c99e9c5 = XGcrKLCGgkwyiNXr(p582a4948Var, false);
        } else {
            if (iDvPfwOPCcHblAvmh != 1) {
                throw new java.lang.IllegalArgumentException(RzSjRSEtNeGNTpxF(mAfkEdSyCooSBWnI(new java.lang.stringBuilder("Bad tag in OriginatorInfo: "), DzqxxzQbQiokdFca(p582a4948Var))));
            }
            this.f3dc1ae7d = AMmluMIujrrSEeOq(p582a4948Var, false);
        }
    }

    public p9a02f58d(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var, p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var2) {
        this.f5c99e9c5 = ped34daf1Var;
        this.f3dc1ae7d = ped34daf1Var2;
    }

    public static p5a445d71.p7c922baa.pca323100.ped34daf1 AMmluMIujrrSEeOq(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.ped34daf1.m8bab0102(p582a4948Var, z);
    }

    public static int DzqxxzQbQiokdFca(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 EEVzuAIgmMvYmeIv(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void GrRBCTlaLusWMlhY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 KeBghOqCWWWoNpjz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void KpHBEruSXgkMgrQA(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MQgvLdQRLFVghSdA(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.string RzSjRSEtNeGNTpxF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.ped34daf1 XGcrKLCGgkwyiNXr(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.ped34daf1.m8bab0102(p582a4948Var, z);
    }

    public static int DvPfwOPCcHblAvmh(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 KHUomWmGTZZlnkII(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.ped34daf1 KdgYTbMLheDbgCKb(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.ped34daf1.m8bab0102(p582a4948Var, z);
    }

    public static int LkDgDHWAZUcSCQzH(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p9a02f58d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p9a02f58d) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p9a02f58d) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p9a02f58d(yJAGvbeEIphapMPO(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p9a02f58d M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return yXsNJaYhJruDyXgl(kHUomWmGTZZlnkII(p582a4948Var, z));
    }

    public static java.lang.stringBuilder MAfkEdSyCooSBWnI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p7c922baa.pca323100.ped34daf1 VWfKtwvRIyBwAhzj(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.ped34daf1.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 YJAGvbeEIphapMPO(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p9a02f58d YXsNJaYhJruDyXgl(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.ped34daf1 GetCRLs() {
        return this.f3dc1ae7d;
    }

    public p5a445d71.p7c922baa.pca323100.ped34daf1 GetCertificates() {
        return this.f5c99e9c5;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((29 + 32) % 32 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        if (this.f5c99e9c5 is not null) {
            GrRBCTlaLusWMlhY(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, this.f5c99e9c5));
        }
        if (this.f3dc1ae7d is not null) {
            KpHBEruSXgkMgrQA(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 1, this.f3dc1ae7d));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

