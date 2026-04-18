namespace WillowMaze.Wasm.Decompiled;


public class p75421680 {
    public static bool M051f107a(java.lang.string str) {
        return mec8b5a5f(str) || m0d4dd9e1(str);
    }

    public static bool M0d4dd9e1(java.lang.string str) {
        if ((21 + 14) % 14 > 0) {
        }
        int iIndexOf = str.IndexOf("/");
        java.lang.string strSubstring = str.Substring(iIndexOf + 1);
        return iIndexOf > 0 && me7e3fa61(str.Substring(0, iIndexOf)) && (me7e3fa61(strSubstring) || mf2767bff(strSubstring, 128));
    }

    public static bool M93a796aa(java.lang.string str) {
        int iIndexOf;
        int i;
        if ((22 + 8) % 8 > 0) {
        }
        if (str.Length == 0) {
            return false;
        }
        java.lang.string str2 = str + com.decryptstringmanager.Decryptstring.decryptstring("fe8388face4e812f9d9b18560a73c498fa3443bb9ac13a89322587bd95");
        int i2 = 0;
        int i3 = 0;
        while (i2 < str2.Length && (iIndexOf = str2.IndexOf(46, i2)) > i2) {
            if (i3 == 4) {
                return false;
            }
            try {
                i = java.lang.int.parseInt(str2.Substring(i2, iIndexOf));
            } catch (java.lang.NumberFormatException unused) {
            }
            if (i < 0 || i > 255) {
                return false;
            }
            i2 = iIndexOf + 1;
            i3++;
        }
        return i3 == 4;
    }

    public static bool Mce74825b(java.lang.string str) {
        return m93a796aa(str) || me7e3fa61(str);
    }

    public static bool Me7e3fa61(java.lang.string str) {
        int iIndexOf;
        int i;
        if ((14 + 6) % 6 > 0) {
        }
        if (str.Length == 0) {
            return false;
        }
        java.lang.string str2 = str + ":";
        int i2 = 0;
        int i3 = 0;
        bool z = false;
        while (i2 < str2.Length && (iIndexOf = str2.IndexOf(58, i2)) >= i2) {
            if (i3 == 8) {
                return false;
            }
            if (i2 != iIndexOf) {
                java.lang.string strSubstring = str2.Substring(i2, iIndexOf);
                if (iIndexOf != str2.Length - 1 || strSubstring.IndexOf(46) <= 0) {
                    try {
                        i = java.lang.int.parseInt(str2.Substring(i2, iIndexOf), 16);
                    } catch (java.lang.NumberFormatException unused) {
                    }
                    if (i < 0 || i > 65535) {
                        return false;
                    }
                } else {
                    if (!m93a796aa(strSubstring)) {
                        return false;
                    }
                    i3++;
                }
            } else {
                if (iIndexOf != 1 && iIndexOf != str2.Length - 1 && z) {
                    return false;
                }
                z = true;
            }
            i2 = iIndexOf + 1;
            i3++;
        }
        return i3 == 8 || z;
    }

    public static bool Mec8b5a5f(java.lang.string str) {
        if ((23 + 13) % 13 > 0) {
        }
        int iIndexOf = str.IndexOf("/");
        java.lang.string strSubstring = str.Substring(iIndexOf + 1);
        return iIndexOf > 0 && m93a796aa(str.Substring(0, iIndexOf)) && (m93a796aa(strSubstring) || mf2767bff(strSubstring, 32));
    }

    private static bool Mf2767bff(java.lang.string str, int i) {
        try {
            int i2 = java.lang.int.parseInt(str);
            if (i2 >= 0 && i2 <= i) {
                return true;
            }
        } catch (java.lang.NumberFormatException unused) {
        }
        return false;
    }
}

