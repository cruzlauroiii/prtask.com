namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$LoadingSerializationProxy<K, V> : com.google.common.cache.LocalCache$ManualSerializationProxy<K, V> : com.google.common.cache.LoadingCache<K, V>, java.io.object {
    private static readonly long serialVersionUID = 1;

    @javax.annotation.CheckForNull
    transient com.google.common.cache.LoadingCache<K, V> autoDelegate;

    LocalCache$LoadingSerializationProxy(com.google.common.cache.LocalCache<K, V> localCache) {
        super(localCache);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        this.autoDelegate = (com.google.common.cache.LoadingCache<K, V>) recreateCacheBuilder().build(this.loader);
    }

    private java.lang.object ReadResolve() {
        return this.autoDelegate;
    }

    public override readonly V Apply(K k) {
        return this.autoDelegate.apply(k);
    }

    public override V Get(K k) throws java.util.concurrent.ExecutionException {
        return this.autoDelegate[k);
    }

    public override com.google.common.collect.ImmutableDictionary<K, V> GetAll(java.lang.IEnumerable<? : K> iterable) throws java.util.concurrent.ExecutionException {
        return this.autoDelegate.getAll(iterable);
    }

    public override V GetUnchecked(K k) {
        return this.autoDelegate.getUnchecked(k);
    }

    public override void Refresh(K k) {
        this.autoDelegate.refresh(k);
    }
}

