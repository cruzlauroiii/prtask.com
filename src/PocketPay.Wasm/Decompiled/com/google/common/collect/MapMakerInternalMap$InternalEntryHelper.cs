namespace WillowMaze.Wasm.Decompiled;


interface DictionaryMakerInternalDictionary$InternalEntryHelper<K, V, E : com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry<K, V, E>, S : com.google.common.collect.DictionaryMakerInternalDictionary$Segment<K, V, E, S>> {
    E copy(S s, E e, @javax.annotation.CheckForNull E e2);

    com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength();

    E newEntry(S s, K k, int i, @javax.annotation.CheckForNull E e);

    S newSegment(com.google.common.collect.DictionaryMakerInternalDictionary<K, V, E, S> mapMakerInternalDictionary, int i, int i2);

    void setValue(S s, E e, V v);

    com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength();
}

