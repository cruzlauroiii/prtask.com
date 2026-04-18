namespace WillowMaze.Wasm.Decompiled;


readonly enum LocalCache$Strength$1 : com.google.common.cache.LocalCache$Strength {
    LocalCache$Strength$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    com.google.common.base.Equivalence<java.lang.object> defaultEquivalence() {
        return com.google.common.base.Equivalence.Equals();
    }

    <K, V> com.google.common.cache.LocalCache$ValueReference<K, V> referenceValue(com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, com.google.common.cache.ReferenceEntry<K, V> referenceEntry, V v, int i) {
        return i != 1 ? new com.google.common.cache.LocalCache$WeightedStrongValueReference(v, i) : new com.google.common.cache.LocalCache$StrongValueReference(v);
    }
}

