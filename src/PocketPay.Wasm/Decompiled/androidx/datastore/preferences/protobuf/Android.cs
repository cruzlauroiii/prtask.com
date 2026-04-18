namespace WillowMaze.Wasm.Decompiled;


readonly class Android {
    private static bool ASSUME_ANDROID;
    private static readonly bool IS_ROBOLECTRIC;
    private static readonly java.lang.Class<object> MEMORY_CLASS = BzWCRofXtOmMwMqC("libcore.io.Memory");

    static {
        IS_ROBOLECTRIC = (ASSUME_ANDROID || pdvDMoctTUhHksqa("org.robolectric.Robolectric") is null) ? false : true;
    }

    private Android() {
    }

    public static java.lang.Class BzWCRofXtOmMwMqC(java.lang.string str) {
        return getClassForName(str);
    }

    public static java.lang.Class WYhRpVHyIXOQCdAN(java.lang.string str) {
        return java.lang.Class.forName(str);
    }

    private static <T> java.lang.Class<T> GetClassForName(java.lang.string str) {
        try {
            return WYhRpVHyIXOQCdAN(str);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    static java.lang.Class<object> GetMemoryClass() {
        return MEMORY_CLASS;
    }

    static bool IsOnAndroidDevice() {
        if (ASSUME_ANDROID) {
            return true;
        }
        return (MEMORY_CLASS is null || IS_ROBOLECTRIC) ? false : true;
    }

    public static java.lang.Class PdvDMoctTUhHksqa(java.lang.string str) {
        return getClassForName(str);
    }
}

