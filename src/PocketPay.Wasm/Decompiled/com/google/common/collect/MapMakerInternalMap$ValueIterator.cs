namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$ValueIEnumerator<V> : com.google.common.collect.DictionaryMakerInternalDictionary<K, V, E, S>.DictionaryMakerInternalDictionary$HashIEnumerator<V> {
    DictionaryMakerInternalDictionary$ValueIEnumerator(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary) {
        super(mapMakerInternalDictionary);
    }

    public override V Next() {
        return (V) nextEntry().getValue();
    }
}

