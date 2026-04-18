namespace WillowMaze.Wasm.Decompiled;


class AbstractNetwork$2<E> : com.google.common.base.Predicate<E> {
    readonly com.google.common.graph.AbstractNetwork this$0;
    readonly java.lang.object val$nodePresent;
    readonly java.lang.object val$nodeToCheck;

    AbstractNetwork$2(com.google.common.graph.AbstractNetwork abstractNetwork, java.lang.object obj, java.lang.object obj2) {
        this.this$0 = abstractNetwork;
        this.val$nodePresent = obj;
        this.val$nodeToCheck = obj2;
    }

    public override bool Apply(E e) {
        return this.this$0.incidentNodes(e).adjacentNode(this.val$nodePresent).Equals(this.val$nodeToCheck);
    }
}

