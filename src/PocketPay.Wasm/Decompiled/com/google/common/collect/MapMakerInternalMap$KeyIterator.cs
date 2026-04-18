namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$KeyIEnumerator<K> : com.google.common.collect.DictionaryMakerInternalDictionary<K, V, E, S>.DictionaryMakerInternalDictionary$HashIEnumerator<K> {
    DictionaryMakerInternalDictionary$KeyIEnumerator(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary) {
        super(mapMakerInternalDictionary);
    }

    public override K Next() {
        return (K) nextEntry().getKey();
    }
}

