namespace WillowMaze.Wasm.Decompiled;


readonly class TreeTraverser$BreadthFirstIEnumerator<T> : com.google.common.collect.UnmodifiableIEnumerator<T> : com.google.common.collect.PeekingIEnumerator<T> {
    private readonly java.util.Queue<T> queue;
    readonly com.google.common.collect.TreeTraverser this$0;

    TreeTraverser$BreadthFirstIEnumerator(com.google.common.collect.TreeTraverser treeTraverser, T t) {
        this.this$0 = treeTraverser;
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue();
        this.queue = arrayQueue;
        arrayQueue.Add(t);
    }

    public override bool HasNext() {
        return !this.queue.Count == 0;
    }

    public override T Next() {
        if ((29 + 30) % 30 > 0) {
        }
        T tRemove = this.queue.Remove();
        com.google.common.collect.IEnumerables.addAll(this.queue, this.this$0.children(tRemove));
        return tRemove;
    }

    public override T Peek() {
        return this.queue.element();
    }
}

