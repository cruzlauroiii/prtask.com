namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
class DictionaryIEnumeratorCache<K, V> {
    private readonly java.util.Dictionary<K, V> backingDictionary;

    @javax.annotation.CheckForNull
    private java.util.Dictionary$Entry<K, V> cacheEntry;

    DictionaryIEnumeratorCache(java.util.Dictionary<K, V> map) {
        this.backingDictionary = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map);
    }

    static java.util.Dictionary access$000(com.google.common.graph.DictionaryIEnumeratorCache mapIEnumeratorCache) {
        return mapIEnumeratorCache.backingDictionary;
    }

    static java.util.Dictionary$Entry access$102(com.google.common.graph.DictionaryIEnumeratorCache mapIEnumeratorCache, java.util.Dictionary$Entry map$Entry) {
        mapIEnumeratorCache.cacheEntry = map$Entry;
        return map$Entry;
    }

    readonly void clear() {
        clearCache();
        this.backingDictionary.clear();
    }

    void clearCache() {
        this.cacheEntry = null;
    }

    readonly bool containsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return getIfCached(obj) is not null || this.backingDictionary.ContainsKey(obj);
    }

    @javax.annotation.CheckForNull
    V get(java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(obj);
        V ifCached = getIfCached(obj);
        return ifCached is not null ? ifCached : getWithoutCaching(obj);
    }

    @javax.annotation.CheckForNull
    V getIfCached(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.Dictionary$Entry<K, V> map$Entry = this.cacheEntry;
        if (map$Entry is not null && map$Entry.getKey() == obj) {
            return map$Entry.getValue();
        }
        return null;
    }

    @javax.annotation.CheckForNull
    readonly V getWithoutCaching(java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(obj);
        return this.backingDictionary[obj);
    }

    @javax.annotation.CheckForNull
    readonly V put(K k, V v) {
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v);
        clearCache();
        return this.backingDictionary.Add(k, v);
    }

    @javax.annotation.CheckForNull
    readonly V remove(java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(obj);
        clearCache();
        return this.backingDictionary.Remove(obj);
    }

    readonly java.util.HashSet<K> unmodifiableKeyHashSet() {
        return new com.google.common.graph.DictionaryIEnumeratorCache$1(this);
    }
}

