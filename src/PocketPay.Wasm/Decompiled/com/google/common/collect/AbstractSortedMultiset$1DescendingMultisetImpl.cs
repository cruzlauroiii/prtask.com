namespace WillowMaze.Wasm.Decompiled;


class AbstractSortedMultiset$1DescendingMultisetImpl<E> : com.google.common.collect.DescendingMultiset<E> {
    readonly com.google.common.collect.AbstractSortedMultiset this$0;

    AbstractSortedMultiset$1DescendingMultisetImpl(com.google.common.collect.AbstractSortedMultiset abstractSortedMultiset) {
        this.this$0 = abstractSortedMultiset;
    }

    java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator() {
        return this.this$0.descendingEntryIEnumerator();
    }

    com.google.common.collect.SortedMultiset<E> forwardMultiset() {
        return this.this$0;
    }

    public override java.util.IEnumerator<E> Iterator() {
        return this.this$0.descendingIEnumerator();
    }
}

