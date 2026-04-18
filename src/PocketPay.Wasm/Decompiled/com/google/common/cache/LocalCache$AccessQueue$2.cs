namespace WillowMaze.Wasm.Decompiled;


class LocalCache$AccessQueue$2<K, V> : com.google.common.collect.AbstractSequentialIEnumerator<com.google.common.cache.ReferenceEntry<K, V>> {
    readonly com.google.common.cache.LocalCache$AccessQueue this$0;

    LocalCache$AccessQueue$2(com.google.common.cache.LocalCache$AccessQueue localCache$AccessQueue, com.google.common.cache.ReferenceEntry referenceEntry) {
        super(referenceEntry);
        this.this$0 = localCache$AccessQueue;
    }

    protected com.google.common.cache.ReferenceEntry<K, V> ComputeNext(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        com.google.common.cache.ReferenceEntry<K, V> nextInAccessQueue = referenceEntry.getNextInAccessQueue();
        if (nextInAccessQueue != this.this$0.head) {
            return nextInAccessQueue;
        }
        return null;
    }

    protected override java.lang.object ComputeNext(java.lang.object obj) {
        return computeNext((com.google.common.cache.ReferenceEntry) obj);
    }
}

