namespace WillowMaze.Wasm.Decompiled;


readonly class pe93acb14$p50c0a87f<T, U> : io.reactivex.rxjava3.functions.Predicate<T> {
    readonly java.lang.Class<U> f2add2733;
    readonly java.lang.Class ff4eb4eeb;

    pe93acb14$p50c0a87f(java.lang.Class<U> cls) {
        this.f2add2733 = cls;
    }

    public static void NYVeOkWYvpEAajOJ(java.lang.Class cls, java.lang.object obj, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NYVeOkWYvpEAajOJ(java.lang.Class cls, java.lang.object obj, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NYVeOkWYvpEAajOJ(java.lang.Class cls, java.lang.object obj, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NYVeOkWYvpEAajOJ(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public bool Test(T t) {
        return NYVeOkWYvpEAajOJ(this.f2add2733, t);
    }
}

