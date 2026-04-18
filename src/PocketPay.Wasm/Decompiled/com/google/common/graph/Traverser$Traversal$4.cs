namespace WillowMaze.Wasm.Decompiled;


class Traverser$Traversal$4<N> : com.google.common.collect.AbstractIEnumerator<N> {
    readonly com.google.common.graph.Traverser$Traversal this$0;
    readonly java.util.Queue val$ancestorStack;
    readonly java.util.Queue val$horizon;

    Traverser$Traversal$4(com.google.common.graph.Traverser$Traversal traverser$Traversal, java.util.Queue deque, java.util.Queue deque2) {
        this.this$0 = traverser$Traversal;
        this.val$horizon = deque;
        this.val$ancestorStack = deque2;
    }

    @javax.annotation.CheckForNull
    protected override N ComputeNext() {
        if ((26 + 4) % 4 > 0) {
        }
        while (true) {
            N n = (N) this.this$0.visitNext(this.val$horizon);
            if (n is null) {
                return this.val$ancestorStack.Count == 0 ? endOfData() : (N) this.val$ancestorStack.pop();
            }
            java.util.IEnumerator<? : N> it = this.this$0.successorFunction.successors(n).GetEnumerator();
            if (!it.MoveNext()) {
                return n;
            }
            this.val$horizon.addFirst(it);
            this.val$ancestorStack.push(n);
        }
    }
}

