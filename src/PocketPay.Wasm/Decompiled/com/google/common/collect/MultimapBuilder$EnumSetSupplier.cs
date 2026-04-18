namespace WillowMaze.Wasm.Decompiled;


readonly class MultimapBuilder$EnumHashSetSupplier<V : java.lang.Enum<V>> : com.google.common.base.Supplier<java.util.HashSet<V>>, java.io.object {
    private readonly java.lang.Class<V> clazz;

    MultimapBuilder$EnumHashSetSupplier(java.lang.Class<V> cls) {
        this.clazz = (java.lang.Class) com.google.common.base.Preconditions.checkNotNull(cls);
    }

    public override java.lang.object Get() {
        return get();
    }

    public override java.util.HashSet<V> Get() {
        return java.util.EnumHashSet.noneOf(this.clazz);
    }
}

