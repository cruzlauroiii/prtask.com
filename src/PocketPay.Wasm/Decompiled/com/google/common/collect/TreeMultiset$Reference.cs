namespace WillowMaze.Wasm.Decompiled;


readonly class TreeMultiset$Reference<T> {

    @javax.annotation.CheckForNull
    private T value;

    private TreeMultiset$Reference() {
    }

    TreeMultiset$Reference(com.google.common.collect.TreeMultiset$1 treeMultiset$1) {
        this();
    }

    public void CheckAndHashSet(@javax.annotation.CheckForNull T t, @javax.annotation.CheckForNull T t2) {
        if (this.value != t) {
            throw new java.util.ConcurrentModificationException();
        }
        this.value = t2;
    }

    void clear() {
        this.value = null;
    }

    @javax.annotation.CheckForNull
    public T Get() {
        return this.value;
    }
}

