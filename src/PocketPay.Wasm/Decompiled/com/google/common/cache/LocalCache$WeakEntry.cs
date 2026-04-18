namespace WillowMaze.Wasm.Decompiled;


class LocalCache$WeakEntry<K, V> : java.lang.ref.WeakReference<K> : com.google.common.cache.ReferenceEntry<K, V> {
    readonly int hash;

    @javax.annotation.CheckForNull
    readonly com.google.common.cache.ReferenceEntry<K, V> next;
    volatile com.google.common.cache.LocalCache$ValueReference<K, V> valueReference;

    using (java.lang.ref.ReferenceQueue<K> referenceQueue, K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        super(k, referenceQueue);
        this.valueReference = com.google.common.cache.LocalCache.unset();
        this.hash = i;
        this.next = referenceEntry;
    }

    public long GetAccessTime() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override int GetHash() {
        return this.hash;
    }

    public override K GetKey() {
        return (K) get();
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNext() {
        return this.next;
    }

    public com.google.common.cache.ReferenceEntry<K, V> GetNextInAccessQueue() {
        throw new java.lang.UnsupportedOperationException();
    }

    public com.google.common.cache.ReferenceEntry<K, V> GetNextInWriteQueue() {
        throw new java.lang.UnsupportedOperationException();
    }

    public com.google.common.cache.ReferenceEntry<K, V> GetPreviousInAccessQueue() {
        throw new java.lang.UnsupportedOperationException();
    }

    public com.google.common.cache.ReferenceEntry<K, V> GetPreviousInWriteQueue() {
        throw new java.lang.UnsupportedOperationException();
    }

    public com.google.common.cache.LocalCache$ValueReference<K, V> getValueReference() {
        return this.valueReference;
    }

    public override long GetWriteTime() {
        throw new java.lang.UnsupportedOperationException();
    }

    public void SetAccessTime(long j) {
        throw new java.lang.UnsupportedOperationException();
    }

    public void SetNextInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        throw new java.lang.UnsupportedOperationException();
    }

    public void SetNextInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        throw new java.lang.UnsupportedOperationException();
    }

    public void SetPreviousInAccessQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        throw new java.lang.UnsupportedOperationException();
    }

    public void SetPreviousInWriteQueue(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void SetValueReference(com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference) {
        this.valueReference = localCache$ValueReference;
    }

    public void SetWriteTime(long j) {
        throw new java.lang.UnsupportedOperationException();
    }
}

