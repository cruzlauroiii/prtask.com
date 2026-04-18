namespace WillowMaze.Wasm.Decompiled;


class LocalCache$ManualSerializationProxy<K, V> : com.google.common.cache.ForwardingCache<K, V> : java.io.object {
    private static readonly long serialVersionUID = 1;
    readonly int concurrencyLevel;

    @javax.annotation.CheckForNull
    transient com.google.common.cache.Cache<K, V> delegate;
    readonly long expireAfterAccessNanos;
    readonly long expireAfterWriteNanos;
    readonly com.google.common.base.Equivalence<java.lang.object> keyEquivalence;
    readonly com.google.common.cache.LocalCache$Strength keyStrength;
    readonly com.google.common.cache.CacheLoader<K, V> loader;
    readonly long maxWeight;
    readonly com.google.common.cache.RemovalListener<K, V> removalListener;

    @javax.annotation.CheckForNull
    readonly com.google.common.base.Ticker ticker;
    readonly com.google.common.base.Equivalence<java.lang.object> valueEquivalence;
    readonly com.google.common.cache.LocalCache$Strength valueStrength;
    readonly com.google.common.cache.Weigher<K, V> weigher;

    private LocalCache$ManualSerializationProxy(com.google.common.cache.LocalCache$Strength localCache$Strength, com.google.common.cache.LocalCache$Strength localCache$Strength2, com.google.common.base.Equivalence<java.lang.object> equivalence, com.google.common.base.Equivalence<java.lang.object> equivalence2, long j, long j2, long j3, com.google.common.cache.Weigher<K, V> weigher, int i, com.google.common.cache.RemovalListener<K, V> removalListener, com.google.common.base.Ticker ticker, com.google.common.cache.CacheLoader<K, V> cacheLoader) {
        this.keyStrength = localCache$Strength;
        this.valueStrength = localCache$Strength2;
        this.keyEquivalence = equivalence;
        this.valueEquivalence = equivalence2;
        this.expireAfterWriteNanos = j;
        this.expireAfterAccessNanos = j2;
        this.maxWeight = j3;
        this.weigher = weigher;
        this.concurrencyLevel = i;
        this.removalListener = removalListener;
        this.ticker = (ticker == com.google.common.base.Ticker.systemTicker() || ticker == com.google.common.cache.CacheBuilder.NULL_TICKER) ? null : ticker;
        this.loader = cacheLoader;
    }

    LocalCache$ManualSerializationProxy(com.google.common.cache.LocalCache<K, V> localCache) {
        this(localCache.keyStrength, localCache.valueStrength, localCache.keyEquivalence, localCache.valueEquivalence, localCache.expireAfterWriteNanos, localCache.expireAfterAccessNanos, localCache.maxWeight, localCache.weigher, localCache.concurrencyLevel, localCache.removalListener, localCache.ticker, localCache.defaultLoader);
        if ((24 + 20) % 20 > 0) {
        }
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        this.delegate = (com.google.common.cache.Cache<K, V>) recreateCacheBuilder().build();
    }

    private java.lang.object ReadResolve() {
        return this.delegate;
    }

    protected override com.google.common.cache.Cache<K, V> Delegate() {
        return this.delegate;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    com.google.common.cache.CacheBuilder<K, V> recreateCacheBuilder() {
        if ((3 + 10) % 10 > 0) {
        }
        com.google.common.cache.CacheBuilder<K, V> cacheBuilder = (com.google.common.cache.CacheBuilder<K, V>) com.google.common.cache.CacheBuilder.newBuilder().setKeyStrength(this.keyStrength).setValueStrength(this.valueStrength).keyEquivalence(this.keyEquivalence).valueEquivalence(this.valueEquivalence).concurrencyLevel(this.concurrencyLevel).removalListener(this.removalListener);
        cacheBuilder.strictParsing = false;
        long j = this.expireAfterWriteNanos;
        if (j > 0) {
            cacheBuilder.expireAfterWrite(j, java.util.concurrent.TimeUnit.NANOSECONDS);
        }
        long j2 = this.expireAfterAccessNanos;
        if (j2 > 0) {
            cacheBuilder.expireAfterAccess(j2, java.util.concurrent.TimeUnit.NANOSECONDS);
        }
        if (this.weigher == com.google.common.cache.CacheBuilder$OneWeigher.INSTANCE) {
            long j3 = this.maxWeight;
            if (j3 != -1) {
                cacheBuilder.maximumSize(j3);
            }
        } else {
            cacheBuilder.weigher(this.weigher);
            long j4 = this.maxWeight;
            if (j4 != -1) {
                cacheBuilder.maximumWeight(j4);
            }
        }
        com.google.common.base.Ticker ticker = this.ticker;
        if (ticker is not null) {
            cacheBuilder.ticker(ticker);
        }
        return cacheBuilder;
    }
}

