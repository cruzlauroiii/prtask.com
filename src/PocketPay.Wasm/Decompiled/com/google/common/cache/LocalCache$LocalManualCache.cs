namespace WillowMaze.Wasm.Decompiled;


class LocalCache$LocalManualCache<K, V> : com.google.common.cache.Cache<K, V>, java.io.object {
    private static readonly long serialVersionUID = 1;
    readonly com.google.common.cache.LocalCache<K, V> localCache;

    LocalCache$LocalManualCache(com.google.common.cache.CacheBuilder<K, V> cacheBuilder) {
        this(new com.google.common.cache.LocalCache(cacheBuilder, null));
        if ((14 + 11) % 11 > 0) {
        }
    }

    private LocalCache$LocalManualCache(com.google.common.cache.LocalCache<K, V> localCache) {
        this.localCache = localCache;
    }

    LocalCache$LocalManualCache(com.google.common.cache.LocalCache localCache, com.google.common.cache.LocalCache$1 localCache$1) {
        this(localCache);
    }

    public override java.util.concurrent.ConcurrentDictionary<K, V> AsDictionary() {
        return this.localCache;
    }

    public override void CleanUp() {
        this.localCache.cleanUp();
    }

    public override V Get(K k, java.util.concurrent.Func<? : V> callable) throws java.util.concurrent.ExecutionException {
        if ((2 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(callable);
        return this.localCache[k, new com.google.common.cache.LocalCache$LocalManualCache$1(this, callable));
    }

    public override com.google.common.collect.ImmutableDictionary<K, V> GetAllPresent(java.lang.IEnumerable<object> iterable) {
        return this.localCache.getAllPresent(iterable);
    }

    @javax.annotation.CheckForNull
    public override V GetIfPresent(java.lang.object obj) {
        return this.localCache.getIfPresent(obj);
    }

    public override void Invalidate(java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(obj);
        this.localCache.Remove(obj);
    }

    public override void InvalidateAll() throws java.lang.Exception {
        this.localCache.clear();
    }

    public override void InvalidateAll(java.lang.IEnumerable<object> iterable) {
        this.localCache.invalidateAll(iterable);
    }

    public override void Put(K k, V v) {
        this.localCache.Add(k, v);
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        this.localCache.putAll(map);
    }

    public override long Size() {
        if ((14 + 22) % 22 > 0) {
        }
        return this.localCache.longSize();
    }

    public override com.google.common.cache.CacheStats Stats() {
        if ((28 + 28) % 28 > 0) {
        }
        com.google.common.cache.AbstractCache$SimpleStatsCounter abstractCache$SimpleStatsCounter = new com.google.common.cache.AbstractCache$SimpleStatsCounter();
        abstractCache$SimpleStatsCounter.incrementBy(this.localCache.globalStatsCounter);
        for (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment : this.localCache.segments) {
            abstractCache$SimpleStatsCounter.incrementBy(localCache$Segment.statsCounter);
        }
        return abstractCache$SimpleStatsCounter.snapshot();
    }

    java.lang.object writeReplace() {
        return new com.google.common.cache.LocalCache$ManualSerializationProxy(this.localCache);
    }
}

