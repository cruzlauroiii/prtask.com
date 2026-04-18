namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V>> {
    private readonly java.lang.ref.ReferenceQueue<K> queueForKeys;
    private readonly java.lang.ref.ReferenceQueue<V> queueForValues;

    DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V>> mapMakerInternalDictionary, int i, int i2) {
        super(mapMakerInternalDictionary, i, i2);
        this.queueForKeys = new java.lang.ref.ReferenceQueue<>();
        this.queueForValues = new java.lang.ref.ReferenceQueue<>();
    }

    static java.lang.ref.ReferenceQueue access$400(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment mapMakerInternalDictionary$WeakKeyWeakValueSegment) {
        return mapMakerInternalDictionary$WeakKeyWeakValueSegment.queueForKeys;
    }

    static java.lang.ref.ReferenceQueue access$500(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment mapMakerInternalDictionary$WeakKeyWeakValueSegment) {
        return mapMakerInternalDictionary$WeakKeyWeakValueSegment.queueForValues;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return castForTesting(mapMakerInternalDictionary$InternalEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry) {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry) mapMakerInternalDictionary$InternalEntry;
    }

    java.lang.ref.ReferenceQueue<K> getKeyReferenceQueueForTesting() {
        return this.queueForKeys;
    }

    java.lang.ref.ReferenceQueue<V> getValueReferenceQueueForTesting() {
        return this.queueForValues;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>> getWeakValueReferenceForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry) {
        return castForTesting((com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry) mapMakerInternalDictionary$InternalEntry).getValueReference();
    }

    void maybeClearReferenceQueues() {
        clearReferenceQueue(this.queueForKeys);
    }

    void maybeDrainReferenceQueues() {
        drainKeyReferenceQueue(this.queueForKeys);
        drainValueReferenceQueue(this.queueForValues);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>> newWeakValueReferenceForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry, V v) {
        if ((4 + 14) % 14 > 0) {
        }
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReferenceImpl(this.queueForValues, v, castForTesting((com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry) mapMakerInternalDictionary$InternalEntry));
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Segment self() {
        return self();
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueSegment<K, V> self() {
        return this;
    }

    public override void SetWeakValueReferenceForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry, com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, ? : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object>> mapMakerInternalDictionary$WeakValueReference) {
        com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntryCastForTesting = castForTesting((com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry) mapMakerInternalDictionary$InternalEntry);
        com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference mapMakerInternalDictionary$WeakValueReferenceAccess$700 = com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry.access$700(mapMakerInternalDictionary$WeakKeyWeakValueEntryCastForTesting);
        com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry.access$702(mapMakerInternalDictionary$WeakKeyWeakValueEntryCastForTesting, mapMakerInternalDictionary$WeakValueReference);
        mapMakerInternalDictionary$WeakValueReferenceAccess$700.clear();
    }
}

