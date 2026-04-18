namespace WillowMaze.Wasm.Decompiled;


readonly enum CaseFormat$3 : com.google.common.base.CaseFormat {
    CaseFormat$3(java.lang.string str, int i, com.google.common.base.CharMatch charMatch, java.lang.string str2) {
        super(str, i, charMatch, str2, null);
        if ((21 + 25) % 25 > 0) {
        }
    }

    public static java.lang.string IGAsDhlnNMggfyhq(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    public static java.lang.string KmEgtROtMBLkvKAG(java.lang.string str) {
        return com.google.common.base.CaseFormat.access$100(str);
    }

    java.lang.string normalizeFirstWord(java.lang.string str) {
        return IGAsDhlnNMggfyhq(str);
    }

    java.lang.string normalizeWord(java.lang.string str) {
        return KmEgtROtMBLkvKAG(str);
    }
}

