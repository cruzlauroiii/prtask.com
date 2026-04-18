namespace WillowMaze.Wasm.Decompiled;


class LocalCache$StrongValueReference<K, V> : com.google.common.cache.LocalCache$ValueReference<K, V> {
    readonly V referent;

    LocalCache$StrongValueReference(V v) {
        this.referent = v;
    }

    public com.google.common.cache.LocalCache$ValueReference<K, V> copyFor(java.lang.ref.ReferenceQueue<V> referenceQueue, V v, com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        return this;
    }

    public override V Get() {
        return this.referent;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetEntry() {
        return null;
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

