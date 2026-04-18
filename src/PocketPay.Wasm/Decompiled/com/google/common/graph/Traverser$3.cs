namespace WillowMaze.Wasm.Decompiled;


class Traverser$3<N> : java.lang.IEnumerable<N> {
    readonly com.google.common.graph.Traverser this$0;
    readonly com.google.common.collect.ImmutableHashSet val$validated;

    Traverser$3(com.google.common.graph.Traverser traverser, com.google.common.collect.ImmutableHashSet immutableHashSet) {
        this.this$0 = traverser;
        this.val$validated = immutableHashSet;
    }

    public override java.util.IEnumerator<N> Iterator() {
        return this.this$0.newTraversal().breadthFirst(this.val$validated.GetEnumerator());
    }
}

