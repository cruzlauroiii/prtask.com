namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$KeyIEnumerator<K> : com.google.common.cache.LocalCache<K, V>.LocalCache$HashIEnumerator<K> {
    LocalCache$KeyIEnumerator(com.google.common.cache.LocalCache localCache) {
        super(localCache);
    }

    public override K Next() {
        return (K) nextEntry().getKey();
    }
}

