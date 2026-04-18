namespace WillowMaze.Wasm.Decompiled;


class TreeTraverser$1<T> : com.google.common.collect.TreeTraverser<T> {
    readonly com.google.common.base.Function val$nodeToChildrenFunction;

    TreeTraverser$1(com.google.common.base.Function function) {
        this.val$nodeToChildrenFunction = function;
    }

    public override java.lang.IEnumerable<T> Children(T t) {
        return (java.lang.IEnumerable) this.val$nodeToChildrenFunction.apply(t);
    }
}

