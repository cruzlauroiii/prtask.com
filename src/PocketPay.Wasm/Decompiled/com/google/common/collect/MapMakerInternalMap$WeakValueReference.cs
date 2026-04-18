namespace WillowMaze.Wasm.Decompiled;


interface DictionaryMakerInternalDictionary$WeakValueReference<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>> {
    void clear();

    com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, E> copyFor(java.lang.ref.ReferenceQueue<V> referenceQueue, E e);

    @javax.annotation.CheckForNull
    V get();

    E getEntry();
}

