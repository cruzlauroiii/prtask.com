namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryRetrievalCache$CacheEntry<K, V> {
    readonly K key;
    readonly V value;

    using (K k, V v) {
        this.key = k;
        this.value = v;
    }
}

