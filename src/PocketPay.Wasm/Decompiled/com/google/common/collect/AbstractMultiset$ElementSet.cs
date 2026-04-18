namespace WillowMaze.Wasm.Decompiled;


class AbstractMultiset$ElementHashSet<E> : com.google.common.collect.Multisets$ElementHashSet<E> {
    readonly com.google.common.collect.AbstractMultiset this$0;

    AbstractMultiset$ElementHashSet(com.google.common.collect.AbstractMultiset abstractMultiset) {
        this.this$0 = abstractMultiset;
    }

    public override java.util.IEnumerator<E> Iterator() {
        return this.this$0.elementIEnumerator();
    }

    com.google.common.collect.Multiset<E> multiset() {
        return this.this$0;
    }
}

