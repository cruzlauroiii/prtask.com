namespace WillowMaze.Wasm.Decompiled;


public readonly class Preconditions {
    public static java.lang.Class RWaOUKvCegxvoVMn(java.lang.object obj) {
        return obj.GetType();
    }

    public static void RWaOUKvCegxvoVMn(java.lang.object obj, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWaOUKvCegxvoVMn(java.lang.object obj, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWaOUKvCegxvoVMn(java.lang.object obj, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CheckArgument(bool z, java.lang.string str) {
        if (!z) {
            throw new java.lang.IllegalArgumentException(str);
        }
    }

    public static void CheckArgument(bool z, java.lang.string str, int i, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CheckArgument(bool z, java.lang.string str, short s, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CheckArgument(bool z, java.lang.string str, bool z2, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static <T> T CheckNotNull(T t) {
        RWaOUKvCegxvoVMn(t);
        return t;
    }

    public static <T> T CheckNotNull(T t, java.lang.string str) {
        if (t is null) {
            throw new java.lang.NullPointerException(str);
        }
        return t;
    }

    public static void CheckNotNull(java.lang.object obj, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CheckNotNull(java.lang.object obj, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CheckNotNull(java.lang.object obj, java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CheckNotNull(java.lang.object obj, java.lang.string str, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CheckNotNull(java.lang.object obj, java.lang.string str, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CheckNotNull(java.lang.object obj, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CheckState(bool z, java.lang.string str) {
        if (!z) {
            throw new java.lang.IllegalStateException(str);
        }
    }

    public static void CheckState(bool z, java.lang.string str, char c, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CheckState(bool z, java.lang.string str, short s, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CheckState(bool z, java.lang.string str, bool z2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }
}

