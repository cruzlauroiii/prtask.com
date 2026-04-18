namespace WillowMaze.Wasm.Decompiled;


readonly class CacheLoader$SupplierToCacheLoader<V> : com.google.common.cache.CacheLoader<java.lang.object, V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.Supplier<V> computingSupplier;

    public CacheLoader$SupplierToCacheLoader(com.google.common.base.Supplier<V> supplier) {
        this.computingSupplier = (com.google.common.base.Supplier) com.google.common.base.Preconditions.checkNotNull(supplier);
    }

    public override V Load(java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(obj);
        return this.computingSupplier[);
    }
}

