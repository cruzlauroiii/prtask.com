namespace WillowMaze.Wasm.Decompiled;


public class pd6a0bc72 : p5a445d71.p7c922baa.pca323100.p54252eff {
    public static readonly int f19e88a40 = 0;
    public static readonly int f44d95e74 = 0;
    public static readonly int f4ca6d0e0 = 1;
    public static readonly int f5c16cd5e = 1;
    public static readonly int f5c4a0fc7 = 0;
    public static readonly int fd1f6b728 = 1;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0 f035cd498;
    private int f03c962d4;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 f05cbcd6d;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 f1d0adf87;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0 f1dbbee41;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 f29337bc6;
    private int f2af72f10;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 f3262795c;
    private int f4df8396a;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 f6fa77d0a;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0 f83380ebd;
    private int f8d6d7751;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 f8ff1c90f;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 fc3c2ec65;
    p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0 fe9085754;

    private pd6a0bc72(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if ((25 + 15) % 15 > 0) {
        }
        this.f2af72f10 = 1;
        int iBxhWlgAadLGvPXDJ = bxhWlgAadLGvPXDJ(p582a4948Var);
        if (iBxhWlgAadLGvPXDJ == 0) {
            this.fc3c2ec65 = FYLxcZGMxaWsmSPe(p582a4948Var, true);
        } else {
            if (iBxhWlgAadLGvPXDJ != 1) {
                throw new java.lang.IllegalArgumentException("unknown tag in Holder");
            }
            this.f8ff1c90f = FboSjHccqlSIzXBp(p582a4948Var, true);
        }
        this.f2af72f10 = 0;
    }

    private pd6a0bc72(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((26 + 30) % 30 > 0) {
        }
        this.f2af72f10 = 1;
        if (qFnxbEsEVKnFnXNx(p80f8c729Var) > 3) {
            throw new java.lang.IllegalArgumentException(dVwpfMqJFNsoJZoh(qZwjTnNUiBblkhhV(new java.lang.stringBuilder("Bad sequence size: "), ondiWCGneICzTosJ(p80f8c729Var))));
        }
        for (int i = 0; i != KoSRsVyJTpKAlJdX(p80f8c729Var); i++) {
            p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948VarXoQzZvBSAPwLmAig = xoQzZvBSAPwLmAig(RAwBZghUGkdBgtao(p80f8c729Var, i));
            int iFUayUBgXduDTpPKv = FUayUBgXduDTpPKv(p582a4948VarXoQzZvBSAPwLmAig);
            if (iFUayUBgXduDTpPKv == 0) {
                this.fc3c2ec65 = AbFPZGBJCTQQhlpG(p582a4948VarXoQzZvBSAPwLmAig, false);
            } else if (iFUayUBgXduDTpPKv == 1) {
                this.f8ff1c90f = DssAjXHXKZcmjmnd(p582a4948VarXoQzZvBSAPwLmAig, false);
            } else {
                if (iFUayUBgXduDTpPKv != 2) {
                    throw new java.lang.IllegalArgumentException("unknown tag in Holder");
                }
                this.f035cd498 = IUNpiLrCqCOtLzfw(p582a4948VarXoQzZvBSAPwLmAig, false);
            }
        }
        this.f2af72f10 = 1;
    }

    public pd6a0bc72(p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0 pb8b73df0Var) {
        this.f2af72f10 = 1;
        this.f035cd498 = pb8b73df0Var;
    }

    public pd6a0bc72(p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 pcaf0afb6Var) {
        this(pcaf0afb6Var, 1);
    }

    public pd6a0bc72(p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 pcaf0afb6Var, int i) {
        this.fc3c2ec65 = pcaf0afb6Var;
        this.f2af72f10 = i;
    }

    public pd6a0bc72(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        this(pfb202cf8Var, 1);
    }

    public pd6a0bc72(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, int i) {
        this.f8ff1c90f = pfb202cf8Var;
        this.f2af72f10 = i;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 AbFPZGBJCTQQhlpG(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6.m8bab0102(p582a4948Var, z);
    }

    public static void AbFPZGBJCTQQhlpG(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AbFPZGBJCTQQhlpG(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AbFPZGBJCTQQhlpG(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 DssAjXHXKZcmjmnd(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8.m8bab0102(p582a4948Var, z);
    }

    public static void DssAjXHXKZcmjmnd(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, char c, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DssAjXHXKZcmjmnd(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, char c, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DssAjXHXKZcmjmnd(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, bool z2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FUayUBgXduDTpPKv(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static void FUayUBgXduDTpPKv(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FUayUBgXduDTpPKv(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FUayUBgXduDTpPKv(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 FYLxcZGMxaWsmSPe(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6.m8bab0102(p582a4948Var, z);
    }

    public static void FYLxcZGMxaWsmSPe(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, char c, float f, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FYLxcZGMxaWsmSPe(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FYLxcZGMxaWsmSPe(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 FboSjHccqlSIzXBp(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8.m8bab0102(p582a4948Var, z);
    }

    public static void FboSjHccqlSIzXBp(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, java.lang.string str, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FboSjHccqlSIzXBp(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, short s, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FboSjHccqlSIzXBp(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, bool z2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HwKsxUKHpRKPqHPT(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void HwKsxUKHpRKPqHPT(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HwKsxUKHpRKPqHPT(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HwKsxUKHpRKPqHPT(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0 IUNpiLrCqCOtLzfw(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0.m8bab0102(p582a4948Var, z);
    }

    public static void IUNpiLrCqCOtLzfw(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IUNpiLrCqCOtLzfw(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IUNpiLrCqCOtLzfw(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int KoSRsVyJTpKAlJdX(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void KoSRsVyJTpKAlJdX(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KoSRsVyJTpKAlJdX(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KoSRsVyJTpKAlJdX(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 RAwBZghUGkdBgtao(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void RAwBZghUGkdBgtao(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RAwBZghUGkdBgtao(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RAwBZghUGkdBgtao(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BxhWlgAadLGvPXDJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static void BxhWlgAadLGvPXDJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BxhWlgAadLGvPXDJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BxhWlgAadLGvPXDJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DVwpfMqJFNsoJZoh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DVwpfMqJFNsoJZoh(java.lang.stringBuilder sb, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DVwpfMqJFNsoJZoh(java.lang.stringBuilder sb, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DVwpfMqJFNsoJZoh(java.lang.stringBuilder sb, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GQhDTujrRkEgSLiQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void GQhDTujrRkEgSLiQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GQhDTujrRkEgSLiQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQhDTujrRkEgSLiQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GhBXUTGnreCzqMRb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void GhBXUTGnreCzqMRb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GhBXUTGnreCzqMRb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GhBXUTGnreCzqMRb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pd6a0bc72 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pdacfecb5.pd6a0bc72) {
            return (p5a445d71.p7c922baa.pca323100.pdacfecb5.pd6a0bc72) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p582a4948) {
            return new p5a445d71.p7c922baa.pca323100.pdacfecb5.pd6a0bc72(ydCMrHINFAekaXzE(obj));
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pdacfecb5.pd6a0bc72(xznBYwsQaiXvjoeu(obj));
    }

    public static void M8bab0102(java.lang.object obj, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OndiWCGneICzTosJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void OndiWCGneICzTosJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OndiWCGneICzTosJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OndiWCGneICzTosJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QFnxbEsEVKnFnXNx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void QFnxbEsEVKnFnXNx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QFnxbEsEVKnFnXNx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QFnxbEsEVKnFnXNx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QZwjTnNUiBblkhhV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QZwjTnNUiBblkhhV(java.lang.stringBuilder sb, int i, float f, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QZwjTnNUiBblkhhV(java.lang.stringBuilder sb, int i, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QZwjTnNUiBblkhhV(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 XoQzZvBSAPwLmAig(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static void XoQzZvBSAPwLmAig(java.lang.object obj, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XoQzZvBSAPwLmAig(java.lang.object obj, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XoQzZvBSAPwLmAig(java.lang.object obj, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 XznBYwsQaiXvjoeu(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void XznBYwsQaiXvjoeu(java.lang.object obj, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XznBYwsQaiXvjoeu(java.lang.object obj, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XznBYwsQaiXvjoeu(java.lang.object obj, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 YdCMrHINFAekaXzE(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static void YdCMrHINFAekaXzE(java.lang.object obj, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YdCMrHINFAekaXzE(java.lang.object obj, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YdCMrHINFAekaXzE(java.lang.object obj, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pcaf0afb6 GetBaseCertificateID() {
        return this.fc3c2ec65;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 GetEntityName() {
        return this.f8ff1c90f;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pb8b73df0 GetobjectDigestInfo() {
        return this.f035cd498;
    }

    public int GetVersion() {
        return this.f2af72f10;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((13 + 19) % 19 > 0) {
        }
        if (this.f2af72f10 != 1) {
            return this.f8ff1c90f is null ? new p5a445d71.p7c922baa.pca323100.p87af127c(true, 0, this.fc3c2ec65) : new p5a445d71.p7c922baa.pca323100.p87af127c(true, 1, this.f8ff1c90f);
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        if (this.fc3c2ec65 is not null) {
            HwKsxUKHpRKPqHPT(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, this.fc3c2ec65));
        }
        if (this.f8ff1c90f is not null) {
            gQhDTujrRkEgSLiQ(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 1, this.f8ff1c90f));
        }
        if (this.f035cd498 is not null) {
            ghBXUTGnreCzqMRb(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 2, this.f035cd498));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

