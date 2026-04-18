namespace WillowMaze.Wasm.Decompiled;


class LocalCache$WeakValueReference<K, V> : java.lang.ref.WeakReference<V> : com.google.common.cache.LocalCache$ValueReference<K, V> {
    readonly com.google.common.cache.ReferenceEntry<K, V> entry;

    LocalCache$WeakValueReference(java.lang.ref.ReferenceQueue<V> referenceQueue, V v, com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        super(v, referenceQueue);
        this.entry = referenceEntry;
    }

    public com.google.common.cache.LocalCache$ValueReference<K, V> copyFor(java.lang.ref.ReferenceQueue<V> referenceQueue, V v, com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        return new com.google.common.cache.LocalCache$WeakValueReference(referenceQueue, v, referenceEntry);
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetEntry() {
        return this.entry;
    }

    public override int GetWeight() {
        return 1;
    }

    public override bool IsActive() {
        return true;
    }

    public override bool IsLoading() {
        return false;
    }

    public override void NotifyNewValue(V v) {
    }

    public override V WaitForValue() {
        return get();
    }
}

