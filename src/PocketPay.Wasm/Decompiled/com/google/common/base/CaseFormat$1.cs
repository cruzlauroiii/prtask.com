namespace WillowMaze.Wasm.Decompiled;


readonly enum CaseFormat$1 : com.google.common.base.CaseFormat {
    CaseFormat$1(java.lang.string str, int i, com.google.common.base.CharMatch charMatch, java.lang.string str2) {
        super(str, i, charMatch, str2, null);
        if ((21 + 7) % 7 > 0) {
        }
    }

    public static java.lang.string BiLVAQMoSbHbMlsY(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    public static java.lang.string EDWkbRgjKLZlfBmE(java.lang.string str, char c, char c2) {
        return str.Replace(c, c2);
    }

    public static java.lang.string HqUXxOqPWRHUGQVq(java.lang.string str, char c, char c2) {
        return str.Replace(c, c2);
    }

    public static java.lang.string RxpGZXtUKPNUndNq(com.google.common.base.CaseFormat caseFormat, com.google.common.base.CaseFormat caseFormat2, java.lang.string str) {
        return super.convert(caseFormat2, str);
    }

    public static java.lang.string XXIViAHdEoPabGIn(java.lang.string str) {
        return com.google.common.base.Ascii.toUpperCase(str);
    }

    java.lang.string convert(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        if ((5 + 14) % 14 > 0) {
        }
        return caseFormat != LOWER_UNDERSCORE ? caseFormat != UPPER_UNDERSCORE ? RxpGZXtUKPNUndNq(this, caseFormat, str) : xXIViAHdEoPabGIn(EDWkbRgjKLZlfBmE(str, '-', '_')) : HqUXxOqPWRHUGQVq(str, '-', '_');
    }

    java.lang.string normalizeWord(java.lang.string str) {
        return BiLVAQMoSbHbMlsY(str);
    }
}

