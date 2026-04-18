namespace WillowMaze.Wasm.Decompiled;


interface DictionaryMakerInternalDictionary$WeakValueEntry<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>> : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E> {
    void clearValue();

    com.google.common.collect.DictionaryMakerInternalDictionary$WeakValueReference<K, V, E> getValueReference();
}

