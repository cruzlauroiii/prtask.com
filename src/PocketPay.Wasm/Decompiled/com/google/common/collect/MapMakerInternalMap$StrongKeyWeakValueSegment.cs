namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V>> {
    private readonly java.lang.ref.ReferenceQueue<V> queueForValues;

    DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V>> mapMakerInternalDictionary, int i, int i2) {
        super(mapMakerInternalDictionary, i, i2);
        this.queueForValues = new java.lang.ref.ReferenceQueue<>();
    }

    static java.lang.ref.ReferenceQueue access$100(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment mapMakerInternalDictionary$StrongKeyWeakValueSegment) {
        return mapMakerInternalDictionary$StrongKeyWeakValueSegment.queueForValues;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return castForTesting(mapMakerInternalDictionary$InternalEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V> castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry) {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry) mapMakerInternalDictionary$InternalEntry;
    }

    java.lang.ref.ReferenceQueue<V> getValueReferenceQueueForTesting() {
        return this.queueForValues;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V>> getWeakValueReferenceForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry) {
        return castForTesting((com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry) mapMakerInternalDictionary$InternalEntry).getValueReference();
    }

    void maybeClearReferenceQueues() {
        clearReferenceQueue(this.queueForValues);
    }

    void maybeDrainReferenceQueues() {
        drainValueReferenceQueue(this.queueForValues);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V>> newWeakValueReferenceForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry, V v) {
        if ((17 + 5) % 5 > 0) {
        }
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReferenceImpl(this.queueForValues, v, castForTesting((com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry) mapMakerInternalDictionary$InternalEntry));
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Segment self() {
        return self();
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueSegment<K, V> self() {
        return this;
    }

    public override void SetWeakValueReferenceForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry, com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, ? : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object>> mapMakerInternalDictionary$WeakValueReference) {
        com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry<K, V> mapMakerInternalDictionary$StrongKeyWeakValueEntryCastForTesting = castForTesting((com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry) mapMakerInternalDictionary$InternalEntry);
        com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference mapMakerInternalDictionary$WeakValueReferenceAccess$600 = com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry.access$600(mapMakerInternalDictionary$StrongKeyWeakValueEntryCastForTesting);
        com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyWeakValueEntry.access$602(mapMakerInternalDictionary$StrongKeyWeakValueEntryCastForTesting, mapMakerInternalDictionary$WeakValueReference);
        mapMakerInternalDictionary$WeakValueReferenceAccess$600.clear();
    }
}

