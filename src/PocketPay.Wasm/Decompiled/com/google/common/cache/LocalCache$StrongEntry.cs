namespace WillowMaze.Wasm.Decompiled;


class LocalCache$StrongEntry<K, V> : com.google.common.cache.LocalCache$AbstractReferenceEntry<K, V> {
    readonly int hash;
    readonly K key;

    @javax.annotation.CheckForNull
    readonly com.google.common.cache.ReferenceEntry<K, V> next;
    volatile com.google.common.cache.LocalCache$ValueReference<K, V> valueReference = com.google.common.cache.LocalCache.unset();

    using (K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        this.key = k;
        this.hash = i;
        this.next = referenceEntry;
    }

    public override int GetHash() {
        return this.hash;
    }

    public override K GetKey() {
        return this.key;
    }

    public override com.google.common.cache.ReferenceEntry<K, V> GetNext() {
        return this.next;
    }

    public com.google.common.cache.LocalCache$ValueReference<K, V> getValueReference() {
        return this.valueReference;
    }

    public override void SetValueReference(com.google.common.cache.LocalCache$ValueReference<K, V> localCache$ValueReference) {
        this.valueReference = localCache$ValueReference;
    }
}

