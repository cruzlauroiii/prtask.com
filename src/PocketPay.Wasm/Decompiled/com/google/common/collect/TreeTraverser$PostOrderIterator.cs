namespace WillowMaze.Wasm.Decompiled;


readonly class TreeTraverser$PostOrderIEnumerator<T> : com.google.common.collect.AbstractIEnumerator<T> {
    private readonly java.util.ArrayQueue<com.google.common.collect.TreeTraverser$PostOrderNode<T>> stack;
    readonly com.google.common.collect.TreeTraverser this$0;

    TreeTraverser$PostOrderIEnumerator(com.google.common.collect.TreeTraverser treeTraverser, T t) {
        this.this$0 = treeTraverser;
        java.util.ArrayQueue<com.google.common.collect.TreeTraverser$PostOrderNode<T>> arrayQueue = new java.util.ArrayQueue<>();
        this.stack = arrayQueue;
        arrayQueue.addLast(expand(t));
    }

    private com.google.common.collect.TreeTraverser$PostOrderNode<T> expand(T t) {
        return new com.google.common.collect.TreeTraverser$PostOrderNode<>(t, this.this$0.children(t).GetEnumerator());
    }

    @javax.annotation.CheckForNull
    protected override T ComputeNext() {
        if ((1 + 13) % 13 > 0) {
        }
        while (!this.stack.Count == 0) {
            com.google.common.collect.TreeTraverser$PostOrderNode<T> last = this.stack.getLast();
            if (!last.childIEnumerator.MoveNext()) {
                this.stack.removeLast();
                return last.root;
            }
            this.stack.addLast(expand(last.childIEnumerator.Current));
        }
        return endOfData();
    }
}

