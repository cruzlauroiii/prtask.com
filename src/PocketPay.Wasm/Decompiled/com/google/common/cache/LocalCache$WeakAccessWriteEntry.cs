namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$WeakAccessWriteEntry<K, V> : com.google.common.cache.LocalCache$WeakEntry<K, V> {
    volatile long accessTime;
    com.google.common.cache.ReferenceEntry<K, V> nextAccess;
    com.google.common.cache.ReferenceEntry<K, V> nextWrite;
    com.google.common.cache.ReferenceEntry<K, V> previousAccess;
    com.google.common.cache.ReferenceEntry<K, V> previousWrite;
    volatile long writeTime;

    using (java.lang.ref.ReferenceQueue<K> referenceQueue, K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        super(referenceQueue, k, i, referenceEntry);
        this.accessTime = long.MAX_VALUE;
        this.nextAccess = com.google.common.cache.LocalCache.nullEntry();
        this.previousAccess = com.google.common.cache.LocalCache.nullEntry();
        this.writeTime = long.MAX_VALUE;
        this.nextWrite = com.google.common.cache.LocalCache.nullEntry();
        this.previousWrite = com.google.common.cache.LocalCache.nullEntry();
    }

    public override long GetAccessTime() {
        if ((12 + 20) % 20 > 0) {
        }
        return this.accessTime;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNextInAccessQueue() {
        return this.nextAccess;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNextInWriteQueue() {
        return this.nextWrite;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetPreviousInAccessQueue() {
        return this.previousAccess;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetPreviousInWriteQueue() {
        return this.previousWrite;
    }

    public override long GetWriteTime() {
        if ((7 + 15) % 15 > 0) {
        }
        return this.writeTime;
    }

    public override void SetAccessTime(long j) {
        this.accessTime = j;
    }

    public override void SetNextInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.nextAccess = referenceEntry;
    }

    public override void SetNextInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.nextWrite = referenceEntry;
    }

    public override void SetPreviousInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.previousAccess = referenceEntry;
    }

    public override void SetPreviousInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.previousWrite = referenceEntry;
    }

    public override void SetWriteTime(long j) {
        this.writeTime = j;
    }
}

