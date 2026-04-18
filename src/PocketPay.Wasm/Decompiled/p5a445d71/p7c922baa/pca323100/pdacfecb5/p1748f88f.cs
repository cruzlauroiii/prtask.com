namespace WillowMaze.Wasm.Decompiled;


public class p1748f88f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd f3c8afc3a;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd f7047fef9;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 f86ef13e1;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 faa257936;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 fdcb60bc8;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 ff9f4b096;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 fff3f5911;

    public p1748f88f(java.lang.string str) {
        this(new p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd(6, str is null ? "" : str));
        if ((8 + 23) % 23 > 0) {
        }
    }

    private p1748f88f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((7 + 32) % 32 > 0) {
        }
        if (NtBIFgfQAJfqtRTy(p80f8c729Var) < 1 || gVFyqvjKuOaTVdZJ(p80f8c729Var) > 2) {
            throw new java.lang.IllegalArgumentException(HXjXtxGhyLUSqQJw(oZHEleBhpQSPsjPM(new java.lang.stringBuilder("Bad sequence size: "), DougUvFbvzKoCPZQ(p80f8c729Var))));
        }
        for (int i = 0; i != NubTMbxHhdTwDjCR(p80f8c729Var); i++) {
            p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948VarQTBdtiaMJfoFuqGt = QTBdtiaMJfoFuqGt(BRBXhGWQOwzkwZWa(p80f8c729Var, i));
            int iFxATHUckoHHFjQIP = FxATHUckoHHFjQIP(p582a4948VarQTBdtiaMJfoFuqGt);
            if (iFxATHUckoHHFjQIP == 0) {
                this.f86ef13e1 = lXeenUauNJBqnSqQ(p582a4948VarQTBdtiaMJfoFuqGt, false);
            } else {
                if (iFxATHUckoHHFjQIP != 1) {
                    throw new java.lang.IllegalArgumentException("Unknown tag in RoleSyntax");
                }
                this.f3c8afc3a = ygXZRzKVWbBaXTFa(p582a4948VarQTBdtiaMJfoFuqGt, true);
            }
        }
    }

    public p1748f88f(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        this(null, pf17d2ecdVar);
    }

    public p1748f88f(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        if ((5 + 24) % 24 > 0) {
        }
        if (pf17d2ecdVar is null || BemlmEfoKXAeukjr(pf17d2ecdVar) != 6 || ZDaVmlTXrNgaNeyZ(scutCQOdkRyvRVtq((p5a445d71.p7c922baa.pca323100.p2d24d5da) rlFfEXAPQqJLAefZ(pf17d2ecdVar)), "")) {
            throw new java.lang.IllegalArgumentException("the role name MUST be non empty and MUST use the Uri option of GeneralName");
        }
        this.f86ef13e1 = pfb202cf8Var;
        this.f3c8afc3a = pf17d2ecdVar;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BRBXhGWQOwzkwZWa(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void BRBXhGWQOwzkwZWa(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BRBXhGWQOwzkwZWa(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BRBXhGWQOwzkwZWa(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BemlmEfoKXAeukjr(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getTagNo();
    }

    public static void BemlmEfoKXAeukjr(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BemlmEfoKXAeukjr(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BemlmEfoKXAeukjr(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CfEKzQfgZUOTLhMg(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar) {
        return p1748f88fVar.getRoleNameAsstring();
    }

    public static void CfEKzQfgZUOTLhMg(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CfEKzQfgZUOTLhMg(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CfEKzQfgZUOTLhMg(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DougUvFbvzKoCPZQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void DougUvFbvzKoCPZQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DougUvFbvzKoCPZQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DougUvFbvzKoCPZQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EqjKsVwTGlxQbWqc(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EqjKsVwTGlxQbWqc(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EqjKsVwTGlxQbWqc(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd[] EqjKsVwTGlxQbWqc(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        return pfb202cf8Var.getNames();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 FHhDHBzaUAKWikmZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getName();
    }

    public static void FHhDHBzaUAKWikmZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FHhDHBzaUAKWikmZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FHhDHBzaUAKWikmZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FxATHUckoHHFjQIP(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static void FxATHUckoHHFjQIP(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FxATHUckoHHFjQIP(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxATHUckoHHFjQIP(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuffer HPXqbyWqQNSuYqFK(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static void HPXqbyWqQNSuYqFK(java.lang.stringBuffer stringBuffer, java.lang.string str, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HPXqbyWqQNSuYqFK(java.lang.stringBuffer stringBuffer, java.lang.string str, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HPXqbyWqQNSuYqFK(java.lang.stringBuffer stringBuffer, java.lang.string str, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HXjXtxGhyLUSqQJw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HXjXtxGhyLUSqQJw(java.lang.stringBuilder sb, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HXjXtxGhyLUSqQJw(java.lang.stringBuilder sb, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HXjXtxGhyLUSqQJw(java.lang.stringBuilder sb, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IVrkYMNRpUjSnVAu(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IVrkYMNRpUjSnVAu(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVrkYMNRpUjSnVAu(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string[] IVrkYMNRpUjSnVAu(p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f p1748f88fVar) {
        return p1748f88fVar.getRoleAuthorityAsstring();
    }

    public static int NtBIFgfQAJfqtRTy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void NtBIFgfQAJfqtRTy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NtBIFgfQAJfqtRTy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NtBIFgfQAJfqtRTy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NubTMbxHhdTwDjCR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void NubTMbxHhdTwDjCR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NubTMbxHhdTwDjCR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NubTMbxHhdTwDjCR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PasCiFUpNMucvwaC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PasCiFUpNMucvwaC(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PasCiFUpNMucvwaC(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PasCiFUpNMucvwaC(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 PebBqoODrcWuSbaL(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getName();
    }

    public static void PebBqoODrcWuSbaL(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PebBqoODrcWuSbaL(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PebBqoODrcWuSbaL(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 QTBdtiaMJfoFuqGt(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static void QTBdtiaMJfoFuqGt(java.lang.object obj, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QTBdtiaMJfoFuqGt(java.lang.object obj, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTBdtiaMJfoFuqGt(java.lang.object obj, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuffer UGUUlneTPBXwqiJF(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static void UGUUlneTPBXwqiJF(java.lang.stringBuffer stringBuffer, char c, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UGUUlneTPBXwqiJF(java.lang.stringBuffer stringBuffer, char c, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UGUUlneTPBXwqiJF(java.lang.stringBuffer stringBuffer, char c, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuffer VrXKAJtGTsvlJpaZ(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static void VrXKAJtGTsvlJpaZ(java.lang.stringBuffer stringBuffer, java.lang.string str, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrXKAJtGTsvlJpaZ(java.lang.stringBuffer stringBuffer, java.lang.string str, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VrXKAJtGTsvlJpaZ(java.lang.stringBuffer stringBuffer, java.lang.string str, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XjUWzBvawESEwkgO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XjUWzBvawESEwkgO(java.lang.stringBuilder sb, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjUWzBvawESEwkgO(java.lang.stringBuilder sb, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjUWzBvawESEwkgO(java.lang.stringBuilder sb, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZDaVmlTXrNgaNeyZ(java.lang.string str, java.lang.object obj, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZDaVmlTXrNgaNeyZ(java.lang.string str, java.lang.object obj, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZDaVmlTXrNgaNeyZ(java.lang.string str, java.lang.object obj, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZDaVmlTXrNgaNeyZ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string DBiGUABnhYapGCfB(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static void DBiGUABnhYapGCfB(java.lang.stringBuffer stringBuffer, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DBiGUABnhYapGCfB(java.lang.stringBuffer stringBuffer, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DBiGUABnhYapGCfB(java.lang.stringBuffer stringBuffer, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DttfRZqStOhXBZbH(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar) {
        return p2d24d5daVar.getstring();
    }

    public static void DttfRZqStOhXBZbH(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DttfRZqStOhXBZbH(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DttfRZqStOhXBZbH(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GVFyqvjKuOaTVdZJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void GVFyqvjKuOaTVdZJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GVFyqvjKuOaTVdZJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GVFyqvjKuOaTVdZJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GmBsJRjCsOVJbJHU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void GmBsJRjCsOVJbJHU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmBsJRjCsOVJbJHU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmBsJRjCsOVJbJHU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IDGMzlKDoWcMejRR(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void IDGMzlKDoWcMejRR(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IDGMzlKDoWcMejRR(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IDGMzlKDoWcMejRR(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IcNErvrCuYiZtSaJ(java.lang.object obj) {
        return obj.tostring();
    }

    public static void IcNErvrCuYiZtSaJ(java.lang.object obj, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IcNErvrCuYiZtSaJ(java.lang.object obj, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcNErvrCuYiZtSaJ(java.lang.object obj, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 LXeenUauNJBqnSqQ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8.m8bab0102(p582a4948Var, z);
    }

    public static void LXeenUauNJBqnSqQ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, char c, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXeenUauNJBqnSqQ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, java.lang.string str, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LXeenUauNJBqnSqQ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, bool z2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f) {
            return (p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pdacfecb5.p1748f88f(oixpAhcNvjYBmXUY(obj));
    }

    public static void M8bab0102(java.lang.object obj, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder McxqixPGWSInSiSl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void McxqixPGWSInSiSl(java.lang.stringBuilder sb, java.lang.string str, int i, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void McxqixPGWSInSiSl(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McxqixPGWSInSiSl(java.lang.stringBuilder sb, java.lang.string str, short s, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OZHEleBhpQSPsjPM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void OZHEleBhpQSPsjPM(java.lang.stringBuilder sb, int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZHEleBhpQSPsjPM(java.lang.stringBuilder sb, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZHEleBhpQSPsjPM(java.lang.stringBuilder sb, int i, bool z, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 OixpAhcNvjYBmXUY(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void OixpAhcNvjYBmXUY(java.lang.object obj, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OixpAhcNvjYBmXUY(java.lang.object obj, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OixpAhcNvjYBmXUY(java.lang.object obj, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 RlFfEXAPQqJLAefZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getName();
    }

    public static void RlFfEXAPQqJLAefZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RlFfEXAPQqJLAefZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RlFfEXAPQqJLAefZ(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuffer SFqvedNvrEHZlnYS(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static void SFqvedNvrEHZlnYS(java.lang.stringBuffer stringBuffer, java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SFqvedNvrEHZlnYS(java.lang.stringBuffer stringBuffer, java.lang.string str, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SFqvedNvrEHZlnYS(java.lang.stringBuffer stringBuffer, java.lang.string str, int i, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ScutCQOdkRyvRVtq(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar) {
        return p2d24d5daVar.getstring();
    }

    public static void ScutCQOdkRyvRVtq(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScutCQOdkRyvRVtq(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScutCQOdkRyvRVtq(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WGKfputxFcTENiQL(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar) {
        return p2d24d5daVar.getstring();
    }

    public static void WGKfputxFcTENiQL(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WGKfputxFcTENiQL(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WGKfputxFcTENiQL(p5a445d71.p7c922baa.pca323100.p2d24d5da p2d24d5daVar, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuffer XJDMfuRENsFAJVXj(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static void XJDMfuRENsFAJVXj(java.lang.stringBuffer stringBuffer, char c, char c2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJDMfuRENsFAJVXj(java.lang.stringBuffer stringBuffer, char c, char c2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XJDMfuRENsFAJVXj(java.lang.stringBuffer stringBuffer, char c, short s, bool z, char c2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd YgXZRzKVWbBaXTFa(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(p582a4948Var, z);
    }

    public static void YgXZRzKVWbBaXTFa(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YgXZRzKVWbBaXTFa(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YgXZRzKVWbBaXTFa(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YzBmMXYqtllCbXOp(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YzBmMXYqtllCbXOp(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YzBmMXYqtllCbXOp(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd[] YzBmMXYqtllCbXOp(p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        return pfb202cf8Var.getNames();
    }

    public static java.lang.stringBuffer ZEiXZkaAOCtsJZDU(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static void ZEiXZkaAOCtsJZDU(java.lang.stringBuffer stringBuffer, java.lang.string str, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZEiXZkaAOCtsJZDU(java.lang.stringBuffer stringBuffer, java.lang.string str, short s, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZEiXZkaAOCtsJZDU(java.lang.stringBuffer stringBuffer, java.lang.string str, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 GetRoleAuthority() {
        return this.f86ef13e1;
    }

    public java.lang.string[] GetRoleAuthorityAsstring() {
        if ((1 + 26) % 26 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var = this.f86ef13e1;
        if (pfb202cf8Var is null) {
            return new java.lang.string[0];
        }
        p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd[] pf17d2ecdVarArrEqjKsVwTGlxQbWqc = EqjKsVwTGlxQbWqc(pfb202cf8Var);
        java.lang.string[] strArr = new java.lang.string[pf17d2ecdVarArrEqjKsVwTGlxQbWqc.length];
        for (int i = 0; i < pf17d2ecdVarArrEqjKsVwTGlxQbWqc.length; i++) {
            p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1VarPebBqoODrcWuSbaL = PebBqoODrcWuSbaL(pf17d2ecdVarArrEqjKsVwTGlxQbWqc[i]);
            if (p0fd1bdf1VarPebBqoODrcWuSbaL is p5a445d71.p7c922baa.pca323100.p2d24d5da) {
                strArr[i] = wGKfputxFcTENiQL((p5a445d71.p7c922baa.pca323100.p2d24d5da) p0fd1bdf1VarPebBqoODrcWuSbaL);
            } else {
                strArr[i] = icNErvrCuYiZtSaJ(p0fd1bdf1VarPebBqoODrcWuSbaL);
            }
        }
        return strArr;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd GetRoleName() {
        return this.f3c8afc3a;
    }

    public java.lang.string GetRoleNameAsstring() {
        return dttfRZqStOhXBZbH((p5a445d71.p7c922baa.pca323100.p2d24d5da) FHhDHBzaUAKWikmZ(this.f3c8afc3a));
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((12 + 13) % 13 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        if (this.f86ef13e1 is not null) {
            gmBsJRjCsOVJbJHU(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, this.f86ef13e1));
        }
        iDGMzlKDoWcMejRR(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(true, 1, this.f3c8afc3a));
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public java.lang.string Tostring() {
        if ((25 + 14) % 14 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(XjUWzBvawESEwkgO(mcxqixPGWSInSiSl(PasCiFUpNMucvwaC(new java.lang.stringBuilder("Name: "), CfEKzQfgZUOTLhMg(this)), " - Auth: ")));
        p5a445d71.p7c922baa.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var = this.f86ef13e1;
        if (pfb202cf8Var is null || yzBmMXYqtllCbXOp(pfb202cf8Var).length == 0) {
            VrXKAJtGTsvlJpaZ(stringBuffer, "N/A");
        } else {
            java.lang.string[] strArrIVrkYMNRpUjSnVAu = IVrkYMNRpUjSnVAu(this);
            zEiXZkaAOCtsJZDU(xJDMfuRENsFAJVXj(stringBuffer, '['), strArrIVrkYMNRpUjSnVAu[0]);
            for (int i = 1; i < strArrIVrkYMNRpUjSnVAu.length; i++) {
                HPXqbyWqQNSuYqFK(sFqvedNvrEHZlnYS(stringBuffer, ", "), strArrIVrkYMNRpUjSnVAu[i]);
            }
            UGUUlneTPBXwqiJF(stringBuffer, ']');
        }
        return dBiGUABnhYapGCfB(stringBuffer);
    }
}

