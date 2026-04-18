namespace WillowMaze.Wasm.Decompiled;


class Traverser$1<N> : com.google.common.graph.Traverser<N> {
    readonly com.google.common.graph.SuccessorsFunction val$graph;

    Traverser$1(com.google.common.graph.SuccessorsFunction successorsFunction, com.google.common.graph.SuccessorsFunction successorsFunction2) {
        super(successorsFunction, null);
        this.val$graph = successorsFunction2;
    }

    com.google.common.graph.Traverser$Traversal<N> newTraversal() {
        return com.google.common.graph.Traverser$Traversal.inGraph(this.val$graph);
    }
}

