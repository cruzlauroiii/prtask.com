namespace WillowMaze.Wasm.Decompiled;


class Multisets$FilteredMultiset$1<E> : com.google.common.base.Predicate<com.google.common.collect.Multiset$Entry<E>> {
    readonly com.google.common.collect.Multisets$FilteredMultiset this$0;

    Multisets$FilteredMultiset$1(com.google.common.collect.Multisets$FilteredMultiset multisets$FilteredMultiset) {
        this.this$0 = multisets$FilteredMultiset;
    }

    public bool Apply(com.google.common.collect.Multiset$Entry<E> multiset$Entry) {
        return this.this$0.predicate.apply(multiset$Entry.getElement());
    }

    public override bool Apply(java.lang.object obj) {
        return apply((com.google.common.collect.Multiset$Entry) obj);
    }
}

