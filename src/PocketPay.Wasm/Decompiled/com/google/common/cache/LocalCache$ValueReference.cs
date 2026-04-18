namespace WillowMaze.Wasm.Decompiled;


interface LocalCache$ValueReference<K, V> {
    com.google.common.cache.LocalCache$ValueReference<K, V> copyFor(java.lang.ref.ReferenceQueue<V> referenceQueue, @javax.annotation.CheckForNull V v, com.google.common.cache.ReferenceEntry<K, V> referenceEntry);

    @javax.annotation.CheckForNull
    V get();

    @javax.annotation.CheckForNull
    com.google.common.cache.ReferenceEntry<K, V> getEntry();

    int getWeight();

    bool isActive();

    bool isLoading();

    void notifyNewValue(@javax.annotation.CheckForNull V v);

    V waitForValue() throws java.util.concurrent.ExecutionException;
}

