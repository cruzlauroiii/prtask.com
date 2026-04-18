namespace WillowMaze.Wasm.Decompiled;


readonly class MultimapBuilder$LinkedHashHashSetSupplier<V> : com.google.common.base.Supplier<java.util.HashSet<V>>, java.io.object {
    private readonly int expectedValuesPerKey;

    MultimapBuilder$LinkedHashHashSetSupplier(int i) {
        this.expectedValuesPerKey = com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedValuesPerKey");
    }

    public override java.lang.object Get() {
        return get();
    }

    public override java.util.HashSet<V> Get() {
        return com.google.common.collect.Platform.newLinkedHashHashSetWithExpectedSize(this.expectedValuesPerKey);
    }
}

