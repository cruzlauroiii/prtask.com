namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry$Helper<K> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntryHelper<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K>> {
    private static readonly com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry$Helper<object> INSTANCE = new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry$Helper<>();

    DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry$Helper() {
    }

    static <K> com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry$Helper<K> instance() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry$Helper<K>) INSTANCE;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry copy(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry2) {
        return copy((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry) mapMakerInternalDictionary$InternalEntry, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry) mapMakerInternalDictionary$InternalEntry2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> copy(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K> mapMakerInternalDictionary$WeakKeyDummyValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> mapMakerInternalDictionary$WeakKeyDummyValueEntry, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> mapMakerInternalDictionary$WeakKeyDummyValueEntry2) {
        if (mapMakerInternalDictionary$WeakKeyDummyValueEntry.getKey() is not null) {
            return mapMakerInternalDictionary$WeakKeyDummyValueEntry.copy(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment.access$200(mapMakerInternalDictionary$WeakKeyDummyValueSegment), mapMakerInternalDictionary$WeakKeyDummyValueEntry2);
        }
        return null;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK;
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, java.lang.object obj, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return newEntry((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<java.lang.object>) mapMakerInternalDictionary$Segment, obj, i, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<java.lang.object>) mapMakerInternalDictionary$InternalEntry);
    }

    using (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K> mapMakerInternalDictionary$WeakKeyDummyValueSegment, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> mapMakerInternalDictionary$WeakKeyDummyValueEntry) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<>(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment.access$200(mapMakerInternalDictionary$WeakKeyDummyValueSegment), k, i, mapMakerInternalDictionary$WeakKeyDummyValueEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Segment newSegment(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary, int i, int i2) {
        return newSegment(mapMakerInternalDictionary, i, i2);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K> newSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K>> mapMakerInternalDictionary, int i, int i2) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<>(mapMakerInternalDictionary, i, i2);
    }

    public override void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$Segment mapMakerInternalDictionary$Segment, com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry, com.google.common.collect.DictionaryMaker$Dummy mapMaker$Dummy) {
        setValue((com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment) mapMakerInternalDictionary$Segment, (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry) mapMakerInternalDictionary$InternalEntry, mapMaker$Dummy);
    }

    public void SetValue(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K> mapMakerInternalDictionary$WeakKeyDummyValueSegment, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> mapMakerInternalDictionary$WeakKeyDummyValueEntry, com.google.common.collect.DictionaryMaker$Dummy mapMaker$Dummy) {
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength() {
        return com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG;
    }
}

