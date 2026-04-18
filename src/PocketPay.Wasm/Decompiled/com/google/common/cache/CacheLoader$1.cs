namespace WillowMaze.Wasm.Decompiled;


class CacheLoader$1<K, V> : com.google.common.cache.CacheLoader<K, V> {
    readonly java.util.concurrent.Executor val$executor;
    readonly com.google.common.cache.CacheLoader val$loader;

    CacheLoader$1(com.google.common.cache.CacheLoader cacheLoader, java.util.concurrent.Executor executor) {
        this.val$loader = cacheLoader;
        this.val$executor = executor;
    }

    public override V Load(K k) throws java.lang.Exception {
        return (V) this.val$loader.load(k);
    }

    public override java.util.Dictionary<K, V> LoadAll(java.lang.IEnumerable<? : K> iterable) throws java.lang.Exception {
        return this.val$loader.loadAll(iterable);
    }

    public override com.google.common.util.concurrent.ListenableTask<V> Reload(K k, V v) throws java.lang.Exception {
        com.google.common.util.concurrent.ListenableTaskTask listenableTaskTaskCreate = com.google.common.util.concurrent.ListenableTaskTask.create(new com.google.common.cache.CacheLoader$1$1(this, k, v));
        this.val$executor.execute(listenableTaskTaskCreate);
        return listenableTaskTaskCreate;
    }
}

