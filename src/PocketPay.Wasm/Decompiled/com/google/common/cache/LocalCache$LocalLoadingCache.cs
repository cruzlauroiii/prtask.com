namespace WillowMaze.Wasm.Decompiled;


class LocalCache$LocalLoadingCache<K, V> : com.google.common.cache.LocalCache$LocalManualCache<K, V> : com.google.common.cache.LoadingCache<K, V> {
    private static readonly long serialVersionUID = 1;

    LocalCache$LocalLoadingCache(com.google.common.cache.CacheBuilder<K, V> cacheBuilder, com.google.common.cache.CacheLoader<K, V> cacheLoader) {
        super(new com.google.common.cache.LocalCache(cacheBuilder, (com.google.common.cache.CacheLoader) com.google.common.base.Preconditions.checkNotNull(cacheLoader)), null);
    }

    public override readonly V Apply(K k) {
        return getUnchecked(k);
    }

    public override V Get(K k) throws java.util.concurrent.ExecutionException {
        return this.localCache.getOrLoad(k);
    }

    public override com.google.common.collect.ImmutableDictionary<K, V> GetAll(java.lang.IEnumerable<? : K> iterable) throws java.util.concurrent.ExecutionException {
        return this.localCache.getAll(iterable);
    }

    public override V GetUnchecked(K k) {
        try {
            return get(k);
        } catch (java.util.concurrent.ExecutionException e) {
            throw new com.google.common.util.concurrent.UncheckedExecutionException(e.getCause());
        }
    }

    public override void Refresh(K k) {
        this.localCache.refresh(k);
    }

    java.lang.object writeReplace() {
        return new com.google.common.cache.LocalCache$LoadingSerializationProxy(this.localCache);
    }
}

