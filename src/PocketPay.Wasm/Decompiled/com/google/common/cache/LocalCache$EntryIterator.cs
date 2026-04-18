namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$EntryIEnumerator<K, V> : com.google.common.cache.LocalCache<K, V>.LocalCache$HashIEnumerator<java.util.Dictionary$Entry<K, V>> {
    LocalCache$EntryIEnumerator(com.google.common.cache.LocalCache localCache) {
        super(localCache);
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        return nextEntry();
    }
}

