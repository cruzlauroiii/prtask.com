namespace WillowMaze.Wasm.Decompiled;


class LocalCache$WriteQueue$2<K, V> : com.google.common.collect.AbstractSequentialIEnumerator<com.google.common.cache.ReferenceEntry<K, V>> {
    readonly com.google.common.cache.LocalCache$WriteQueue this$0;

    LocalCache$WriteQueue$2(com.google.common.cache.LocalCache$WriteQueue localCache$WriteQueue, com.google.common.cache.ReferenceEntry referenceEntry) {
        super(referenceEntry);
        this.this$0 = localCache$WriteQueue;
    }

    protected com.google.common.cache.ReferenceEntry<K, V> ComputeNext(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        com.google.common.cache.ReferenceEntry<K, V> nextInWriteQueue = referenceEntry.getNextInWriteQueue();
        if (nextInWriteQueue != this.this$0.head) {
            return nextInWriteQueue;
        }
        return null;
    }

    protected override java.lang.object ComputeNext(java.lang.object obj) {
        return computeNext((com.google.common.cache.ReferenceEntry) obj);
    }
}

