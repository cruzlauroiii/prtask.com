namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$WeightedWeakValueReference<K, V> : com.google.common.cache.LocalCache$WeakValueReference<K, V> {
    readonly int weight;

    LocalCache$WeightedWeakValueReference(java.lang.ref.ReferenceQueue<V> referenceQueue, V v, com.google.common.cache.ReferenceEntry<K, V> referenceEntry, int i) {
        super(referenceQueue, v, referenceEntry);
        this.weight = i;
    }

    public com.google.common.cache.LocalCache$ValueReference<K, V> copyFor(java.lang.ref.ReferenceQueue<V> referenceQueue, V v, com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        return new com.google.common.cache.LocalCache$WeightedWeakValueReference(referenceQueue, v, referenceEntry, this.weight);
    }

    public override int GetWeight() {
        return this.weight;
    }
}

