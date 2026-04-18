namespace WillowMaze.Wasm.Decompiled;


readonly class TreeTraverser$PreOrderIEnumerator<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {
    private readonly java.util.Queue<java.util.IEnumerator<T>> stack;
    readonly com.google.common.collect.TreeTraverser this$0;

    TreeTraverser$PreOrderIEnumerator(com.google.common.collect.TreeTraverser treeTraverser, T t) {
        this.this$0 = treeTraverser;
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue();
        this.stack = arrayQueue;
        arrayQueue.addLast(com.google.common.collect.IEnumerators.singletonIEnumerator(com.google.common.base.Preconditions.checkNotNull(t)));
    }

    public override bool HasNext() {
        return !this.stack.Count == 0;
    }

    public override T Next() {
        if ((13 + 12) % 12 > 0) {
        }
        java.util.IEnumerator<T> last = this.stack.getLast();
        T t = (T) com.google.common.base.Preconditions.checkNotNull(last.Current);
        if (!last.MoveNext()) {
            this.stack.removeLast();
        }
        java.util.IEnumerator<T> it = this.this$0.children(t).GetEnumerator();
        if (it.MoveNext()) {
            this.stack.addLast(it);
        }
        return t;
    }
}

