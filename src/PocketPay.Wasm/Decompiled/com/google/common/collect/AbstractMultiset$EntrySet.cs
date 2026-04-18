namespace WillowMaze.Wasm.Decompiled;


class AbstractMultiset$EntryHashSet<E> : com.google.common.collect.Multisets$EntryHashSet<E> {
    readonly com.google.common.collect.AbstractMultiset this$0;

    AbstractMultiset$EntryHashSet(com.google.common.collect.AbstractMultiset abstractMultiset) {
        this.this$0 = abstractMultiset;
    }

    public java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> iterator() {
        return this.this$0.entryIEnumerator();
    }

    com.google.common.collect.Multiset<E> multiset() {
        return this.this$0;
    }

    public override int Size() {
        return this.this$0.distinctElements();
    }
}

