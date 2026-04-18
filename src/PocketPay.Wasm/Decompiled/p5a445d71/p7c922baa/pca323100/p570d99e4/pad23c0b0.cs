namespace WillowMaze.Wasm.Decompiled;


public class pad23c0b0 : p5a445d71.p7c922baa.pca323100.p54252eff {
    public static readonly int f2e25c285 = 2;
    public static readonly int f4327dfba = 2;
    public static readonly int f544218dc = 1;
    public static readonly int f7123453f = 2;
    public static readonly int fef21bf22 = 1;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f0c3d482a;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f132a968f;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f17addc50;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f2bff77be;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f2d805113;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f3db40de9;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f8399a9ee;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f84c34726;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f85389f6f;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f8bb92c0e;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fb85eb523;

    private pad23c0b0(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((20 + 23) % 23 > 0) {
        }
        if (QzVLEtRiqPMBOSdP(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("Sequence wrong size: One of signatureAlgorithm or macAlgorithm must be present");
        }
        this.f2d805113 = KMfUDxgcfTjgceVK(lxmKtamKOHFsaymy(p80f8c729Var, 0));
        p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948VarQjCzBWGsvNjtKKst = QjCzBWGsvNjtKKst(WQPGubTrHMsNWojf(p80f8c729Var, 1));
        if (cJxlQXdLykEnyqdk(p582a4948VarQjCzBWGsvNjtKKst) == 1) {
            this.f0c3d482a = UhHKGcxOIcfSCVls(p582a4948VarQjCzBWGsvNjtKKst, false);
            this.fb85eb523 = null;
        } else {
            if (SNlmRGQTRMRvMTbt(p582a4948VarQjCzBWGsvNjtKKst) != 2) {
                throw new java.lang.IllegalArgumentException(SzSJQPescsnEuZtF(BHbKFXnFTPzcsUFP(new java.lang.stringBuilder("Unknown tag found: "), IpUbvQXIKlaxeFaN(p582a4948VarQjCzBWGsvNjtKKst))));
            }
            this.f0c3d482a = null;
            this.fb85eb523 = CVwQuoLhEKORyUSI(p582a4948VarQjCzBWGsvNjtKKst, false);
        }
    }

    public pad23c0b0(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, int i, p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var2) {
        if (p234a7530Var is null || p234a7530Var2 is null) {
            throw new java.lang.NullPointerException("AlgorithmIdentifiers cannot be null");
        }
        this.f2d805113 = p234a7530Var;
        if (i == 1) {
            this.f0c3d482a = p234a7530Var2;
            this.fb85eb523 = null;
        } else {
            if (i != 2) {
                throw new java.lang.IllegalArgumentException(zDTmRAgSiDUOQnst(WluwHoigZxuMXoxG(new java.lang.stringBuilder("Unknown type: "), i)));
            }
            this.f0c3d482a = null;
            this.fb85eb523 = p234a7530Var2;
        }
    }

    public static java.lang.stringBuilder BHbKFXnFTPzcsUFP(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 CVwQuoLhEKORyUSI(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(p582a4948Var, z);
    }

    public static int IpUbvQXIKlaxeFaN(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 KMfUDxgcfTjgceVK(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 QjCzBWGsvNjtKKst(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static int QzVLEtRiqPMBOSdP(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static int SNlmRGQTRMRvMTbt(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.lang.string SzSJQPescsnEuZtF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 UhHKGcxOIcfSCVls(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WQPGubTrHMsNWojf(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.stringBuilder WluwHoigZxuMXoxG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int CJxlQXdLykEnyqdk(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static void GlNMFAFRRQxzLZIm(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 LxmKtamKOHFsaymy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pad23c0b0 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pad23c0b0) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pad23c0b0) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pad23c0b0(zzVrzodupFygreMO(obj));
    }

    public static void NKMYcBQQxNDgmDcC(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void VLQJOqpWUDOBYEKu(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.string ZDTmRAgSiDUOQnst(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 ZzVrzodupFygreMO(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetDigestAlgorithm() {
        return this.f2d805113;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetMacAlgorithm() {
        return this.fb85eb523;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetSignatureAlgorithm() {
        return this.f0c3d482a;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((23 + 12) % 12 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        vLQJOqpWUDOBYEKu(pd6ccb7fcVar, this.f2d805113);
        if (this.f0c3d482a is not null) {
            glNMFAFRRQxzLZIm(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 1, this.f0c3d482a));
        }
        if (this.fb85eb523 is not null) {
            nKMYcBQQxNDgmDcC(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 2, this.fb85eb523));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

