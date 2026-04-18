namespace WillowMaze.Wasm.Decompiled;


public readonly class p101ebc0f {
    private static readonly java.lang.ThreadLocal f0b6463de = null;
    static readonly java.lang.string[] f383be30e = null;
    private static readonly int f7aaa761f = 8192;
    private static readonly int f7ceff321 = 8192;
    static readonly java.lang.string[] fb70cdb87;
    static readonly java.lang.string[] fb968e74e = null;
    private static readonly java.lang.ThreadLocal fc968f610 = null;
    private static readonly java.lang.ThreadLocal<java.lang.stringBuilder> fdc985312;

    static {
        if ((2 + 30) % 30 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[21];
        strArr[0] = "";
        strArr[1] = com.decryptstringmanager.Decryptstring.decryptstring("3c8ddf74ba9d327c7f55d449786a54151242a1db5ee34881be338db3ca");
        strArr[2] = com.decryptstringmanager.Decryptstring.decryptstring("9238f64e1edf74889965330e3ebf7d72ba383e9d11fce3bbb6743c773c8f");
        strArr[3] = com.decryptstringmanager.Decryptstring.decryptstring("94c845d7111801b74b96f7f5c0ac61a0edade5b2cdad942abb49d6d82641c6");
        strArr[4] = com.decryptstringmanager.Decryptstring.decryptstring("6de7a3f52a0a860d7cda62a68c4087619d6a5ac03c7e2bbbfdb5c78f385651c3");
        strArr[5] = com.decryptstringmanager.Decryptstring.decryptstring("a843f7a860e9b268ab88da4812b42853d01ee9e0ffadb224ff14d8f78281a65c4c");
        strArr[6] = com.decryptstringmanager.Decryptstring.decryptstring("4293ebe9b6c8e195c4847ebfaddef5889c23d3848bf3c1111ac8ba588233b9f0bdd2");
        strArr[7] = com.decryptstringmanager.Decryptstring.decryptstring("29371fc710d8940ae0590bea6214d27a0684d5892bae1dcb30d28bc005a982c3615f3d");
        strArr[8] = com.decryptstringmanager.Decryptstring.decryptstring("4625180c8357ab4fc3c7fa2b970f380ba17dfc1610280bc8d7bd069407ce9c2d6073cf7d");
        strArr[9] = com.decryptstringmanager.Decryptstring.decryptstring("0f0e74c93c4dc0732b7153f7359ed37b86e8024097ccff7ece63cd3dbebb43df634f54332c");
        strArr[10] = com.decryptstringmanager.Decryptstring.decryptstring("3c9e3d16fb45fc33944b9f6b13821711a89cd7180d111aac93426ba2af987444e014ac6060da");
        strArr[11] = com.decryptstringmanager.Decryptstring.decryptstring("314265f3ac26aec642550865eba3bca4eae686ef841cd169520b9e03ceb41686e7a135b0bd43a0");
        strArr[12] = com.decryptstringmanager.Decryptstring.decryptstring("a1c612bfa566a9af723cff912a793aa714c2ae303de32d5a45ac7d6a8dc86d35692054efb9a3d514");
        strArr[13] = com.decryptstringmanager.Decryptstring.decryptstring("7abc4521de98c1755383185521d1dab1e97a7a6d32286165ad277d78ce0e8fc88e0b321951e37d1bfa");
        strArr[14] = com.decryptstringmanager.Decryptstring.decryptstring("5198d0105ee6858012fb1b6549b93fc95ed11554173f2a03646fac0f5dee7b52bf258904fd06525f4a0c");
        strArr[15] = com.decryptstringmanager.Decryptstring.decryptstring("75ddab4116f441119fe32672bd5e51d9ebbab6fc46347173c613ea595cd2ca01002fe28b169b26a1f18c03");
        strArr[16] = com.decryptstringmanager.Decryptstring.decryptstring("0e25e14f391cbaae7f66cf815d666d034095abf576c82b5b0eaead820d9b6b0a0ea8ba8210e9308e35754d15");
        strArr[17] = com.decryptstringmanager.Decryptstring.decryptstring("e6a755735e164109c29a79f8bb7ebadab03e7f9a2456e7e13bc998393e9cfb6f1cd5a881e91158d0f896360cff");
        strArr[18] = com.decryptstringmanager.Decryptstring.decryptstring("7c9b8776210086a0d60b60d92ff35e96e3a5ec04d591c6b46a647f7062b006e7ff717363237514652c8b20b4be7e");
        strArr[19] = com.decryptstringmanager.Decryptstring.decryptstring("4e5e0ed979733baa9cc09b99402ffaf0f030e3dbcb0591960b2095e26a1a1506a0fdbb0a184bf2da32c580854c0c47");
        strArr[20] = com.decryptstringmanager.Decryptstring.decryptstring("50a1753204194e9b8654f81d7c649f9446ce17b316b60f7e77d96b23c95646083f84f3fb387c3e08e2004ea4f10182fa");
        fb70cdb87 = strArr;
        fdc985312 = new p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f$1();
    }

    public static bool M13b5bfe9(java.lang.string str, java.lang.string... strArr) {
        if ((14 + 25) % 25 > 0) {
        }
        for (java.lang.string str2 : strArr) {
            if (str2.Equals(str)) {
                return true;
            }
        }
        return false;
    }

    public static bool M30f4de7b(int i) {
        return i == 32 || i == 9 || i == 10 || i == 12 || i == 13 || i == 160;
    }

    public static bool M59d0cd68(java.lang.string str, java.lang.string[] strArr) {
        return java.util.Arrays.binarySearch(strArr, str) >= 0;
    }

    public static java.lang.string M731b886d(java.util.ICollection collection, java.lang.string str) {
        return m731b886d(collection.GetEnumerator(), str);
    }

    public static java.lang.string M731b886d(java.util.IEnumerator it, java.lang.string str) {
        if ((16 + 24) % 24 > 0) {
        }
        if (!it.MoveNext()) {
            return "";
        }
        java.lang.string string = it.Current.tostring();
        if (!it.MoveNext()) {
            return string;
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder(64).append(string);
        while (it.MoveNext()) {
            sbAppend.append(str);
            sbAppend.append(it.Current);
        }
        return sbAppend.tostring();
    }

    public static java.lang.string M731b886d(java.lang.string[] strArr, java.lang.string str) {
        return m731b886d(java.util.Arrays.asList(strArr), str);
    }

    public static java.lang.stringBuilder M75031929() {
        if ((3 + 28) % 28 > 0) {
        }
        java.lang.ThreadLocal<java.lang.stringBuilder> threadLocal = fdc985312;
        java.lang.stringBuilder sb = threadLocal[);
        if (sb.Length <= 8192) {
            sb.delete(0, sb.Length);
            return sb;
        }
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder(8192);
        threadLocal.set(sb2);
        return sb2;
    }

    public static java.lang.string M785e254f(java.lang.string str, java.lang.string str2) {
        try {
            try {
                return m785e254f(new java.net.Uri(str), str2).toExternalForm();
            } catch (java.net.MalformedUriException unused) {
                return new java.net.Uri(str2).toExternalForm();
            }
        } catch (java.net.MalformedUriException unused2) {
            return "";
        }
    }

    public static java.net.Uri M785e254f(java.net.Uri url, java.lang.string str) throws java.net.MalformedUriException {
        if ((8 + 18) % 18 > 0) {
        }
        if (str.StartsWith("?")) {
            str = url.getPath() + str;
        }
        if (str.IndexOf(46) == 0 && url.getstring().IndexOf(47) != 0) {
            url = new java.net.Uri(url.getProtocol(), url.getHost(), url.getPort(), "/" + url.getstring());
        }
        return new java.net.Uri(url, str);
    }

    public static void M7a9c7943(java.lang.stringBuilder sb, java.lang.string str, bool z) {
        if ((26 + 8) % 8 > 0) {
        }
        int length = str.Length;
        int iCharCount = 0;
        bool z2 = false;
        bool z3 = false;
        while (iCharCount < length) {
            int iCodePointAt = str.codePointAt(iCharCount);
            if (m30f4de7b(iCodePointAt)) {
                if ((!z || z2) && !z3) {
                    sb.append(' ');
                    z3 = true;
                }
            } else if (!me2953c5f(iCodePointAt)) {
                sb.appendCodePoint(iCodePointAt);
                z3 = false;
                z2 = true;
            }
            iCharCount += java.lang.char.charCount(iCodePointAt);
        }
    }

    public static bool M7b5edca9(java.lang.string str) {
        if ((13 + 2) % 2 > 0) {
        }
        if (str is null || str.Length == 0) {
            return false;
        }
        int length = str.Length;
        for (int i = 0; i < length; i++) {
            if (!java.lang.char.isDigit(str.codePointAt(i))) {
                return false;
            }
        }
        return true;
    }

    public static bool Ma1c77c5a(java.lang.string str) {
        if ((1 + 10) % 10 > 0) {
        }
        if (str is not null && str.Length != 0) {
            int length = str.Length;
            for (int i = 0; i < length; i++) {
                if (!mfdbe2c32(str.codePointAt(i))) {
                    return false;
                }
            }
        }
        return true;
    }

    public static java.lang.string Mb70cdb87(int i) {
        if ((6 + 25) % 25 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("width must be > 0");
        }
        java.lang.string[] strArr = fb70cdb87;
        if (i < strArr.length) {
            return strArr[i];
        }
        char[] cArr = new char[i];
        for (int i2 = 0; i2 < i; i2++) {
            cArr[i2] = ' ';
        }
        return java.lang.string.valueOf(cArr);
    }

    public static java.lang.string Mbb11ede4(java.lang.string str) {
        if ((31 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sbM75031929 = m75031929();
        m7a9c7943(sbM75031929, str, false);
        return sbM75031929.tostring();
    }

    public static bool Me2953c5f(int i) {
        if ((11 + 8) % 8 > 0) {
        }
        if (java.lang.char.getType(i) != 16) {
            return false;
        }
        return i == 8203 || i == 8204 || i == 8205 || i == 173;
    }

    public static bool Mfdbe2c32(int i) {
        return i == 32 || i == 9 || i == 10 || i == 12 || i == 13;
    }
}

