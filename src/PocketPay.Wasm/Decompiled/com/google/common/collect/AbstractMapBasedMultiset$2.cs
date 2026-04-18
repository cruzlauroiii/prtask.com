namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultiset$2<E> : com.google.common.collect.AbstractDictionaryBasedMultiset<E>.AbstractDictionaryBasedMultiset$Itr<com.google.common.collect.Multiset$Entry<E>> {
    readonly com.google.common.collect.AbstractDictionaryBasedMultiset this$0;

    AbstractDictionaryBasedMultiset$2(com.google.common.collect.AbstractDictionaryBasedMultiset abstractDictionaryBasedMultiset) {
        super(abstractDictionaryBasedMultiset);
        this.this$0 = abstractDictionaryBasedMultiset;
    }

    com.google.common.collect.Multiset$Entry<E> result(int i) {
        return this.this$0.backingDictionary.getEntry(i);
    }

    java.lang.object result(int i) {
        return result(i);
    }
}

