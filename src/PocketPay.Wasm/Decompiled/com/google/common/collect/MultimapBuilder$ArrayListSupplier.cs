namespace WillowMaze.Wasm.Decompiled;


readonly class MultimapBuilder$ListSupplier<V> : com.google.common.base.Supplier<java.util.List<V>>, java.io.object {
    private readonly int expectedValuesPerKey;

    MultimapBuilder$ListSupplier(int i) {
        this.expectedValuesPerKey = com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedValuesPerKey");
    }

    public override java.lang.object Get() {
        return get();
    }

    public override java.util.List<V> Get() {
        return new java.util.List(this.expectedValuesPerKey);
    }
}

