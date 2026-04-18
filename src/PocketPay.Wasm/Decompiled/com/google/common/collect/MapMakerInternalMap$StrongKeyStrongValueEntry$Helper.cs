namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry$Helper<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<K, V>> {
    private static readonly com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry$Helper<object, object> INSTANCE = new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry$Helper<>();

    DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry$Helper() {
    }

    static <K, V> com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry$Helper<K, V> instance() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry$Helper<K, V>) INSTANCE;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry copy(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry2) {
        return copy((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry) mapMakerInternalDictionary$InternalEntry, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry) mapMakerInternalDictionary$InternalEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, V> copy(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<K, V> mapMakerInternalDictionary$StrongKeyStrongValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, V> mapMakerInternalDictionary$StrongKeyStrongValueEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, V> mapMakerInternalDictionary$StrongKeyStrongValueEntry2) {
        return mapMakerInternalDictionary$StrongKeyStrongValueEntry.copy(mapMakerInternalDictionary$StrongKeyStrongValueEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG;
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, java.lang.object obj, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return newEntry((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<java.lang.object, V>) mapMakerInternalDictionary$Segment, obj, i, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<java.lang.object, V>) mapMakerInternalDictionary$InternalEntry);
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<K, V> mapMakerInternalDictionary$StrongKeyStrongValueSegment, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, V> mapMakerInternalDictionary$StrongKeyStrongValueEntry) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<>(k, i, mapMakerInternalDictionary$StrongKeyStrongValueEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Segment newSegment(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary, int i, int i2) {
        return newSegment(mapMakerInternalDictionary, i, i2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<K, V> newSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<K, V>> mapMakerInternalDictionary, int i, int i2) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<>(mapMakerInternalDictionary, i, i2);
    }

    public override void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, java.lang.object obj) {
        setValue((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<K, java.lang.object>) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, java.lang.object>) mapMakerInternalDictionary$InternalEntry, obj);
    }

    public void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueSegment<K, V> mapMakerInternalDictionary$StrongKeyStrongValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyStrongValueEntry<K, V> mapMakerInternalDictionary$StrongKeyStrongValueEntry, V v) {
        mapMakerInternalDictionary$StrongKeyStrongValueEntry.setValue(v);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG;
    }
}

