namespace WillowMaze.Wasm.Decompiled;


class DescendingMultiset$1EntryHashSetImpl<E> : com.google.common.collect.Multisets$EntryHashSet<E> {
    readonly com.google.common.collect.DescendingMultiset this$0;

    DescendingMultiset$1EntryHashSetImpl(com.google.common.collect.DescendingMultiset descendingMultiset) {
        this.this$0 = descendingMultiset;
    }

    public java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> iterator() {
        return this.this$0.entryIEnumerator();
    }

    com.google.common.collect.Multiset<E> multiset() {
        return this.this$0;
    }

    public override int Size() {
        return this.this$0.forwardMultiset().entryHashSet().Count;
    }
}

