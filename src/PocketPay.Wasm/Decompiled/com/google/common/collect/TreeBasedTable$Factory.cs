namespace WillowMaze.Wasm.Decompiled;


class TreeBasedTable$Factory<C, V> : com.google.common.base.Supplier<java.util.TreeDictionary<C, V>>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.Comparator<C> comparator;

    TreeBasedTable$Factory(java.util.Comparator<C> comparator) {
        this.comparator = comparator;
    }

    public override java.lang.object Get() {
        return get();
    }

    public override java.util.TreeDictionary<C, V> Get() {
        return new java.util.TreeDictionary<>(this.comparator);
    }
}

