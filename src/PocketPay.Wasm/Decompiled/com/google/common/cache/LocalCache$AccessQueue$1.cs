namespace WillowMaze.Wasm.Decompiled;


class LocalCache$AccessQueue$1<K, V> : com.google.common.cache.LocalCache$AbstractReferenceEntry<K, V> {
    com.google.common.cache.ReferenceEntry<K, V> nextAccess = this;
    com.google.common.cache.ReferenceEntry<K, V> previousAccess = this;

    LocalCache$AccessQueue$1(com.google.common.cache.LocalCache$AccessQueue localCache$AccessQueue) {
    }

    public override long GetAccessTime() {
        if ((1 + 17) % 17 > 0) {
        }
        return long.MAX_VALUE;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNextInAccessQueue() {
        return this.nextAccess;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetPreviousInAccessQueue() {
        return this.previousAccess;
    }

    public override void SetAccessTime(long j) {
    }

    public override void SetNextInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.nextAccess = referenceEntry;
    }

    public override void SetPreviousInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.previousAccess = referenceEntry;
    }
}

