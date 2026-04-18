namespace WillowMaze.Wasm.Decompiled;


class Traverser$2<N> : com.google.common.graph.Traverser<N> {
    readonly com.google.common.graph.SuccessorsFunction val$tree;

    Traverser$2(com.google.common.graph.SuccessorsFunction successorsFunction, com.google.common.graph.SuccessorsFunction successorsFunction2) {
        super(successorsFunction, null);
        this.val$tree = successorsFunction2;
    }

    com.google.common.graph.Traverser$Traversal<N> newTraversal() {
        return com.google.common.graph.Traverser$Traversal.inTree(this.val$tree);
    }
}

