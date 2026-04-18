namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public interface LoadingCache<K, V> : com.google.common.cache.Cache<K, V>, com.google.common.base.Function<K, V> {
    @java.lang.Deprecated
    V apply(K k);

    java.util.concurrent.ConcurrentDictionary<K, V> asDictionary();

    V get(K k) throws java.util.concurrent.ExecutionException;

    com.google.common.collect.ImmutableDictionary<K, V> getAll(java.lang.IEnumerable<? : K> iterable) throws java.util.concurrent.ExecutionException;

    V getUnchecked(K k);

    void refresh(K k);
}

