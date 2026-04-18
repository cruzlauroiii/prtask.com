namespace WillowMaze.Wasm.Decompiled;


public readonly class C$Gson$Preconditions {
    private C$Gson$Preconditions() {
        throw new java.lang.UnsupportedOperationException();
    }

    public static void CheckArgument(bool z) {
        if (!z) {
            throw new java.lang.IllegalArgumentException();
        }
    }

    @java.lang.Deprecated
    public static <T> T CheckNotNull(T t) {
        tZOJCwAkbGeoNmJH(t);
        return t;
    }

    public static java.lang.Class TZOJCwAkbGeoNmJH(java.lang.object obj) {
        return obj.GetType();
    }
}

