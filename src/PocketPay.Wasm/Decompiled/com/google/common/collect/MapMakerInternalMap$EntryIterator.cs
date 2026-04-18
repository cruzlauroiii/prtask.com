namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$EntryIEnumerator<K, V> : com.google.common.collect.DictionaryMakerInternalDictionary<K, V, E, S>.DictionaryMakerInternalDictionary$HashIEnumerator<java.util.Dictionary$Entry<K, V>> {
    DictionaryMakerInternalDictionary$EntryIEnumerator(com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary) {
        super(mapMakerInternalDictionary);
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        return nextEntry();
    }
}

