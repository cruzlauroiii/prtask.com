namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry$Helper<K> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<K>> {
    private static readonly com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry$Helper<object> INSTANCE = new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry$Helper<>();

    DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry$Helper() {
    }

    static <K> com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry$Helper<K> instance() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry$Helper<K>) INSTANCE;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry copy(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry2) {
        return copy((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry) mapMakerInternalDictionary$InternalEntry, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry) mapMakerInternalDictionary$InternalEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> copy(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<K> mapMakerInternalDictionary$StrongKeyDummyValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> mapMakerInternalDictionary$StrongKeyDummyValueEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> mapMakerInternalDictionary$StrongKeyDummyValueEntry2) {
        return mapMakerInternalDictionary$StrongKeyDummyValueEntry.copy(mapMakerInternalDictionary$StrongKeyDummyValueEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG;
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, java.lang.object obj, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return newEntry((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<java.lang.object>) mapMakerInternalDictionary$Segment, obj, i, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<java.lang.object>) mapMakerInternalDictionary$InternalEntry);
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<K> mapMakerInternalDictionary$StrongKeyDummyValueSegment, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> mapMakerInternalDictionary$StrongKeyDummyValueEntry) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<>(k, i, mapMakerInternalDictionary$StrongKeyDummyValueEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Segment newSegment(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary, int i, int i2) {
        return newSegment(mapMakerInternalDictionary, i, i2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<K> newSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<K>> mapMakerInternalDictionary, int i, int i2) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<>(mapMakerInternalDictionary, i, i2);
    }

    public override void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, com.google.common.collect.DictionaryMaker$Dummy mapMaker$Dummy) {
        setValue((com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry) mapMakerInternalDictionary$InternalEntry, mapMaker$Dummy);
    }

    public void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueSegment<K> mapMakerInternalDictionary$StrongKeyDummyValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> mapMakerInternalDictionary$StrongKeyDummyValueEntry, com.google.common.collect.DictionaryMaker$Dummy mapMaker$Dummy) {
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG;
    }
}

