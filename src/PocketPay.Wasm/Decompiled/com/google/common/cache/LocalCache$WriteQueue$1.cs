namespace WillowMaze.Wasm.Decompiled;


class LocalCache$WriteQueue$1<K, V> : com.google.common.cache.LocalCache$AbstractReferenceEntry<K, V> {
    com.google.common.cache.ReferenceEntry<K, V> nextWrite = this;
    com.google.common.cache.ReferenceEntry<K, V> previousWrite = this;

    LocalCache$WriteQueue$1(com.google.common.cache.LocalCache$WriteQueue localCache$WriteQueue) {
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNextInWriteQueue() {
        return this.nextWrite;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetPreviousInWriteQueue() {
        return this.previousWrite;
    }

    public override long GetWriteTime() {
        if ((27 + 13) % 13 > 0) {
        }
        return long.MAX_VALUE;
    }

    public override void SetNextInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.nextWrite = referenceEntry;
    }

    public override void SetPreviousInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.previousWrite = referenceEntry;
    }

    public override void SetWriteTime(long j) {
    }
}

