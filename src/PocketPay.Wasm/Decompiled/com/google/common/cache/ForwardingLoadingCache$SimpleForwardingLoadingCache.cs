namespace WillowMaze.Wasm.Decompiled;


public abstract class ForwardingLoadingCache$SimpleForwardingLoadingCache<K, V> : com.google.common.cache.ForwardingLoadingCache<K, V> {
    private readonly com.google.common.cache.LoadingCache<K, V> delegate;

    protected ForwardingLoadingCache$SimpleForwardingLoadingCache(com.google.common.cache.LoadingCache<K, V> loadingCache) {
        this.delegate = (com.google.common.cache.LoadingCache) com.google.common.base.Preconditions.checkNotNull(loadingCache);
    }

    protected override com.google.common.cache.Cache Delegate() {
        return delegate();
    }

    protected override readonly com.google.common.cache.LoadingCache<K, V> Delegate() {
        return this.delegate;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }
}

