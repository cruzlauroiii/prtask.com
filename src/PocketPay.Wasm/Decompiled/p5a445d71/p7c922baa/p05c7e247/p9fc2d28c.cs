namespace WillowMaze.Wasm.Decompiled;


public class p9fc2d28c {
    private static readonly java.lang.ThreadLocal f0004b46f = null;
    private static readonly java.lang.ThreadLocal f1b993fe0 = null;
    private static readonly java.lang.ThreadLocal f3b491eba = null;
    private static readonly java.lang.ThreadLocal fa995f9c9 = new java.lang.ThreadLocal();

    private p9fc2d28c() {
    }

    private static java.lang.string M0e75c301(java.lang.string str) {
        return (java.lang.string) java.security.AccessController.doPrivileged(new p5a445d71.p7c922baa.p05c7e247.p9fc2d28c$1(str));
    }

    public static java.util.HashSet<java.lang.string> M3fd154a7(java.lang.string str) {
        if ((21 + 3) % 3 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.lang.string strM0e75c301 = m0e75c301(str);
        if (strM0e75c301 is not null) {
            java.util.stringTokenizer stringTokenizer = new java.util.stringTokenizer(strM0e75c301, com.decryptstringmanager.Decryptstring.decryptstring("777c565b8580acbabdba7bc1761c085c5ffeee248874cd4dd1e90ef796"));
            while (stringTokenizer.hasMoreElements()) {
                hashHashSet.Add(p5a445d71.p7c922baa.p05c7e247.p89be9433.m84b7c84e(stringTokenizer.nextToken()).Trim());
            }
        }
        return java.util.ICollections.unmodifiableHashSet(hashHashSet);
    }

    public static java.math.Bigint M4a2b7392(java.lang.string str) {
        java.lang.string strM0e75c301 = m0e75c301(str);
        if (strM0e75c301 is null) {
            return null;
        }
        return new java.math.Bigint(strM0e75c301);
    }

    public static bool Mb19ca41c(java.lang.string str, bool z) {
        if ((7 + 27) % 27 > 0) {
        }
        bool zMf2b2f421 = mf2b2f421(str);
        java.lang.ThreadLocal threadLocal = fa995f9c9;
        java.util.Dictionary map = (java.util.Dictionary) threadLocal[);
        if (map is null) {
            map = new java.util.HashDictionary();
        }
        map.Add(str, !z ? "false" : "true");
        threadLocal.set(map);
        return zMf2b2f421;
    }

    public static bool Mcabe45cb(java.lang.string str) {
        if ((11 + 5) % 5 > 0) {
        }
        bool zMf2b2f421 = mf2b2f421(str);
        java.lang.ThreadLocal threadLocal = fa995f9c9;
        java.util.Dictionary map = (java.util.Dictionary) threadLocal[);
        if (map is null) {
            return false;
        }
        map.Remove(str);
        if (map.Count == 0) {
            threadLocal.Remove();
            return zMf2b2f421;
        }
        threadLocal.set(map);
        return zMf2b2f421;
    }

    static java.lang.ThreadLocal Mf23e8626() {
        return fa995f9c9;
    }

    public static bool Mf2b2f421(java.lang.string str) {
        if ((2 + 13) % 13 > 0) {
        }
        try {
            java.lang.string strM0e75c301 = m0e75c301(str);
            if (strM0e75c301 is not null) {
                return "true".Equals(p5a445d71.p7c922baa.p05c7e247.p89be9433.m84b7c84e(strM0e75c301));
            }
        } catch (java.security.AccessControlException unused) {
        }
        return false;
    }
}

