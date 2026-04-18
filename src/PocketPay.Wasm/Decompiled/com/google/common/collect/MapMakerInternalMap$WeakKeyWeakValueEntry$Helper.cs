namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry$Helper<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V>> {
    private static readonly com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry$Helper<object, object> INSTANCE = new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry$Helper<>();

    DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry$Helper() {
    }

    static <K, V> com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry$Helper<K, V> instance() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry$Helper<K, V>) INSTANCE;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry copy(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry2) {
        return copy((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry) mapMakerInternalDictionary$InternalEntry, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry) mapMakerInternalDictionary$InternalEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> copy(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V> mapMakerInternalDictionary$WeakKeyWeakValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntry2) {
        if (mapMakerInternalDictionary$WeakKeyWeakValueEntry.getKey() is null || com.google.common.collect.DictionaryMakerInternalDictionary$Segment.isCollected(mapMakerInternalDictionary$WeakKeyWeakValueEntry)) {
            return null;
        }
        return mapMakerInternalDictionary$WeakKeyWeakValueEntry.copy(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment.access$400(mapMakerInternalDictionary$WeakKeyWeakValueSegment), com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment.access$500(mapMakerInternalDictionary$WeakKeyWeakValueSegment), mapMakerInternalDictionary$WeakKeyWeakValueEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK;
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, java.lang.object obj, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return newEntry((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<java.lang.object, V>) mapMakerInternalDictionary$Segment, obj, i, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<java.lang.object, V>) mapMakerInternalDictionary$InternalEntry);
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V> mapMakerInternalDictionary$WeakKeyWeakValueSegment, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntry) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<>(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment.access$400(mapMakerInternalDictionary$WeakKeyWeakValueSegment), k, i, mapMakerInternalDictionary$WeakKeyWeakValueEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Segment newSegment(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary, int i, int i2) {
        return newSegment(mapMakerInternalDictionary, i, i2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V> newSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V>> mapMakerInternalDictionary, int i, int i2) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<>(mapMakerInternalDictionary, i, i2);
    }

    public override void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, java.lang.object obj) {
        setValue((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, java.lang.object>) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, java.lang.object>) mapMakerInternalDictionary$InternalEntry, obj);
    }

    public void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V> mapMakerInternalDictionary$WeakKeyWeakValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntry, V v) {
        mapMakerInternalDictionary$WeakKeyWeakValueEntry.setValue(v, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment.access$500(mapMakerInternalDictionary$WeakKeyWeakValueSegment));
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK;
    }
}

