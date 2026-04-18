namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V>> {
    private readonly java.lang.ref.ReferenceQueue<K> queueForKeys;

    DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V>> mapMakerInternalDictionary, int i, int i2) {
        super(mapMakerInternalDictionary, i, i2);
        this.queueForKeys = new java.lang.ref.ReferenceQueue<>();
    }

    static java.lang.ref.ReferenceQueue access$300(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment mapMakerInternalDictionary$WeakKeyStrongValueSegment) {
        return mapMakerInternalDictionary$WeakKeyStrongValueSegment.queueForKeys;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return castForTesting(mapMakerInternalDictionary$InternalEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry<K, V> castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, object> mapMakerInternalDictionary$InternalEntry) {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueEntry) mapMakerInternalDictionary$InternalEntry;
    }

    java.lang.ref.ReferenceQueue<K> getKeyReferenceQueueForTesting() {
        return this.queueForKeys;
    }

    void maybeClearReferenceQueues() {
        clearReferenceQueue(this.queueForKeys);
    }

    void maybeDrainReferenceQueues() {
        drainKeyReferenceQueue(this.queueForKeys);
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Segment self() {
        return self();
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyStrongValueSegment<K, V> self() {
        return this;
    }
}

