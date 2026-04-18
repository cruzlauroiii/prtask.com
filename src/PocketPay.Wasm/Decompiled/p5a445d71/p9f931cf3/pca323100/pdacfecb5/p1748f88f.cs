namespace WillowMaze.Wasm.Decompiled;


public class p1748f88f : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd f3c8afc3a;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 f67c0bf86;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 f68886c77;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 f86ef13e1;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd f958d7de4;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd fc809432f;

    public p1748f88f(java.lang.string str) {
        this(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd(6, str is null ? "" : str));
        if ((18 + 15) % 15 > 0) {
        }
    }

    private p1748f88f(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((7 + 8) % 8 > 0) {
        }
        if (DDrmtsBXOVFEgdIm(p80f8c729Var) < 1 || pwibFNWvyqSbgJlr(p80f8c729Var) > 2) {
            throw new java.lang.IllegalArgumentException(XCAqNrgDWrzWXroc(SCWAJFETiQVXcyjH(new java.lang.stringBuilder("Bad sequence size: "), RcMlsJHEXeMGONnj(p80f8c729Var))));
        }
        for (int i = 0; i != CwwtwDAmBiWhJQgC(p80f8c729Var); i++) {
            p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarNWDaxsneWxfmiBiD = NWDaxsneWxfmiBiD(xDHLFsfABvHqazWM(p80f8c729Var, i));
            int iTjIZPPTMNBGquFzI = TjIZPPTMNBGquFzI(p582a4948VarNWDaxsneWxfmiBiD);
            if (iTjIZPPTMNBGquFzI == 0) {
                this.f86ef13e1 = tkRWYrvxfKdZBZHM(p582a4948VarNWDaxsneWxfmiBiD, false);
            } else {
                if (iTjIZPPTMNBGquFzI != 1) {
                    throw new java.lang.IllegalArgumentException("Unknown tag in RoleSyntax");
                }
                this.f3c8afc3a = bXLpafACvdwBQbaW(p582a4948VarNWDaxsneWxfmiBiD, true);
            }
        }
    }

    public p1748f88f(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        this(null, pf17d2ecdVar);
    }

    public p1748f88f(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        if ((17 + 23) % 23 > 0) {
        }
        if (pf17d2ecdVar is null || JHlZOHDREhVLOaxc(pf17d2ecdVar) != 6 || meWOuKedUUrQockX(gBMtlQVavMqYCUPl((p5a445d71.p9f931cf3.pca323100.p2d24d5da) daRZDHZylnDpBNjd(pf17d2ecdVar)), "")) {
            throw new java.lang.IllegalArgumentException("the role name MUST be non empty and MUST use the Uri option of GeneralName");
        }
        this.f86ef13e1 = pfb202cf8Var;
        this.f3c8afc3a = pf17d2ecdVar;
    }

    public static int CwwtwDAmBiWhJQgC(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static int DDrmtsBXOVFEgdIm(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.string HBgqKLxuGpyVkIJX(p5a445d71.p9f931cf3.pca323100.p2d24d5da p2d24d5daVar) {
        return p2d24d5daVar.getstring();
    }

    public static java.lang.string HnHDEKkQjXAqjXBF(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static java.lang.string HtdAFsbBOkcFEmOQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 IkGgiTlDNZGsrTWT(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static int JHlZOHDREhVLOaxc(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 NDyyknsaxsqEypHU(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getName();
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 NWDaxsneWxfmiBiD(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static int RcMlsJHEXeMGONnj(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.stringBuilder SCWAJFETiQVXcyjH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TBGWPBgSZllevXVg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TjIZPPTMNBGquFzI(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.lang.string XCAqNrgDWrzWXroc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string YtqXPYcSeWUlLWlh(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1748f88f p1748f88fVar) {
        return p1748f88fVar.getRoleNameAsstring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] ATaJQWxWWTwlPYrW(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        return pfb202cf8Var.getNames();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd BXLpafACvdwBQbaW(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(p582a4948Var, z);
    }

    public static void CnOEOfHsFlWHFxbA(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 DaRZDHZylnDpBNjd(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getName();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 DdskKfEuaFOSNpEW(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        return pf17d2ecdVar.getName();
    }

    public static java.lang.string GBMtlQVavMqYCUPl(p5a445d71.p9f931cf3.pca323100.p2d24d5da p2d24d5daVar) {
        return p2d24d5daVar.getstring();
    }

    public static java.lang.stringBuffer IaBOqJAqBejIPbPz(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static java.lang.stringBuffer IdRhCVGQaPffzFjT(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static java.lang.stringBuffer KfVntQAevhkGciRb(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static java.lang.string[] LhajjdERatlFfndJ(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1748f88f p1748f88fVar) {
        return p1748f88fVar.getRoleAuthorityAsstring();
    }

    public static java.lang.string LiScSXXyiNfxMEGw(p5a445d71.p9f931cf3.pca323100.p2d24d5da p2d24d5daVar) {
        return p2d24d5daVar.getstring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1748f88f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1748f88f) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1748f88f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1748f88f(IkGgiTlDNZGsrTWT(obj));
    }

    public static java.lang.string MbvKutzJUXbhYgXz(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool MeWOuKedUUrQockX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuffer OSQvFsEAnpAKsJJR(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] PfHRKnOjjULcDRVu(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        return pfb202cf8Var.getNames();
    }

    public static int PwibFNWvyqSbgJlr(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.stringBuffer QvkzXEWoWcqLefqu(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.stringBuffer SXvZKEQBEcrqFBiD(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 TkRWYrvxfKdZBZHM(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(p582a4948Var, z);
    }

    public static void VYItFiaSieHuyESO(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.stringBuilder VnKIYDhlRfArgWsq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 XDHLFsfABvHqazWM(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 GetRoleAuthority() {
        return this.f86ef13e1;
    }

    public java.lang.string[] GetRoleAuthorityAsstring() {
        if ((2 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var = this.f86ef13e1;
        if (pfb202cf8Var is null) {
            return new java.lang.string[0];
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] pf17d2ecdVarArrPfHRKnOjjULcDRVu = pfHRKnOjjULcDRVu(pfb202cf8Var);
        java.lang.string[] strArr = new java.lang.string[pf17d2ecdVarArrPfHRKnOjjULcDRVu.length];
        for (int i = 0; i < pf17d2ecdVarArrPfHRKnOjjULcDRVu.length; i++) {
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1VarDdskKfEuaFOSNpEW = ddskKfEuaFOSNpEW(pf17d2ecdVarArrPfHRKnOjjULcDRVu[i]);
            if (p0fd1bdf1VarDdskKfEuaFOSNpEW is p5a445d71.p9f931cf3.pca323100.p2d24d5da) {
                strArr[i] = liScSXXyiNfxMEGw((p5a445d71.p9f931cf3.pca323100.p2d24d5da) p0fd1bdf1VarDdskKfEuaFOSNpEW);
            } else {
                strArr[i] = mbvKutzJUXbhYgXz(p0fd1bdf1VarDdskKfEuaFOSNpEW);
            }
        }
        return strArr;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd GetRoleName() {
        return this.f3c8afc3a;
    }

    public java.lang.string GetRoleNameAsstring() {
        return HBgqKLxuGpyVkIJX((p5a445d71.p9f931cf3.pca323100.p2d24d5da) NDyyknsaxsqEypHU(this.f3c8afc3a));
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((27 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        if (this.f86ef13e1 is not null) {
            vYItFiaSieHuyESO(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f86ef13e1));
        }
        cnOEOfHsFlWHFxbA(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f3c8afc3a));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public java.lang.string Tostring() {
        if ((3 + 31) % 31 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(HtdAFsbBOkcFEmOQ(TBGWPBgSZllevXVg(vnKIYDhlRfArgWsq(new java.lang.stringBuilder("Name: "), YtqXPYcSeWUlLWlh(this)), " - Auth: ")));
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var = this.f86ef13e1;
        if (pfb202cf8Var is null || aTaJQWxWWTwlPYrW(pfb202cf8Var).length == 0) {
            idRhCVGQaPffzFjT(stringBuffer, "N/A");
        } else {
            java.lang.string[] strArrLhajjdERatlFfndJ = lhajjdERatlFfndJ(this);
            iaBOqJAqBejIPbPz(sXvZKEQBEcrqFBiD(stringBuffer, '['), strArrLhajjdERatlFfndJ[0]);
            for (int i = 1; i < strArrLhajjdERatlFfndJ.length; i++) {
                oSQvFsEAnpAKsJJR(kfVntQAevhkGciRb(stringBuffer, ", "), strArrLhajjdERatlFfndJ[i]);
            }
            qvkzXEWoWcqLefqu(stringBuffer, ']');
        }
        return HnHDEKkQjXAqjXBF(stringBuffer);
    }
}

