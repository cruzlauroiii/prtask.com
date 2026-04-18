namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> : com.google.common.collect.DictionaryMakerInternalDictionary$AbstractStrongKeyEntry<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K>> : com.google.common.collect.DictionaryMakerInternalDictionary$StrongValueEntry<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K>> {
    using (K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> mapMakerInternalDictionary$StrongKeyDummyValueEntry) {
        super(k, i, mapMakerInternalDictionary$StrongKeyDummyValueEntry);
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> copy(com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<K> mapMakerInternalDictionary$StrongKeyDummyValueEntry) {
        if ((9 + 26) % 26 > 0) {
        }
        return new com.google.common.collect.DictionaryMakerInternalDictionary$StrongKeyDummyValueEntry<>(this.key, this.hash, mapMakerInternalDictionary$StrongKeyDummyValueEntry);
    }

    public com.google.common.collect.DictionaryMaker$Dummy getValue() {
        return com.google.common.collect.DictionaryMaker$Dummy.VALUE;
    }

    public override java.lang.object GetValue() {
        return getValue();
    }

    void setValue(com.google.common.collect.DictionaryMaker$Dummy mapMaker$Dummy) {
    }
}

