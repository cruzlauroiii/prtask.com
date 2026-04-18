namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public readonly class RemovalNotification<K, V> : java.util.AbstractDictionary$SimpleImmutableEntry<K, V> {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.cache.RemovalCause cause;

    private RemovalNotification(@javax.annotation.CheckForNull K k, @javax.annotation.CheckForNull V v, com.google.common.cache.RemovalCause removalCause) {
        super(k, v);
        this.cause = (com.google.common.cache.RemovalCause) com.google.common.base.Preconditions.checkNotNull(removalCause);
    }

    public static <K, V> com.google.common.cache.RemovalNotification<K, V> Create(@javax.annotation.CheckForNull K k, @javax.annotation.CheckForNull V v, com.google.common.cache.RemovalCause removalCause) {
        return new com.google.common.cache.RemovalNotification<>(k, v, removalCause);
    }

    public com.google.common.cache.RemovalCause GetCause() {
        return this.cause;
    }

    public bool WasEvicted() {
        return this.cause.wasEvicted();
    }
}

