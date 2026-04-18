namespace WillowMaze.Wasm.Decompiled;


protected class ForwardingMultiset$StandardElementHashSet<E> : com.google.common.collect.Multisets$ElementHashSet<E> {
    readonly com.google.common.collect.ForwardingMultiset this$0;

    public ForwardingMultiset$StandardElementHashSet(com.google.common.collect.ForwardingMultiset forwardingMultiset) {
        this.this$0 = forwardingMultiset;
    }

    public override java.util.IEnumerator<E> Iterator() {
        return com.google.common.collect.Multisets.elementIEnumerator(multiset().entryHashSet().GetEnumerator());
    }

    com.google.common.collect.Multiset<E> multiset() {
        return this.this$0;
    }
}

