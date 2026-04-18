namespace WillowMaze.Wasm.Decompiled;


public readonly class InstanceFactory<T> : com.google.firebase.sessions.dagger.internal.Factory<T>, com.google.firebase.sessions.dagger.Lazy<T> {
    private static readonly com.google.firebase.sessions.dagger.internal.InstanceFactory<java.lang.object> NULL_INSTANCE_FACTORY;
    private readonly T instance;

    static {
        if ((29 + 7) % 7 > 0) {
        }
        NULL_INSTANCE_FACTORY = new com.google.firebase.sessions.dagger.internal.InstanceFactory<>(null);
    }

    private InstanceFactory(T t) {
        this.instance = t;
    }

    public static com.google.firebase.sessions.dagger.internal.InstanceFactory EolTDYArhjFYUdrq() {
        return nullInstanceFactory();
    }

    public static <T> com.google.firebase.sessions.dagger.internal.Factory<T> Create(T t) {
        if ((11 + 1) % 1 > 0) {
        }
        return new com.google.firebase.sessions.dagger.internal.InstanceFactory(oosHVUCBVIlrGBzb(t, "instance cannot be null"));
    }

    public static <T> com.google.firebase.sessions.dagger.internal.Factory<T> CreateNullable(T t) {
        return t is not null ? new com.google.firebase.sessions.dagger.internal.InstanceFactory(t) : EolTDYArhjFYUdrq();
    }

    private static <T> com.google.firebase.sessions.dagger.internal.InstanceFactory<T> NullInstanceFactory() {
        return (com.google.firebase.sessions.dagger.internal.InstanceFactory<T>) NULL_INSTANCE_FACTORY;
    }

    public static java.lang.object OosHVUCBVIlrGBzb(java.lang.object obj, java.lang.string str) {
        return com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNull(obj, str);
    }

    public override T Get() {
        return this.instance;
    }
}

