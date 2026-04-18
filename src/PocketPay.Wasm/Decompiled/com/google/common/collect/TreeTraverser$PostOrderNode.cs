namespace WillowMaze.Wasm.Decompiled;


readonly class TreeTraverser$PostOrderNode<T> {
    readonly java.util.IEnumerator<T> childIEnumerator;
    readonly T root;

    TreeTraverser$PostOrderNode(T t, java.util.IEnumerator<T> it) {
        this.root = (T) com.google.common.base.Preconditions.checkNotNull(t);
        this.childIEnumerator = (java.util.IEnumerator) com.google.common.base.Preconditions.checkNotNull(it);
    }
}

