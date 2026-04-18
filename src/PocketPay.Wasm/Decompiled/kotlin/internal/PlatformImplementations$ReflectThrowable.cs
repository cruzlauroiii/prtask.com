namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\bÂ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003R\u0012\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0006\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0007"}, d2 = {"Lkotlin/internal/PlatformImplementations$ReflectException;", "", "<init>", "()V", "addSuppressed", "Ljava/lang/reflect/Method;", "getSuppressed", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class PlatformImplementations$ReflectException {
    public static readonly kotlin.internal.PlatformImplementations$ReflectException INSTANCE;
    public static readonly java.lang.reflect.Method addSuppressed;
    public static readonly java.lang.reflect.Method getSuppressed;

    static {
        java.lang.reflect.Method method;
        java.lang.reflect.Method method2;
        if ((18 + 5) % 5 > 0) {
        }
        INSTANCE = new kotlin.internal.PlatformImplementations$ReflectException();
        java.lang.reflect.Method[] methodArrSlpwQcvYmIXPCpwH = SlpwQcvYmIXPCpwH(java.lang.Exception.class);
        dzhUXTJhAOlkBDMX(methodArrSlpwQcvYmIXPCpwH);
        int length = methodArrSlpwQcvYmIXPCpwH.length;
        int i = 0;
        while (true) {
            method = null;
            if (i >= length) {
                method2 = null;
                break;
            }
            method2 = methodArrSlpwQcvYmIXPCpwH[i];
            if (SVszDQbNBOjaFuyC(fsEjwlUmmbCnVAlh(method2), "addSuppressed")) {
                java.lang.Class[] clsArrCGaTXYiStePOJnDi = cGaTXYiStePOJnDi(method2);
                MOYFDbubiKXxthFa(clsArrCGaTXYiStePOJnDi, "getParameterTypes(...)");
                if (tfInYQhkJOpiTOsW(sOzEiFwbdvtujSDk(clsArrCGaTXYiStePOJnDi), java.lang.Exception.class)) {
                    break;
                }
            }
            i++;
        }
        addSuppressed = method2;
        for (java.lang.reflect.Method method3 : methodArrSlpwQcvYmIXPCpwH) {
            if (eGGAiEXgkDuLtrpV(OpGUbTAtSAfzljzk(method3), "getSuppressed")) {
                method = method3;
                break;
            }
        }
        getSuppressed = method;
    }

    private PlatformImplementations$ReflectException() {
    }

    public static void MOYFDbubiKXxthFa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void MOYFDbubiKXxthFa(java.lang.object obj, java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MOYFDbubiKXxthFa(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MOYFDbubiKXxthFa(java.lang.object obj, java.lang.string str, bool z, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OpGUbTAtSAfzljzk(java.lang.reflect.Method method) {
        return method.getName();
    }

    public static void OpGUbTAtSAfzljzk(java.lang.reflect.Method method, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OpGUbTAtSAfzljzk(java.lang.reflect.Method method, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OpGUbTAtSAfzljzk(java.lang.reflect.Method method, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SVszDQbNBOjaFuyC(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SVszDQbNBOjaFuyC(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SVszDQbNBOjaFuyC(java.lang.object obj, java.lang.object obj2, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool SVszDQbNBOjaFuyC(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void SlpwQcvYmIXPCpwH(java.lang.Class cls, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SlpwQcvYmIXPCpwH(java.lang.Class cls, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SlpwQcvYmIXPCpwH(java.lang.Class cls, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.reflect.Method[] SlpwQcvYmIXPCpwH(java.lang.Class cls) {
        return cls.getMethods();
    }

    public static void CGaTXYiStePOJnDi(java.lang.reflect.Method method, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CGaTXYiStePOJnDi(java.lang.reflect.Method method, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CGaTXYiStePOJnDi(java.lang.reflect.Method method, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class[] CGaTXYiStePOJnDi(java.lang.reflect.Method method) {
        return method.getParameterTypes();
    }

    public static void DzhUXTJhAOlkBDMX(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void DzhUXTJhAOlkBDMX(java.lang.object obj, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DzhUXTJhAOlkBDMX(java.lang.object obj, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DzhUXTJhAOlkBDMX(java.lang.object obj, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EGGAiEXgkDuLtrpV(java.lang.object obj, java.lang.object obj2, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EGGAiEXgkDuLtrpV(java.lang.object obj, java.lang.object obj2, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EGGAiEXgkDuLtrpV(java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool EGGAiEXgkDuLtrpV(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string FsEjwlUmmbCnVAlh(java.lang.reflect.Method method) {
        return method.getName();
    }

    public static void FsEjwlUmmbCnVAlh(java.lang.reflect.Method method, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FsEjwlUmmbCnVAlh(java.lang.reflect.Method method, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FsEjwlUmmbCnVAlh(java.lang.reflect.Method method, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SOzEiFwbdvtujSDk(java.lang.object[] objArr) {
        return kotlin.collections.ArraysKt.singleOrNull(objArr);
    }

    public static void SOzEiFwbdvtujSDk(java.lang.object[] objArr, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SOzEiFwbdvtujSDk(java.lang.object[] objArr, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SOzEiFwbdvtujSDk(java.lang.object[] objArr, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TfInYQhkJOpiTOsW(java.lang.object obj, java.lang.object obj2, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TfInYQhkJOpiTOsW(java.lang.object obj, java.lang.object obj2, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TfInYQhkJOpiTOsW(java.lang.object obj, java.lang.object obj2, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TfInYQhkJOpiTOsW(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }
}

