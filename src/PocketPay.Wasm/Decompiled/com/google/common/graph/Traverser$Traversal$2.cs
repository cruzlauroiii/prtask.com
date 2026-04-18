namespace WillowMaze.Wasm.Decompiled;


class Traverser$Traversal$2<N> : com.google.common.graph.Traverser$Traversal<N> {
    Traverser$Traversal$2(com.google.common.graph.SuccessorsFunction successorsFunction) {
        super(successorsFunction);
    }

    @javax.annotation.CheckForNull
    N visitNext(java.util.Queue<java.util.IEnumerator<? : N>> deque) {
        java.util.IEnumerator<? : N> first = deque.getFirst();
        if (first.MoveNext()) {
            return (N) com.google.common.base.Preconditions.checkNotNull(first.Current);
        }
        deque.removeFirst();
        return null;
    }
}

