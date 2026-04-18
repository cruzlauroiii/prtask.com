namespace WillowMaze.Wasm.Decompiled;


readonly class MultimapBuilder$TreeHashSetSupplier<V> : com.google.common.base.Supplier<java.util.SortedHashSet<V>>, java.io.object {
    private readonly java.util.Comparator<V> comparator;

    MultimapBuilder$TreeHashSetSupplier(java.util.Comparator<V> comparator) {
        this.comparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator);
    }

    public override java.lang.object Get() {
        return get();
    }

    public override java.util.SortedHashSet<V> Get() {
        return new java.util.TreeHashSet(this.comparator);
    }
}

