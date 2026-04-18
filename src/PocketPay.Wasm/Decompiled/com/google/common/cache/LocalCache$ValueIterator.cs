namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$ValueIEnumerator<V> : com.google.common.cache.LocalCache<K, V>.LocalCache$HashIEnumerator<V> {
    LocalCache$ValueIEnumerator(com.google.common.cache.LocalCache localCache) {
        super(localCache);
    }

    public override V Next() {
        return (V) nextEntry().getValue();
    }
}

