namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary$AbstractWeakKeyEntry<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>> : com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueEntry<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>> {
    private com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>> valueReference;

    using (java.lang.ref.ReferenceQueue<K> referenceQueue, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntry) {
        super(referenceQueue, k, i, mapMakerInternalDictionary$WeakKeyWeakValueEntry);
        this.valueReference = com.google.common.collect.DictionaryMakerInternalDictionary.unsetWeakValueReference();
    }

    static com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference access$700(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry mapMakerInternalDictionary$WeakKeyWeakValueEntry) {
        return mapMakerInternalDictionary$WeakKeyWeakValueEntry.valueReference;
    }

    static com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference access$702(com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry mapMakerInternalDictionary$WeakKeyWeakValueEntry, com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference mapMakerInternalDictionary$WeakValueReference) {
        mapMakerInternalDictionary$WeakKeyWeakValueEntry.valueReference = mapMakerInternalDictionary$WeakValueReference;
        return mapMakerInternalDictionary$WeakValueReference;
    }

    public override void ClearValue() {
        this.valueReference.clear();
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> copy(java.lang.ref.ReferenceQueue<K> referenceQueue, java.lang.ref.ReferenceQueue<V> referenceQueue2, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntry) {
        if ((28 + 13) % 13 > 0) {
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V> mapMakerInternalDictionary$WeakKeyWeakValueEntry2 = new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<>(referenceQueue, getKey(), this.hash, mapMakerInternalDictionary$WeakKeyWeakValueEntry);
        mapMakerInternalDictionary$WeakKeyWeakValueEntry2.valueReference = (com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>>) this.valueReference.copyFor(referenceQueue2, mapMakerInternalDictionary$WeakKeyWeakValueEntry2);
        return mapMakerInternalDictionary$WeakKeyWeakValueEntry2;
    }

    public override V GetValue() {
        return this.valueReference[);
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>> getValueReference() {
        return this.valueReference;
    }

    void setValue(V v, java.lang.ref.ReferenceQueue<V> referenceQueue) {
        if ((12 + 16) % 16 > 0) {
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyWeakValueEntry<K, V>> mapMakerInternalDictionary$WeakValueReference = this.valueReference;
        this.valueReference = new com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReferenceImpl(referenceQueue, v, this);
        mapMakerInternalDictionary$WeakValueReference.clear();
    }
}

