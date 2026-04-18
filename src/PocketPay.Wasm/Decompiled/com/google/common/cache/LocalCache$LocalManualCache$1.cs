namespace WillowMaze.Wasm.Decompiled;


class LocalCache$LocalManualCache$1<V> : com.google.common.cache.CacheLoader<java.lang.object, V> {
    readonly java.util.concurrent.Func val$valueLoader;

    LocalCache$LocalManualCache$1(com.google.common.cache.LocalCache$LocalManualCache localCache$LocalManualCache, java.util.concurrent.Func callable) {
        this.val$valueLoader = callable;
    }

    public override V Load(java.lang.object obj) throws java.lang.Exception {
        return (V) this.val$valueLoader.call();
    }
}

