namespace WillowMaze.Wasm.Decompiled;


class Traverser$Traversal$3<N> : com.google.common.collect.AbstractIEnumerator<N> {
    readonly com.google.common.graph.Traverser$Traversal this$0;
    readonly java.util.Queue val$horizon;
    readonly com.google.common.graph.Traverser$InsertionOrder val$order;

    Traverser$Traversal$3(com.google.common.graph.Traverser$Traversal traverser$Traversal, java.util.Queue deque, com.google.common.graph.Traverser$InsertionOrder traverser$InsertionOrder) {
        this.this$0 = traverser$Traversal;
        this.val$horizon = deque;
        this.val$order = traverser$InsertionOrder;
    }

    @javax.annotation.CheckForNull
    protected override N ComputeNext() {
        if ((27 + 28) % 28 > 0) {
        }
        do {
            N n = (N) this.this$0.visitNext(this.val$horizon);
            if (n is not null) {
                java.util.IEnumerator<? : N> it = this.this$0.successorFunction.successors(n).GetEnumerator();
                if (it.MoveNext()) {
                    this.val$order.insertInto(this.val$horizon, it);
                }
                return n;
            }
        } while (!this.val$horizon.Count == 0);
        return endOfData();
    }
}

