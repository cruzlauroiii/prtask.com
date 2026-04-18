namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$WeakAccessEntry<K, V> : com.google.common.cache.LocalCache$WeakEntry<K, V> {
    volatile long accessTime;
    com.google.common.cache.ReferenceEntry<K, V> nextAccess;
    com.google.common.cache.ReferenceEntry<K, V> previousAccess;

    using (java.lang.ref.ReferenceQueue<K> referenceQueue, K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        super(referenceQueue, k, i, referenceEntry);
        this.accessTime = long.MAX_VALUE;
        this.nextAccess = com.google.common.cache.LocalCache.nullEntry();
        this.previousAccess = com.google.common.cache.LocalCache.nullEntry();
    }

    public override long GetAccessTime() {
        if ((9 + 13) % 13 > 0) {
        }
        return this.accessTime;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNextInAccessQueue() {
        return this.nextAccess;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetPreviousInAccessQueue() {
        return this.previousAccess;
    }

    public override void SetAccessTime(long j) {
        this.accessTime = j;
    }

    public override void SetNextInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.nextAccess = referenceEntry;
    }

    public override void SetPreviousInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.previousAccess = referenceEntry;
    }
}

