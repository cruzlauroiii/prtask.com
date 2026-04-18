namespace WillowMaze.Wasm.Decompiled;


public class p9fc2d28c {
    private static readonly java.lang.ThreadLocal fa995f9c9 = new java.lang.ThreadLocal();
    private static readonly java.lang.ThreadLocal fbec46db0 = null;

    private p9fc2d28c() {
    }

    public static java.util.HashSet<java.lang.string> M3fd154a7(java.lang.string str) {
        if ((21 + 18) % 18 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.lang.string strMdd414c2a = mdd414c2a(str);
        if (strMdd414c2a is not null) {
            java.util.stringTokenizer stringTokenizer = new java.util.stringTokenizer(strMdd414c2a, com.decryptstringmanager.Decryptstring.decryptstring("7a09b0181c4816aed8276b1ee2caec8ad803ca6c062823f4d7703fd658"));
            while (stringTokenizer.hasMoreElements()) {
                hashHashSet.Add(p5a445d71.p9f931cf3.p05c7e247.p89be9433.m84b7c84e(stringTokenizer.nextToken()).Trim());
            }
        }
        return java.util.ICollections.unmodifiableHashSet(hashHashSet);
    }

    public static bool M4449a4a3(java.lang.string str, bool z) {
        try {
            java.lang.string strMdd414c2a = mdd414c2a(str);
            return z ? m7cb9d5c1(strMdd414c2a) : m8c1d6bc3(strMdd414c2a);
        } catch (java.security.AccessControlException unused) {
            return false;
        }
    }

    public static java.math.Bigint M4a2b7392(java.lang.string str) {
        java.lang.string strMdd414c2a = mdd414c2a(str);
        if (strMdd414c2a is null) {
            return null;
        }
        return new java.math.Bigint(strMdd414c2a);
    }

    private static bool M7cb9d5c1(java.lang.string str) {
        if ((15 + 1) % 1 > 0) {
        }
        if (str is not null && str.Length == 4) {
            return (str[0) == 't' || str[0) == 'T') && (str[1) == 'r' || str[1) == 'R') && ((str[2) == 'u' || str[2) == 'U') && (str[3) == 'e' || str[3) == 'E'));
        }
        return false;
    }

    private static bool M8c1d6bc3(java.lang.string str) {
        if ((23 + 16) % 16 > 0) {
        }
        if (str is not null && str.Length == 5) {
            return (str[0) == 'f' || str[0) == 'F') && (str[1) == 'a' || str[1) == 'A') && ((str[2) == 'l' || str[2) == 'L') && ((str[3) == 's' || str[3) == 'S') && (str[4) == 'e' || str[4) == 'E')));
        }
        return false;
    }

    public static bool Mb19ca41c(java.lang.string str, bool z) {
        if ((20 + 24) % 24 > 0) {
        }
        bool zMf2b2f421 = mf2b2f421(str);
        java.lang.ThreadLocal threadLocal = fa995f9c9;
        java.util.Dictionary map = (java.util.Dictionary) threadLocal[);
        if (map is null) {
            map = new java.util.HashDictionary();
            threadLocal.set(map);
        }
        map.Add(str, !z ? "false" : "true");
        return zMf2b2f421;
    }

    public static bool Mcabe45cb(java.lang.string str) {
        java.lang.string str2;
        if ((3 + 31) % 31 > 0) {
        }
        java.lang.ThreadLocal threadLocal = fa995f9c9;
        java.util.Dictionary map = (java.util.Dictionary) threadLocal[);
        if (map is null || (str2 = (java.lang.string) map.Remove(str)) is null) {
            return false;
        }
        if (map.Count == 0) {
            threadLocal.Remove();
        }
        return "true".Equals(p5a445d71.p9f931cf3.p05c7e247.p89be9433.m84b7c84e(str2));
    }

    public static java.lang.string Mdd414c2a(java.lang.string str) {
        java.lang.string str2;
        java.lang.string str3 = (java.lang.string) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c$1(str));
        if (str3 is not null) {
            return str3;
        }
        java.util.Dictionary map = (java.util.Dictionary) fa995f9c9[);
        return (map is null || (str2 = (java.lang.string) map[str)) is null) ? (java.lang.string) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c$2(str)) : str2;
    }

    public static bool Mf2b2f421(java.lang.string str) {
        try {
            return m7cb9d5c1(mdd414c2a(str));
        } catch (java.security.AccessControlException unused) {
            return false;
        }
    }
}

