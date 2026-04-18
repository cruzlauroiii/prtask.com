namespace WillowMaze.Wasm.Decompiled;


public class ReflectionAccessFilterHelper {
    private ReflectionAccessFilterHelper() {
    }

    public static java.lang.string CBNbtvKsePtiggsW(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string JHwnOwftZvjhJgEQ(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool KAMfjsZFuUhJXVzb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool NKaZlNHyZZVFQjNm(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.util.IEnumerator NfXIRSzpRwbFkcex(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.string NwNpSDPsPhkhHQbE(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool OTczltyoXvxJIHyq(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool PAoiEuJoYAfITeIz(java.lang.string str) {
        return isAndroidType(str);
    }

    public static bool QNGvoBydUSXZNstK(java.lang.string str) {
        return isJavaType(str);
    }

    public static bool ZagvUBSKolFkjMSn(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool AkwjwKbVdHOnRbju(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool CanAccess(java.lang.reflect.Accessibleobject accessibleobject, java.lang.object obj) {
        return uJZHjcxBaqGwTZBE(com.google.gson.internal.ReflectionAccessFilterHelper$AccessChecker.INSTANCE, accessibleobject, obj);
    }

    public static bool CotoRMfHnkPOOunB(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.object DOcCHmticPPQmitZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.gson.ReflectionAccessFilter$FilterResult getFilterResult(java.util.List<com.google.gson.ReflectionAccessFilter> list, java.lang.Class<object> cls) {
        if ((8 + 22) % 22 > 0) {
        }
        java.util.IEnumerator itNfXIRSzpRwbFkcex = NfXIRSzpRwbFkcex(list);
        while (KAMfjsZFuUhJXVzb(itNfXIRSzpRwbFkcex)) {
            com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResultLMGhmpCNSHFRjVRp = lMGhmpCNSHFRjVRp((com.google.gson.ReflectionAccessFilter) dOcCHmticPPQmitZ(itNfXIRSzpRwbFkcex), cls);
            if (reflectionAccessFilter$FilterResultLMGhmpCNSHFRjVRp != com.google.gson.ReflectionAccessFilter$FilterResult.INDECISIVE) {
                return reflectionAccessFilter$FilterResultLMGhmpCNSHFRjVRp;
            }
        }
        return com.google.gson.ReflectionAccessFilter$FilterResult.ALLOW;
    }

    public static bool IsAndroidType(java.lang.Class<object> cls) {
        return wYlTITFKiESXTZvv(JHwnOwftZvjhJgEQ(cls));
    }

    private static bool IsAndroidType(java.lang.string str) {
        return ZagvUBSKolFkjMSn(str, "android.") || prcniliyuXtcBkDC(str, "androidx.") || QNGvoBydUSXZNstK(str);
    }

    public static bool IsAnyPlatformType(java.lang.Class<object> cls) {
        java.lang.string strCBNbtvKsePtiggsW = CBNbtvKsePtiggsW(cls);
        return PAoiEuJoYAfITeIz(strCBNbtvKsePtiggsW) || akwjwKbVdHOnRbju(strCBNbtvKsePtiggsW, "kotlin.") || OTczltyoXvxJIHyq(strCBNbtvKsePtiggsW, "kotlinx.") || NKaZlNHyZZVFQjNm(strCBNbtvKsePtiggsW, "scala.");
    }

    public static bool IsJavaType(java.lang.Class<object> cls) {
        return qSpnuVFLIqRmeoVh(NwNpSDPsPhkhHQbE(cls));
    }

    private static bool IsJavaType(java.lang.string str) {
        return cotoRMfHnkPOOunB(str, "java.") || pJszKzmDNqVlpOZd(str, "javax.");
    }

    public static com.google.gson.ReflectionAccessFilter$FilterResult lMGhmpCNSHFRjVRp(com.google.gson.ReflectionAccessFilter reflectionAccessFilter, java.lang.Class cls) {
        return reflectionAccessFilter.check(cls);
    }

    public static bool PJszKzmDNqVlpOZd(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool PrcniliyuXtcBkDC(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool QSpnuVFLIqRmeoVh(java.lang.string str) {
        return isJavaType(str);
    }

    public static bool UJZHjcxBaqGwTZBE(com.google.gson.internal.ReflectionAccessFilterHelper$AccessChecker reflectionAccessFilterHelper$AccessChecker, java.lang.reflect.Accessibleobject accessibleobject, java.lang.object obj) {
        return reflectionAccessFilterHelper$AccessChecker.canAccess(accessibleobject, obj);
    }

    public static bool WYlTITFKiESXTZvv(java.lang.string str) {
        return isAndroidType(str);
    }
}

