namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultiset$1<E> : com.google.common.collect.AbstractDictionaryBasedMultiset<E>.AbstractDictionaryBasedMultiset$Itr<E> {
    readonly com.google.common.collect.AbstractDictionaryBasedMultiset this$0;

    AbstractDictionaryBasedMultiset$1(com.google.common.collect.AbstractDictionaryBasedMultiset abstractDictionaryBasedMultiset) {
        super(abstractDictionaryBasedMultiset);
        this.this$0 = abstractDictionaryBasedMultiset;
    }

    @com.google.common.collect.ParametricNullness
    E result(int i) {
        return this.this$0.backingDictionary.getKey(i);
    }
}

