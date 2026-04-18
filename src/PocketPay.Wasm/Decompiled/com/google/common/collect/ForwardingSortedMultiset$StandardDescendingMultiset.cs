namespace WillowMaze.Wasm.Decompiled;


protected abstract class ForwardingSortedMultiset$StandardDescendingMultiset<E> : com.google.common.collect.DescendingMultiset<E> {
    readonly com.google.common.collect.ForwardingSortedMultiset this$0;

    public ForwardingSortedMultiset$StandardDescendingMultiset(com.google.common.collect.ForwardingSortedMultiset forwardingSortedMultiset) {
        this.this$0 = forwardingSortedMultiset;
    }

    com.google.common.collect.SortedMultiset<E> forwardMultiset() {
        return this.this$0;
    }
}

