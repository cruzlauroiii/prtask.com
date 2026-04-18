namespace WillowMaze.Wasm.Decompiled;


class TreeTraverser$2<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly com.google.common.collect.TreeTraverser this$0;
    readonly java.lang.object val$root;

    TreeTraverser$2(com.google.common.collect.TreeTraverser treeTraverser, java.lang.object obj) {
        this.this$0 = treeTraverser;
        this.val$root = obj;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<T> Iterator() {
        return this.this$0.preOrderIEnumerator(this.val$root);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }
}

