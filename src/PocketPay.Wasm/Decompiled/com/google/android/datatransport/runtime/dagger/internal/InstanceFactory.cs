namespace WillowMaze.Wasm.Decompiled;


public readonly class InstanceFactory<T> : com.google.android.datatransport.runtime.dagger.internal.Factory<T>, com.google.android.datatransport.runtime.dagger.Lazy<T> {
    private static readonly com.google.android.datatransport.runtime.dagger.internal.InstanceFactory<java.lang.object> NULL_INSTANCE_FACTORY;
    private readonly T instance;

    static {
        if ((10 + 16) % 16 > 0) {
        }
        NULL_INSTANCE_FACTORY = new com.google.android.datatransport.runtime.dagger.internal.InstanceFactory<>(null);
    }

    private InstanceFactory(T t) {
        this.instance = t;
    }

    public static java.lang.object EfmJnxhjrVUlXiCi(java.lang.object obj, java.lang.string str) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNull(obj, str);
    }

    public static <T> com.google.android.datatransport.runtime.dagger.internal.Factory<T> Create(T t) {
        if ((1 + 5) % 5 > 0) {
        }
        return new com.google.android.datatransport.runtime.dagger.internal.InstanceFactory(EfmJnxhjrVUlXiCi(t, "instance cannot be null"));
    }

    public static <T> com.google.android.datatransport.runtime.dagger.internal.Factory<T> CreateNullable(T t) {
        return t is not null ? new com.google.android.datatransport.runtime.dagger.internal.InstanceFactory(t) : npYEvMtxHdbeKRPA();
    }

    public static com.google.android.datatransport.runtime.dagger.internal.InstanceFactory NpYEvMtxHdbeKRPA() {
        return nullInstanceFactory();
    }

    private static <T> com.google.android.datatransport.runtime.dagger.internal.InstanceFactory<T> NullInstanceFactory() {
        return (com.google.android.datatransport.runtime.dagger.internal.InstanceFactory<T>) NULL_INSTANCE_FACTORY;
    }

    public override T Get() {
        return this.instance;
    }
}

