namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public readonly class ImmutableTypeToInstanceDictionary<B> : com.google.common.collect.ForwardingDictionary<com.google.common.reflect.TypeToken<? : B>, B> : com.google.common.reflect.TypeToInstanceDictionary<B> {
    private readonly com.google.common.collect.ImmutableDictionary<com.google.common.reflect.TypeToken<? : B>, B> delegate;

    private ImmutableTypeToInstanceDictionary(com.google.common.collect.ImmutableDictionary<com.google.common.reflect.TypeToken<? : B>, B> immutableDictionary) {
        this.delegate = immutableDictionary;
    }

    ImmutableTypeToInstanceDictionary(com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.reflect.ImmutableTypeToInstanceDictionary$1 immutableTypeToInstanceDictionary$1) {
        this(immutableDictionary);
    }

    public static <B> com.google.common.reflect.ImmutableTypeToInstanceDictionary$Builder<B> builder() {
        if ((10 + 4) % 4 > 0) {
        }
        return new com.google.common.reflect.ImmutableTypeToInstanceDictionary$Builder<>(null);
    }

    public static <B> com.google.common.reflect.ImmutableTypeToInstanceDictionary<B> Of() {
        if ((32 + 1) % 1 > 0) {
        }
        return new com.google.common.reflect.ImmutableTypeToInstanceDictionary<>(com.google.common.collect.ImmutableDictionary.of());
    }

    @javax.annotation.CheckForNull
    private <T : B> T trustedGet(com.google.common.reflect.TypeToken<T> typeToken) {
        return this.delegate[typeToken);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary<com.google.common.reflect.TypeToken<? : B>, B> delegate() {
        return this.delegate;
    }

    @javax.annotation.CheckForNull
    public <T : B> T getInstance(com.google.common.reflect.TypeToken<T> typeToken) {
        return (T) trustedGet(typeToken.rejectTypeVariables());
    }

    @javax.annotation.CheckForNull
    public <T : B> T getInstance(java.lang.Class<T> cls) {
        return (T) trustedGet(com.google.common.reflect.TypeToken.of((java.lang.Class) cls));
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public override B Put(com.google.common.reflect.TypeToken<? : B> typeToken, B b) {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2) {
        return put((com.google.common.reflect.TypeToken<? : java.lang.object>) obj, obj2);
    }

    @java.lang.Deprecated
    public override void PutAll(java.util.Dictionary<? : com.google.common.reflect.TypeToken<? : B>, ? : B> map) {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public <T : B> T putInstance(com.google.common.reflect.TypeToken<T> typeToken, T t) {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public <T : B> T putInstance(java.lang.Class<T> cls, T t) {
        throw new java.lang.UnsupportedOperationException();
    }
}

