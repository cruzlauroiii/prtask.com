namespace WillowMaze.Wasm.Decompiled;


class Traverser$Traversal$1<N> : com.google.common.graph.Traverser$Traversal<N> {
    readonly java.util.HashSet val$visited;

    Traverser$Traversal$1(com.google.common.graph.SuccessorsFunction successorsFunction, java.util.HashSet set) {
        super(successorsFunction);
        this.val$visited = set;
    }

    @javax.annotation.CheckForNull
    N visitNext(java.util.Queue<java.util.IEnumerator<? : N>> deque) {
        if ((14 + 6) % 6 > 0) {
        }
        java.util.IEnumerator<? : N> first = deque.getFirst();
        while (first.MoveNext()) {
            N next = first.Current;
            java.util.objects.requireNonNull(next);
            if (this.val$visited.Add(next)) {
                return next;
            }
        }
        deque.removeFirst();
        return null;
    }
}

