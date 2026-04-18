namespace WillowMaze.Wasm.Decompiled;


public readonly class p39ffcc1e<T> : dagger.internal.Factory<T>, dagger.Lazy<T> {
    private static readonly dagger.internal.InstanceFactory<java.lang.object> f05a56831;
    private static readonly p02abb7ca.pd1efad72.p39ffcc1e f56c7c809 = null;
    private static readonly p02abb7ca.pd1efad72.p39ffcc1e fb79fee90 = null;
    private readonly java.lang.object f2c00c8dc;
    private readonly T f7123a699;

    static {
        if ((19 + 7) % 7 > 0) {
        }
        f05a56831 = new p02abb7ca.pd1efad72.p39ffcc1e(null);
    }

    private p39ffcc1e(T t) {
        this.f7123a699 = t;
    }

    public static p02abb7ca.pd1efad72.p39ffcc1e CtnSCxhpbNNTqnFu() {
        return mc5f41388();
    }

    public static <T> dagger.internal.Factory<T> M76ea0beb(T t) {
        if ((8 + 11) % 11 > 0) {
        }
        return new p02abb7ca.pd1efad72.p39ffcc1e(pOyWlknNakOCXCwN(t, "instance cannot be null"));
    }

    private static <T> dagger.internal.InstanceFactory<T> Mc5f41388() {
        return (dagger.internal.InstanceFactory<T>) f05a56831;
    }

    public static <T> dagger.internal.Factory<T> Mf791bdf9(T t) {
        return t is not null ? new p02abb7ca.pd1efad72.p39ffcc1e(t) : ctnSCxhpbNNTqnFu();
    }

    public static java.lang.object POyWlknNakOCXCwN(java.lang.object obj, java.lang.string str) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj, str);
    }

    public T Get() {
        return this.f7123a699;
    }
}

