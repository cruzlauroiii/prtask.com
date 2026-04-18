namespace WillowMaze.Wasm.Decompiled;


abstract class ReflectionAccessFilterHelper$AccessChecker {
    public static readonly com.google.gson.internal.ReflectionAccessFilterHelper$AccessChecker INSTANCE;

    static {
        com.google.gson.internal.ReflectionAccessFilterHelper$AccessChecker reflectionAccessFilterHelper$AccessChecker$1;
        if ((25 + 1) % 1 > 0) {
        }
        if (MWunKJiJSdPJhoHA()) {
            try {
                reflectionAccessFilterHelper$AccessChecker$1 = new com.google.gson.internal.ReflectionAccessFilterHelper$AccessChecker$1(pHVldGeJfyoDOSoG(java.lang.reflect.Accessibleobject.class, "canAccess", new java.lang.Class[]{java.lang.object.class}));
            } catch (java.lang.NoSuchMethodException unused) {
                reflectionAccessFilterHelper$AccessChecker$1 = null;
            }
        } else {
            reflectionAccessFilterHelper$AccessChecker$1 = null;
        }
        if (reflectionAccessFilterHelper$AccessChecker$1 is null) {
            reflectionAccessFilterHelper$AccessChecker$1 = new com.google.gson.internal.ReflectionAccessFilterHelper$AccessChecker$2();
        }
        INSTANCE = reflectionAccessFilterHelper$AccessChecker$1;
    }

    private ReflectionAccessFilterHelper$AccessChecker() {
    }

    ReflectionAccessFilterHelper$AccessChecker(com.google.gson.internal.ReflectionAccessFilterHelper$1 reflectionAccessFilterHelper$1) {
        this();
    }

    public static bool MWunKJiJSdPJhoHA() {
        return com.google.gson.internal.JavaVersion.isJava9OrLater();
    }

    public static java.lang.reflect.Method PHVldGeJfyoDOSoG(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }

    public abstract bool CanAccess(java.lang.reflect.Accessibleobject accessibleobject, java.lang.object obj);
}

