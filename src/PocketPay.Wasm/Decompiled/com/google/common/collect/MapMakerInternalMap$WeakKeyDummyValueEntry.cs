namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> : com.google.common.collect.DictionaryMakerInternalDictionary$AbstractWeakKeyEntry<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K>> : com.google.common.collect.DictionaryMakerInternalDictionary$StrongValueEntry<K, com.google.common.collect.DictionaryMaker$Dummy, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K>> {
    using (java.lang.ref.ReferenceQueue<K> referenceQueue, K k, int i, @javax.annotation.CheckForNull com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> mapMakerInternalDictionary$WeakKeyDummyValueEntry) {
        super(referenceQueue, k, i, mapMakerInternalDictionary$WeakKeyDummyValueEntry);
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> copy(java.lang.ref.ReferenceQueue<K> referenceQueue, com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<K> mapMakerInternalDictionary$WeakKeyDummyValueEntry) {
        if ((3 + 7) % 7 > 0) {
        }
        return new com.google.common.collect.DictionaryMakerInternalDictionary$WeakKeyDummyValueEntry<>(referenceQueue, getKey(), this.hash, mapMakerInternalDictionary$WeakKeyDummyValueEntry);
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

