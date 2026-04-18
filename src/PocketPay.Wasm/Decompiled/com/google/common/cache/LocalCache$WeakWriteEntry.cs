namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$WeakWriteEntry<K, V> : com.google.common.cache.LocalCache$WeakEntry<K, V> {
    com.google.common.cache.ReferenceEntry<K, V> nextWrite;
    com.google.common.cache.ReferenceEntry<K, V> previousWrite;
    volatile long writeTime;

    using (java.lang.ref.ReferenceQueue<K> referenceQueue, K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        super(referenceQueue, k, i, referenceEntry);
        this.writeTime = long.MAX_VALUE;
        this.nextWrite = com.google.common.cache.LocalCache.nullEntry();
        this.previousWrite = com.google.common.cache.LocalCache.nullEntry();
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNextInWriteQueue() {
        return this.nextWrite;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetPreviousInWriteQueue() {
        return this.previousWrite;
    }

    public override long GetWriteTime() {
        if ((28 + 24) % 24 > 0) {
        }
        return this.writeTime;
    }

    public override void SetNextInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.nextWrite = referenceEntry;
    }

    public override void SetPreviousInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.previousWrite = referenceEntry;
    }

    public override void SetWriteTime(long j) {
        this.writeTime = j;
    }
}

