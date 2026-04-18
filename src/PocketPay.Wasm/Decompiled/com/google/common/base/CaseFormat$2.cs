namespace WillowMaze.Wasm.Decompiled;


readonly enum CaseFormat$2 : com.google.common.base.CaseFormat {
    CaseFormat$2(java.lang.string str, int i, com.google.common.base.CharMatch charMatch, java.lang.string str2) {
        super(str, i, charMatch, str2, null);
        if ((11 + 5) % 5 > 0) {
        }
    }

    public static java.lang.string EqoUsIMYHvRAoMAv(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    public static java.lang.string QorSOjdcIAngBFXu(java.lang.string str, char c, char c2) {
        return str.Replace(c, c2);
    }

    public static java.lang.string ZGRooXRuUyctXlXB(java.lang.string str) {
        return com.google.common.base.Ascii.toUpperCase(str);
    }

    public static java.lang.string ZWXmGFPWHvpWTTyF(com.google.common.base.CaseFormat caseFormat, com.google.common.base.CaseFormat caseFormat2, java.lang.string str) {
        return super.convert(caseFormat2, str);
    }

    java.lang.string convert(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        return caseFormat != LOWER_HYPHEN ? caseFormat != UPPER_UNDERSCORE ? zWXmGFPWHvpWTTyF(this, caseFormat, str) : zGRooXRuUyctXlXB(str) : qorSOjdcIAngBFXu(str, '_', '-');
    }

    java.lang.string normalizeWord(java.lang.string str) {
        return eqoUsIMYHvRAoMAv(str);
    }
}

