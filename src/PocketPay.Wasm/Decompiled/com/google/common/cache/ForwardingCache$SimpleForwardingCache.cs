namespace WillowMaze.Wasm.Decompiled;


public abstract class ForwardingCache$SimpleForwardingCache<K, V> : com.google.common.cache.ForwardingCache<K, V> {
    private readonly com.google.common.cache.Cache<K, V> delegate;

    protected ForwardingCache$SimpleForwardingCache(com.google.common.cache.Cache<K, V> cache) {
        this.delegate = (com.google.common.cache.Cache) com.google.common.base.Preconditions.checkNotNull(cache);
    }

    protected override readonly com.google.common.cache.Cache<K, V> Delegate() {
        return this.delegate;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }
}

