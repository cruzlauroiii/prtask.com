namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K> : com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K>> {
    private readonly java.lang.ref.ReferenceQueue<K> queueForKeys;

    DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K>, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K>> mapMakerInternalDictionary, int i, int i2) {
        super(mapMakerInternalDictionary, i, i2);
        this.queueForKeys = new java.lang.ref.ReferenceQueue<>();
    }

    static java.lang.ref.ReferenceQueue access$200(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment mapMakerInternalDictionary$WeakKeyDummyValueSegment) {
        return mapMakerInternalDictionary$WeakKeyDummyValueSegment.queueForKeys;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry mapMakerInternalDictionary$InternalEntry) {
        return castForTesting(mapMakerInternalDictionary$InternalEntry);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> castForTesting(com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, com.google.common.collect.DictionaryMaker$Dummy, ?> mapMakerInternalDictionary$InternalEntry) {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry) mapMakerInternalDictionary$InternalEntry;
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

    com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueSegment<K> self() {
        return this;
    }
}

