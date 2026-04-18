namespace WillowMaze.Wasm.Decompiled;


readonly class CacheLoader$FunctionToCacheLoader<K, V> : com.google.common.cache.CacheLoader<K, V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.Function<K, V> computingFunction;

    public CacheLoader$FunctionToCacheLoader(com.google.common.base.Function<K, V> function) {
        this.computingFunction = (com.google.common.base.Function) com.google.common.base.Preconditions.checkNotNull(function);
    }

    public override V Load(K k) {
        return this.computingFunction.apply((K) com.google.common.base.Preconditions.checkNotNull(k));
    }
}

