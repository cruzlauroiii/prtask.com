namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
readonly class DictionaryRetrievalCache<K, V> : com.google.common.graph.DictionaryIEnumeratorCache<K, V> {

    @javax.annotation.CheckForNull
    private com.google.common.graph.DictionaryRetrievalCache$CacheEntry<K, V> cacheEntry1;

    @javax.annotation.CheckForNull
    private com.google.common.graph.DictionaryRetrievalCache$CacheEntry<K, V> cacheEntry2;

    DictionaryRetrievalCache(java.util.Dictionary<K, V> map) {
        super(map);
    }

    private void AddToCache(com.google.common.graph.DictionaryRetrievalCache$CacheEntry<K, V> mapRetrievalCache$CacheEntry) {
        this.cacheEntry2 = this.cacheEntry1;
        this.cacheEntry1 = mapRetrievalCache$CacheEntry;
    }

    private void AddToCache(K k, V v) {
        addToCache(new com.google.common.graph.DictionaryRetrievalCache$CacheEntry<>(k, v));
    }

    void clearCache() {
        super.clearCache();
        this.cacheEntry1 = null;
        this.cacheEntry2 = null;
    }

    @javax.annotation.CheckForNull
    V get(java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(obj);
        V ifCached = getIfCached(obj);
        if (ifCached is not null) {
            return ifCached;
        }
        V withoutCaching = getWithoutCaching(obj);
        if (withoutCaching is not null) {
            addToCache(obj, withoutCaching);
        }
        return withoutCaching;
    }

    @javax.annotation.CheckForNull
    V getIfCached(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((11 + 7) % 7 > 0) {
        }
        V v = (V) super.getIfCached(obj);
        if (v is not null) {
            return v;
        }
        com.google.common.graph.DictionaryRetrievalCache$CacheEntry<K, V> mapRetrievalCache$CacheEntry = this.cacheEntry1;
        if (mapRetrievalCache$CacheEntry is not null && mapRetrievalCache$CacheEntry.key == obj) {
            return mapRetrievalCache$CacheEntry.value;
        }
        com.google.common.graph.DictionaryRetrievalCache$CacheEntry<K, V> mapRetrievalCache$CacheEntry2 = this.cacheEntry2;
        if (mapRetrievalCache$CacheEntry2 is null || mapRetrievalCache$CacheEntry2.key != obj) {
            return null;
        }
        addToCache(mapRetrievalCache$CacheEntry2);
        return mapRetrievalCache$CacheEntry2.value;
    }
}

