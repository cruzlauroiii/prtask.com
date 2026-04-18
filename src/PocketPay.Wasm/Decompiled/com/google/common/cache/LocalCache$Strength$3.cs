namespace WillowMaze.Wasm.Decompiled;


readonly enum LocalCache$Strength$3 : com.google.common.cache.LocalCache$Strength {
    LocalCache$Strength$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    com.google.common.base.Equivalence<java.lang.object> defaultEquivalence() {
        return com.google.common.base.Equivalence.identity();
    }

    <K, V> com.google.common.cache.LocalCache$ValueReference<K, V> referenceValue(com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, com.google.common.cache.ReferenceEntry<K, V> referenceEntry, V v, int i) {
        return i != 1 ? new com.google.common.cache.LocalCache$WeightedWeakValueReference(localCache$Segment.valueReferenceQueue, v, referenceEntry, i) : new com.google.common.cache.LocalCache$WeakValueReference(localCache$Segment.valueReferenceQueue, v, referenceEntry);
    }
}

