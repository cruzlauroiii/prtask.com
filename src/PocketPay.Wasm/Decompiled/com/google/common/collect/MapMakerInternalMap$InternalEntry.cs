namespace WillowMaze.Wasm.Decompiled;


interface DictionaryMakerInternalDictionary$InternalEntry<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>> {
    int getHash();

    K getKey();

    E getNext();

    V getValue();
}

