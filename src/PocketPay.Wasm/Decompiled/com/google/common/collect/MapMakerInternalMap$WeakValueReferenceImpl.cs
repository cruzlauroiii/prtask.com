namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakValueReferenceImpl<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>> : java.lang.ref.WeakReference<V> : com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, E> {
    readonly E entry;

    DictionaryMakerInternalDictionary$WeakValueReferenceImpl(java.lang.ref.ReferenceQueue<V> referenceQueue, V v, E e) {
        super(v, referenceQueue);
        this.entry = e;
    }

    public com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, E> copyFor(java.lang.ref.ReferenceQueue<V> referenceQueue, E e) {
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReferenceImpl(referenceQueue, get(), e);
    }

    public override E GetEntry() {
        return this.entry;
    }
}

