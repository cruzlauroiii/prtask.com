namespace WillowMaze.Wasm.Decompiled;


public class pd78f1fb7 : p5a445d71.p7c922baa.pca323100.p54252eff {
    protected static readonly int f0e63cad4 = 999;
    protected static readonly int f174dd16d = 1;
    protected static readonly int f1fad9406 = 1;
    protected static readonly int f2a10e05f = 999;
    protected static readonly int f347758ea = 1;
    protected static readonly int f55ca28be = 999;
    protected static readonly int f8b3858e9 = 999;
    protected static readonly int fb74c1345 = 999;
    protected static readonly int fd58e9522 = 999;
    protected static readonly int fd6d089fc = 1;
    protected static readonly int fdf57e1b2 = 999;
    protected static readonly int fe2f62ecb = 1;
    protected static readonly int fe5555dbb = 1;
    protected static readonly int fe87ca6f2 = 999;
    protected static readonly int ff8a8ff5d = 1;
    p5a445d71.p7c922baa.pca323100.pf391b73d f0cefde05;
    p5a445d71.p7c922baa.pca323100.pf391b73d f18ae342d;
    p5a445d71.p7c922baa.pca323100.pf391b73d f259a879e;
    p5a445d71.p7c922baa.pca323100.pf391b73d f4237abb1;
    p5a445d71.p7c922baa.pca323100.pf391b73d f783e8e29;
    p5a445d71.p7c922baa.pca323100.pf391b73d f7ac75ecb;
    p5a445d71.p7c922baa.pca323100.pf391b73d fba3192b1;
    p5a445d71.p7c922baa.pca323100.pf391b73d fd83710ec;
    p5a445d71.p7c922baa.pca323100.pf391b73d fe95b849b;

    protected pd78f1fb7() {
    }

    private pd78f1fb7(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((23 + 19) % 19 > 0) {
        }
        this.f783e8e29 = null;
        this.f259a879e = null;
        this.f18ae342d = null;
        for (int i = 0; i < zrLoHbsWIlMJtham(p80f8c729Var); i++) {
            if (ubeqvovvNzCeyOkz(p80f8c729Var, i) instanceof p5a445d71.p7c922baa.pca323100.pf391b73d) {
                this.f783e8e29 = (p5a445d71.p7c922baa.pca323100.pf391b73d) fqMbBINPWOuRcLxz(p80f8c729Var, i);
            } else if (BwajsCdbCXiZHnvY(p80f8c729Var, i) instanceof p5a445d71.p7c922baa.pca323100.p582a4948) {
                p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var = (p5a445d71.p7c922baa.pca323100.p582a4948) TjMFhmROGWpeYQVm(p80f8c729Var, i);
                int iSRAEEbrbbiwFMsrZ = SRAEEbrbbiwFMsrZ(p582a4948Var);
                if (iSRAEEbrbbiwFMsrZ == 0) {
                    p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVarSEQmackEtTddlJnV = SEQmackEtTddlJnV(p582a4948Var, false);
                    this.f259a879e = pf391b73dVarSEQmackEtTddlJnV;
                    if (uKuetkJytRLbbnxI(SCpazfFcLzrPXYSv(pf391b73dVarSEQmackEtTddlJnV)) < 1 || KipBEwCUNInrehFh(JZvBnlDQCwnJTVWy(this.f259a879e)) > 999) {
                        throw new java.lang.IllegalArgumentException("Invalid millis field : not in (1..999).");
                    }
                } else {
                    if (iSRAEEbrbbiwFMsrZ != 1) {
                        throw new java.lang.IllegalArgumentException("Invalig tag number");
                    }
                    p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVarSVclGrsAswNmFbNZ = sVclGrsAswNmFbNZ(p582a4948Var, false);
                    this.f18ae342d = pf391b73dVarSVclGrsAswNmFbNZ;
                    if (opXPnNFrjoQaYxuT(HpWhGFvEYGfkDFid(pf391b73dVarSVclGrsAswNmFbNZ)) < 1 || VFnjubAUrujiabnF(YLtXckibdnNuhdtU(this.f18ae342d)) > 999) {
                        throw new java.lang.IllegalArgumentException("Invalid micros field : not in (1..999).");
                    }
                }
            } else {
                continue;
            }
        }
    }

    public pd78f1fb7(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar2, p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar3) {
        if ((12 + 1) % 1 > 0) {
        }
        this.f783e8e29 = pf391b73dVar;
        if (pf391b73dVar2 is not null && (OalzOBFdGYxvRCDA(zTSWdioUODPzmNvM(pf391b73dVar2)) < 1 || YRYFVCcopvUSHkjm(kOkkkqmhwFSCwLql(pf391b73dVar2)) > 999)) {
            throw new java.lang.IllegalArgumentException("Invalid millis field : not in (1..999)");
        }
        this.f259a879e = pf391b73dVar2;
        if (pf391b73dVar3 is not null && (cRbZBIWpJMDlChoK(ocvdsTOrbTmalJZq(pf391b73dVar3)) < 1 || fMjupXbApHcxIrCq(tXefCWfXPrnGhqNe(pf391b73dVar3)) > 999)) {
            throw new java.lang.IllegalArgumentException("Invalid micros field : not in (1..999)");
        }
        this.f18ae342d = pf391b73dVar3;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BwajsCdbCXiZHnvY(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void BwajsCdbCXiZHnvY(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BwajsCdbCXiZHnvY(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BwajsCdbCXiZHnvY(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint HpWhGFvEYGfkDFid(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void HpWhGFvEYGfkDFid(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpWhGFvEYGfkDFid(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HpWhGFvEYGfkDFid(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint JZvBnlDQCwnJTVWy(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void JZvBnlDQCwnJTVWy(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JZvBnlDQCwnJTVWy(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JZvBnlDQCwnJTVWy(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JvoZNjhdDMGksQoN(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void JvoZNjhdDMGksQoN(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JvoZNjhdDMGksQoN(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JvoZNjhdDMGksQoN(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KipBEwCUNInrehFh(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void KipBEwCUNInrehFh(java.math.Bigint bigint, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KipBEwCUNInrehFh(java.math.Bigint bigint, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KipBEwCUNInrehFh(java.math.Bigint bigint, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OalzOBFdGYxvRCDA(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void OalzOBFdGYxvRCDA(java.math.Bigint bigint, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OalzOBFdGYxvRCDA(java.math.Bigint bigint, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OalzOBFdGYxvRCDA(java.math.Bigint bigint, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint SCpazfFcLzrPXYSv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void SCpazfFcLzrPXYSv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCpazfFcLzrPXYSv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SCpazfFcLzrPXYSv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d SEQmackEtTddlJnV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static void SEQmackEtTddlJnV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, float f, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SEQmackEtTddlJnV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SEQmackEtTddlJnV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SRAEEbrbbiwFMsrZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static void SRAEEbrbbiwFMsrZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SRAEEbrbbiwFMsrZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SRAEEbrbbiwFMsrZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 TjMFhmROGWpeYQVm(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void TjMFhmROGWpeYQVm(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, char c, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TjMFhmROGWpeYQVm(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TjMFhmROGWpeYQVm(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VFnjubAUrujiabnF(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void VFnjubAUrujiabnF(java.math.Bigint bigint, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VFnjubAUrujiabnF(java.math.Bigint bigint, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VFnjubAUrujiabnF(java.math.Bigint bigint, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XrQOmAhTzPeSLLeB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void XrQOmAhTzPeSLLeB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XrQOmAhTzPeSLLeB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XrQOmAhTzPeSLLeB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint YLtXckibdnNuhdtU(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void YLtXckibdnNuhdtU(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YLtXckibdnNuhdtU(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YLtXckibdnNuhdtU(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YRYFVCcopvUSHkjm(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void YRYFVCcopvUSHkjm(java.math.Bigint bigint, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YRYFVCcopvUSHkjm(java.math.Bigint bigint, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRYFVCcopvUSHkjm(java.math.Bigint bigint, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int CRbZBIWpJMDlChoK(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void CRbZBIWpJMDlChoK(java.math.Bigint bigint, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CRbZBIWpJMDlChoK(java.math.Bigint bigint, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CRbZBIWpJMDlChoK(java.math.Bigint bigint, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FMjupXbApHcxIrCq(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void FMjupXbApHcxIrCq(java.math.Bigint bigint, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMjupXbApHcxIrCq(java.math.Bigint bigint, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMjupXbApHcxIrCq(java.math.Bigint bigint, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 FqMbBINPWOuRcLxz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void FqMbBINPWOuRcLxz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FqMbBINPWOuRcLxz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FqMbBINPWOuRcLxz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GbUGvpMpLxWjNxGi(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void GbUGvpMpLxWjNxGi(java.lang.object obj, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbUGvpMpLxWjNxGi(java.lang.object obj, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GbUGvpMpLxWjNxGi(java.lang.object obj, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint KOkkkqmhwFSCwLql(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void KOkkkqmhwFSCwLql(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KOkkkqmhwFSCwLql(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KOkkkqmhwFSCwLql(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p902bcfe5.pd78f1fb7 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p902bcfe5.pd78f1fb7) {
            return (p5a445d71.p7c922baa.pca323100.p902bcfe5.pd78f1fb7) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p902bcfe5.pd78f1fb7(gbUGvpMpLxWjNxGi(obj));
    }

    public static void M8bab0102(java.lang.object obj, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MiBASlCbPYqXbCze(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void MiBASlCbPYqXbCze(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MiBASlCbPYqXbCze(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MiBASlCbPYqXbCze(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint OcvdsTOrbTmalJZq(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void OcvdsTOrbTmalJZq(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcvdsTOrbTmalJZq(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcvdsTOrbTmalJZq(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int OpXPnNFrjoQaYxuT(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void OpXPnNFrjoQaYxuT(java.math.Bigint bigint, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OpXPnNFrjoQaYxuT(java.math.Bigint bigint, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OpXPnNFrjoQaYxuT(java.math.Bigint bigint, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d SVclGrsAswNmFbNZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static void SVclGrsAswNmFbNZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SVclGrsAswNmFbNZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SVclGrsAswNmFbNZ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint TXefCWfXPrnGhqNe(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void TXefCWfXPrnGhqNe(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TXefCWfXPrnGhqNe(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TXefCWfXPrnGhqNe(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UKuetkJytRLbbnxI(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static void UKuetkJytRLbbnxI(java.math.Bigint bigint, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UKuetkJytRLbbnxI(java.math.Bigint bigint, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UKuetkJytRLbbnxI(java.math.Bigint bigint, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 UbeqvovvNzCeyOkz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void UbeqvovvNzCeyOkz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, float f, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UbeqvovvNzCeyOkz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UbeqvovvNzCeyOkz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, java.lang.string str, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint ZTSWdioUODPzmNvM(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void ZTSWdioUODPzmNvM(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTSWdioUODPzmNvM(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTSWdioUODPzmNvM(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZrLoHbsWIlMJtham(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void ZrLoHbsWIlMJtham(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrLoHbsWIlMJtham(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZrLoHbsWIlMJtham(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public p5a445d71.p7c922baa.pca323100.pf391b73d GetMicros() {
        return this.f18ae342d;
    }

    public p5a445d71.p7c922baa.pca323100.pf391b73d GetMillis() {
        return this.f259a879e;
    }

    public p5a445d71.p7c922baa.pca323100.pf391b73d GetSeconds() {
        return this.f783e8e29;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((10 + 24) % 24 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar = this.f783e8e29;
        if (pf391b73dVar is not null) {
            miBASlCbPYqXbCze(pd6ccb7fcVar, pf391b73dVar);
        }
        if (this.f259a879e is not null) {
            JvoZNjhdDMGksQoN(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, this.f259a879e));
        }
        if (this.f18ae342d is not null) {
            XrQOmAhTzPeSLLeB(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 1, this.f18ae342d));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

