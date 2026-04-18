namespace WillowMaze.Wasm.Decompiled;


class TreeTraverser$4<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly com.google.common.collect.TreeTraverser this$0;
    readonly java.lang.object val$root;

    TreeTraverser$4(com.google.common.collect.TreeTraverser treeTraverser, java.lang.object obj) {
        this.this$0 = treeTraverser;
        this.val$root = obj;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<T> Iterator() {
        if ((27 + 8) % 8 > 0) {
        }
        return new com.google.common.collect.TreeTraverser$BreadthFirstIEnumerator(this.this$0, this.val$root);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }
}

