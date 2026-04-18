namespace WillowMaze.Wasm.Decompiled;


class TreeMultiset$1<E> : com.google.common.collect.Multisets$AbstractEntry<E> {
    readonly com.google.common.collect.TreeMultiset this$0;
    readonly com.google.common.collect.TreeMultiset$AvlNode val$baseEntry;

    TreeMultiset$1(com.google.common.collect.TreeMultiset treeMultiset, com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        this.this$0 = treeMultiset;
        this.val$baseEntry = treeMultiset$AvlNode;
    }

    public override int GetCount() {
        int count = this.val$baseEntry.getCount();
        return count != 0 ? count : this.this$0.count(getElement());
    }

    @com.google.common.collect.ParametricNullness
    public override E GetElement() {
        return (E) this.val$baseEntry.getElement();
    }
}

