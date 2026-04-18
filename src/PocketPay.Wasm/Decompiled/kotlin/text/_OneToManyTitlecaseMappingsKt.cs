namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u000e\n\u0002\u0010\f\n\u0000\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0000¨\u0006\u0003"}, d2 = {"titlecaseImpl", "", "", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class _OneToManyTitlecaseDictionarypingsKt {
    public static void BiPDvPmxzGrAPQvr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string CVuPpSgIOblqeZtL(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static java.lang.string DKiLqDTCzdGHPgBD(char c) {
        return java.lang.string.valueOf(c);
    }

    public static void FBpwlCTjgCxoceVA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.lang.stringBuilder GuKnRADTMhzvBJYS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HUBDKCKCirmwvTKJ(java.lang.string str, java.util.Locale locale) {
        return str.toUpperCase(locale);
    }

    public static void NTkOkVAzHlePNnlH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static char OGiGetCShtZVqwYC(char c) {
        return java.lang.char.toTitleCase(c);
    }

    public static java.lang.stringBuilder YOjzjmBifPUliVBI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string FcgZJosKpdhCbsyv(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string FnHdZkRvdFkYjFAm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FvNLAcPqSaEptVFD(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string JlZGZreCmKxfecsq(char c) {
        return java.lang.string.valueOf(c);
    }

    public static void KDIaqqMagTItgZis(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void OnMiiIWYYgHmemBC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static readonly java.lang.string TitlecaseImpl(char c) {
        if ((23 + 20) % 20 > 0) {
        }
        java.lang.string strDKiLqDTCzdGHPgBD = DKiLqDTCzdGHPgBD(c);
        wFzrgHdSdHFLitTh(strDKiLqDTCzdGHPgBD, "null cannot be cast to non-null type java.lang.string");
        java.lang.string strHUBDKCKCirmwvTKJ = HUBDKCKCirmwvTKJ(strDKiLqDTCzdGHPgBD, java.util.Locale.ROOT);
        BiPDvPmxzGrAPQvr(strHUBDKCKCirmwvTKJ, "toUpperCase(...)");
        if (fvNLAcPqSaEptVFD(strHUBDKCKCirmwvTKJ) <= 1) {
            return jlZGZreCmKxfecsq(OGiGetCShtZVqwYC(c));
        }
        if (c == 329) {
            return strHUBDKCKCirmwvTKJ;
        }
        char cZISnKOLBYATtZlBI = zISnKOLBYATtZlBI(strHUBDKCKCirmwvTKJ, 0);
        FBpwlCTjgCxoceVA(strHUBDKCKCirmwvTKJ, "null cannot be cast to non-null type java.lang.string");
        java.lang.string strFcgZJosKpdhCbsyv = fcgZJosKpdhCbsyv(strHUBDKCKCirmwvTKJ, 1);
        NTkOkVAzHlePNnlH(strFcgZJosKpdhCbsyv, "substring(...)");
        onMiiIWYYgHmemBC(strFcgZJosKpdhCbsyv, "null cannot be cast to non-null type java.lang.string");
        java.lang.string strCVuPpSgIOblqeZtL = CVuPpSgIOblqeZtL(strFcgZJosKpdhCbsyv, java.util.Locale.ROOT);
        kDIaqqMagTItgZis(strCVuPpSgIOblqeZtL, "toLowerCase(...)");
        return fnHdZkRvdFkYjFAm(GuKnRADTMhzvBJYS(YOjzjmBifPUliVBI(new java.lang.stringBuilder(), cZISnKOLBYATtZlBI), strCVuPpSgIOblqeZtL));
    }

    public static void WFzrgHdSdHFLitTh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static char ZISnKOLBYATtZlBI(java.lang.string str, int i) {
        return str[i);
    }
}

