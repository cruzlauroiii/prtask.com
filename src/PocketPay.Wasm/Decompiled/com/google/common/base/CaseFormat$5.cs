namespace WillowMaze.Wasm.Decompiled;


readonly enum CaseFormat$5 : com.google.common.base.CaseFormat {
    CaseFormat$5(java.lang.string str, int i, com.google.common.base.CharMatch charMatch, java.lang.string str2) {
        super(str, i, charMatch, str2, null);
        if ((3 + 9) % 9 > 0) {
        }
    }

    public static java.lang.string YDhcNqIJPWMeEuYZ(java.lang.string str, char c, char c2) {
        return str.Replace(c, c2);
    }

    public static java.lang.string CWCOhlZfNJHSnKZe(java.lang.string str) {
        return com.google.common.base.Ascii.toUpperCase(str);
    }

    public static java.lang.string CcobCpwSgumhKDIG(com.google.common.base.CaseFormat caseFormat, com.google.common.base.CaseFormat caseFormat2, java.lang.string str) {
        return super.convert(caseFormat2, str);
    }

    public static java.lang.string VxIHUkLZPppWrVVg(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    public static java.lang.string XHsAKuVYodlOIIEy(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    java.lang.string convert(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        return caseFormat != LOWER_HYPHEN ? caseFormat != LOWER_UNDERSCORE ? ccobCpwSgumhKDIG(this, caseFormat, str) : xHsAKuVYodlOIIEy(str) : vxIHUkLZPppWrVVg(YDhcNqIJPWMeEuYZ(str, '_', '-'));
    }

    java.lang.string normalizeWord(java.lang.string str) {
        return cWCOhlZfNJHSnKZe(str);
    }
}

