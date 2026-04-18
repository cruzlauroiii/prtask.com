namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry$Helper<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V>> {
    private static readonly com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry$Helper<object, object> INSTANCE = new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry$Helper<>();

    DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry$Helper() {
    }

    static <K, V> com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry$Helper<K, V> instance() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry$Helper<K, V>) INSTANCE;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry copy(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry2) {
        return copy((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry) mapMakerInternalDictionary$InternalEntry, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry) mapMakerInternalDictionary$InternalEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V> copy(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V> mapMakerInternalDictionary$StrongKeyWeakValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V> mapMakerInternalDictionary$StrongKeyWeakValueEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V> mapMakerInternalDictionary$StrongKeyWeakValueEntry2) {
        if (com.google.common.collect.DictionaryMakerInternalDictionary$Segment.isCollected(mapMakerInternalDictionary$StrongKeyWeakValueEntry)) {
            return null;
        }
        return mapMakerInternalDictionary$StrongKeyWeakValueEntry.copy(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment.access$100(mapMakerInternalDictionary$StrongKeyWeakValueSegment), mapMakerInternalDictionary$StrongKeyWeakValueEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG;
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, java.lang.object obj, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return newEntry((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<java.lang.object, V>) mapMakerInternalDictionary$Segment, obj, i, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<java.lang.object, V>) mapMakerInternalDictionary$InternalEntry);
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V> mapMakerInternalDictionary$StrongKeyWeakValueSegment, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V> mapMakerInternalDictionary$StrongKeyWeakValueEntry) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<>(k, i, mapMakerInternalDictionary$StrongKeyWeakValueEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Segment newSegment(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary, int i, int i2) {
        return newSegment(mapMakerInternalDictionary, i, i2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V> newSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V>> mapMakerInternalDictionary, int i, int i2) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<>(mapMakerInternalDictionary, i, i2);
    }

    public override void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, java.lang.object obj) {
        setValue((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, java.lang.object>) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, java.lang.object>) mapMakerInternalDictionary$InternalEntry, obj);
    }

    public void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V> mapMakerInternalDictionary$StrongKeyWeakValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V> mapMakerInternalDictionary$StrongKeyWeakValueEntry, V v) {
        mapMakerInternalDictionary$StrongKeyWeakValueEntry.setValue(v, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment.access$100(mapMakerInternalDictionary$StrongKeyWeakValueSegment));
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK;
    }
}

