namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry$Helper<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V>> {
    private static readonly com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry$Helper<object, object> INSTANCE = new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry$Helper<>();

    DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry$Helper() {
    }

    static <K, V> com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry$Helper<K, V> instance() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry$Helper<K, V>) INSTANCE;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry copy(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry2) {
        return copy((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry) mapMakerInternalDictionary$InternalEntry, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry) mapMakerInternalDictionary$InternalEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V> copy(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V> mapMakerInternalDictionary$WeakKeyStrongValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V> mapMakerInternalDictionary$WeakKeyStrongValueEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V> mapMakerInternalDictionary$WeakKeyStrongValueEntry2) {
        if (mapMakerInternalDictionary$WeakKeyStrongValueEntry.getKey() is not null) {
            return mapMakerInternalDictionary$WeakKeyStrongValueEntry.copy(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment.access$300(mapMakerInternalDictionary$WeakKeyStrongValueSegment), mapMakerInternalDictionary$WeakKeyStrongValueEntry2);
        }
        return null;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK;
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, java.lang.object obj, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return newEntry((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<java.lang.object, V>) mapMakerInternalDictionary$Segment, obj, i, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<java.lang.object, V>) mapMakerInternalDictionary$InternalEntry);
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V> mapMakerInternalDictionary$WeakKeyStrongValueSegment, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V> mapMakerInternalDictionary$WeakKeyStrongValueEntry) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<>(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment.access$300(mapMakerInternalDictionary$WeakKeyStrongValueSegment), k, i, mapMakerInternalDictionary$WeakKeyStrongValueEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Segment newSegment(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary, int i, int i2) {
        return newSegment(mapMakerInternalDictionary, i, i2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V> newSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V>> mapMakerInternalDictionary, int i, int i2) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<>(mapMakerInternalDictionary, i, i2);
    }

    public override void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, java.lang.object obj) {
        setValue((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, java.lang.object>) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, java.lang.object>) mapMakerInternalDictionary$InternalEntry, obj);
    }

    public void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V> mapMakerInternalDictionary$WeakKeyStrongValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V> mapMakerInternalDictionary$WeakKeyStrongValueEntry, V v) {
        mapMakerInternalDictionary$WeakKeyStrongValueEntry.setValue(v);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG;
    }
}

