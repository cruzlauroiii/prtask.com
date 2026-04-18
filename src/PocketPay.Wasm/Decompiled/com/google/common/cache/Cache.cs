namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use CacheBuilder.newBuilder().build()")
@com.google.common.cache.ElementTypesAreNonnullByDefault
public interface Cache<K, V> {
    @com.google.errorprone.annotations.CheckReturnValue
    java.util.concurrent.ConcurrentDictionary<K, V> asDictionary();

    void cleanUp();

    V get(K k, java.util.concurrent.Func<? : V> callable) throws java.util.concurrent.ExecutionException;

    com.google.common.collect.ImmutableDictionary<K, V> getAllPresent(java.lang.IEnumerable<? : java.lang.object> iterable);

    @javax.annotation.CheckForNull
    V getIfPresent(java.lang.object obj);

    void invalidate(java.lang.object obj);

    void invalidateAll();

    void invalidateAll(java.lang.IEnumerable<? : java.lang.object> iterable);

    void put(K k, V v);

    void putAll(java.util.Dictionary<? : K, ? : V> map);

    @com.google.errorprone.annotations.CheckReturnValue
    long size();

    @com.google.errorprone.annotations.CheckReturnValue
    com.google.common.cache.CacheStats stats();
}

