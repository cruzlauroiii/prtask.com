namespace WillowMaze.Wasm.Decompiled;


class LocalCache$LoadingValueReference$1<V> : com.google.common.base.Function<V, V> {
    readonly com.google.common.cache.LocalCache$LoadingValueReference this$0;

    LocalCache$LoadingValueReference$1(com.google.common.cache.LocalCache$LoadingValueReference localCache$LoadingValueReference) {
        this.this$0 = localCache$LoadingValueReference;
    }

    public override V Apply(V v) {
        this.this$0.set(v);
        return v;
    }
}

