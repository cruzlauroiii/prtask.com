namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public abstract class CacheLoader<K, V> {
    protected CacheLoader() {
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public static <K, V> com.google.common.cache.CacheLoader<K, V> AsyncReloading(com.google.common.cache.CacheLoader<K, V> cacheLoader, java.util.concurrent.Executor executor) {
        com.google.common.base.Preconditions.checkNotNull(cacheLoader);
        com.google.common.base.Preconditions.checkNotNull(executor);
        return new com.google.common.cache.CacheLoader$1(cacheLoader, executor);
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public static <K, V> com.google.common.cache.CacheLoader<K, V> From(com.google.common.base.Function<K, V> function) {
        return new com.google.common.cache.CacheLoader$FunctionToCacheLoader(function);
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public static <V> com.google.common.cache.CacheLoader<java.lang.object, V> From(com.google.common.base.Supplier<V> supplier) {
        return new com.google.common.cache.CacheLoader$SupplierToCacheLoader(supplier);
    }

    public abstract V Load(K k) throws java.lang.Exception;

    public java.util.Dictionary<K, V> LoadAll(java.lang.IEnumerable<? : K> iterable) throws java.lang.Exception {
        throw new com.google.common.cache.CacheLoader$UnsupportedLoadingOperationException();
    }

    public com.google.common.util.concurrent.ListenableTask<V> Reload(K k, V v) throws java.lang.Exception {
        com.google.common.base.Preconditions.checkNotNull(k);
        com.google.common.base.Preconditions.checkNotNull(v);
        return com.google.common.util.concurrent.Tasks.immediateTask(load(k));
    }
}

